using System.Net;
using System.Net.Http.Json;

namespace PDSC.Common.HttpClasses;
/// <summary>
/// All repository classes that make calls to Web API endpoints 
/// using the HttpClient class should inherit from this class
/// </summary>
public class HttpClientRepositoryBase : RepositoryBase
{
  #region Constructors
  public HttpClientRepositoryBase()
  {
    Init();
  }

  public HttpClientRepositoryBase(HttpClient client)
  {
    Init();
    HClient = client;
  }
  #endregion

  #region Public Properties
  /// <summary>
  /// Get/Set the instance of the HttpClient to use
  /// </summary>
  public HttpClient? HClient { get; set; }

  /// <summary>
  /// Get/Set the base address such as www.pdsa.com
  /// </summary>
  public string BaseAddress { get; set; } = string.Empty;
  /// <summary>
  /// Get/Set the UrlPath such as /api/Customer
  /// </summary>
  public string UrlPath { get; set; } = string.Empty;
  /// <summary>
  /// Get/Set the UrlSearchRoute such as /Search
  /// </summary>
  public string UrlSearchRoute { get; set; } = "/Search";
  /// <summary>
  /// Get/Set the UrlCountRoute such as /Count
  /// </summary>
  public string UrlCountRoute { get; set; } = "/Count";
  /// <summary>
  /// Get/Set the UrlQuery such as /api/Customer?firstName=p&lastName=s
  /// </summary>
  public string UrlQuery { get; set; } = string.Empty;
  /// <summary>
  /// Get/Set the UserAgent such as the application name "Customer Maintenance"
  /// </summary>
  public string UserAgent { get; set; } = string.Empty;
  /// <summary>
  /// Get/Set the content type you want returned such as "application/json"
  /// </summary>
  public string ContentType { get; set; } = "application/json";
  /// <summary>
  /// Get/Set any additional headers you want to send to the Web API server
  /// </summary>
  public Dictionary<string, string> Headers { get; set; } = new();
  #endregion

  #region Init Method
  public override void Init()
  {
    base.Init();

    BaseAddress = string.Empty;
    UrlPath = string.Empty;
    UrlQuery = string.Empty;
    UrlSearchRoute = "/Search";
    UrlCountRoute = "/Count";
    UserAgent = string.Empty;
    Headers = new();
  }
  #endregion

  #region FixUrlParts Method
  protected virtual void FixUrlParts()
  {
    // Make sure the BaseAddress does not end with a forward slash
    BaseAddress = BaseAddress.EndsWith("/") ? BaseAddress[..^1] : BaseAddress;
    // Make sure the UrlPath starts with a forward slash
    UrlPath = UrlPath.StartsWith("/") ? UrlPath : UrlPath[1..];
    // Make sure the UrlPath does not end with a forward slash
    UrlPath = UrlPath.EndsWith("/") ? UrlPath[..^1] : UrlPath;
  }
  #endregion

  #region BuildUrlQueryParameters Method
  public string BuildUrlQueryParameters(object search)
  {
    return BuildUrlQueryParameters(search, new());
  }

  public string BuildUrlQueryParameters(object search, List<string> excludeProperties)
  {
    List<string> queryParams = new();
    // Ensure all properties to exclude are lower case
    if (excludeProperties.Count > 0) {
      for (int index = 0; index < excludeProperties.Count; index++) {
        excludeProperties[index] = excludeProperties[index].ToLower();
      }
    }

    // Do NOT add properties decorated with [JsonIgnore]
    // to the URI Query
    var props = search.GetType().GetProperties().ToList();
    foreach (var item in props) {
      if (!excludeProperties.Contains(item.Name.ToLower())) {
        // Only get those properties with no [JsonIgnore] attribute
        if (!item.GetCustomAttributes(true).ToList().Where(a => a.ToString() == "System.Text.Json.Serialization.JsonIgnoreAttribute").Any()) {
          string? value = (string?)item.GetValue(search);
          if (!string.IsNullOrWhiteSpace(value)) {
            queryParams.Add($"{item.Name}={Uri.EscapeDataString(value)}");
          }
        }
      }
    }

    return string.Join('&', queryParams.ToArray());
  }
  #endregion

  #region SetBaseAddressAndHeaders Method
  protected void SetBaseAddressAndHeaders(HttpClient client)
  {
    // TODO: Check out this URL: https://code-maze.com/httpclient-example-aspnet-core-post-put-delete/
    // TODO: Use IHttpClientFactory? https://learn.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-7.0

    // Set the base address such as https://www.pdsa.com
    client.BaseAddress = new Uri(BaseAddress);
    // Clear Accept Headers
    //client.DefaultRequestHeaders.Accept.Clear();
    // Add Content Type Default="application/json"
    //client.DefaultRequestHeaders.Accept.Add(new(ContentType));
    // Add the User-Agent
    //client.DefaultRequestHeaders.Add("User-Agent", UserAgent.Replace(" ", ""));
    // Add the Connection
    ///client.DefaultRequestHeaders.Add("Connection", "keep-alive");
    // Add any additional headers
    //foreach (var header in Headers) {
    //  client.DefaultRequestHeaders.Add(header.Key, header.Value);
    //}
  }
  #endregion

  #region SubmitAsyncQuery Methods
  /// <summary>
  /// Get all records from the data store
  /// </summary>
  /// <typeparam name="T">The type to return</typeparam>
  /// <returns>An HttpDataResponse object</returns>
  public async Task<DataResponse<T>> GetAsync<T>(string urlPath) where T : class
  {
    UrlPath = urlPath;
    UrlQuery = string.Empty;
    return await SubmitAsyncQuery<T>(HttpClientRequestTypeEnum.Get, null);
  }

  /// <summary>
  /// Get a single record from the data store
  /// </summary>
  /// <typeparam name="T">The type to return</typeparam>
  /// <param name="id"></param>
  /// <returns>An HttpDataResponse object</returns>
  public async Task<DataResponse<T>> GetAsync<T>(string urlPath, string id) where T : class
  {
    UrlPath = urlPath;
    UrlQuery = $"/{id}";
    return await SubmitAsyncQuery<T>(HttpClientRequestTypeEnum.Get, null);
  }

  public async Task<DataResponse<TEntity>> SearchAsync<TEntity, TSearch>(string urlPath, TSearch? search) where TEntity : class
  {
    UrlPath = urlPath;
    UrlPath += UrlSearchRoute;
    if (search == null) {
      UrlQuery = string.Empty;
    }
    else {
      UrlPath += "?";
      UrlQuery = BuildUrlQueryParameters(search, new List<string>() { "SortExpression" });
    }

    return await SubmitAsyncQuery<TEntity>(HttpClientRequestTypeEnum.Get, null);
  }

  public async Task<DataResponse<T>> CountAsync<T, TSearch>(string urlPath, TSearch? search) where TSearch : class
  {
    UrlPath = urlPath;
    UrlPath += UrlCountRoute;
    if (search == null) {
      UrlQuery = string.Empty;
    }
    else {
      UrlQuery = BuildUrlQueryParameters(search);
      if (!string.IsNullOrWhiteSpace(UrlQuery)) {
        UrlPath += "?";
      }
    }

    return await SubmitAsyncQuery<T>(HttpClientRequestTypeEnum.Count, default);
  }

  public async Task<DataResponse<T>> PostAsync<T>(string urlPath, T? entity) where T : class
  {
    UrlPath = urlPath;
    UrlQuery = string.Empty;
    return await SubmitAsyncQuery(HttpClientRequestTypeEnum.Post, entity);
  }

  public async Task<DataResponse<T>> PutAsync<T>(string urlPath, string id, T? entity) where T : class
  {
    UrlPath = urlPath;
    UrlQuery = $"/{id}";

    return await SubmitAsyncQuery(HttpClientRequestTypeEnum.Put, entity);
  }

  public async Task<DataResponse<T>> DeleteAsync<T>(string urlPath, string id) where T : class
  {
    UrlPath = urlPath;
    UrlQuery = $"/{id}";

    return await SubmitAsyncQuery<T>(HttpClientRequestTypeEnum.Delete, null);
  }

  protected async Task<DataResponse<T>> SubmitAsyncQuery<T>(HttpClientRequestTypeEnum requestType, T? payload)
  {
    DataResponse<T>? ret = new();
    HttpResponseMessage? resp = null;

    if (HClient == null) {
      ret.StatusMessage = "HttpClient is null.";
      ret.ResultMessage = "HttpClient is null.";
      ret.StatusCode = HttpStatusCode.BadRequest;
    }
    else {
      // Set the base address
      BaseAddress = HClient?.BaseAddress?.AbsoluteUri ?? string.Empty;

      // Make sure all URL parts are ready to submit
      FixUrlParts();

      // Reset Messages
      base.ResetMessages();

      try {
        // Open Path and Verify a Valid URI Address
        switch (requestType) {
          case HttpClientRequestTypeEnum.Get:
          case HttpClientRequestTypeEnum.Count:
            if (HClient != null) {
              resp = await HClient.GetAsync(UrlPath + UrlQuery);
            }
            break;
          case HttpClientRequestTypeEnum.Post:
            if (HClient != null) {
              resp = await HClient.PostAsJsonAsync(UrlPath, payload);
            }
            break;
          case HttpClientRequestTypeEnum.Put:
            if (HClient != null) {
              resp = await HClient.PutAsJsonAsync(UrlPath + UrlQuery, payload);
            }
            break;
          case HttpClientRequestTypeEnum.Delete:
            if (HClient != null) {
              resp = await HClient.DeleteAsync(UrlPath + UrlQuery);
            }
            break;
        }
        if (resp != null) {
          // Store the response object into DataResponse object
          ret.StatusCode = resp.StatusCode;
          ret.StatusMessage = resp.ReasonPhrase;
          // Was the call successful?
          if (resp.IsSuccessStatusCode) {
            // Write out response information
            resp.EnsureSuccessStatusCode().WriteRequestToConsole();
            try {
              // Convert return value into a DataResponse object
              ret = await resp.Content.ReadFromJsonAsync<DataResponse<T>>();
              // See if a null was returned
              ret ??= new()
              {
                StatusCode = HttpStatusCode.InternalServerError,
                LastException = new("Object returned from Web API call is null"),
                ResultMessage = "Object returned from Web API call is null"
              };
            }
            catch (Exception ex) {
              ret = new()
              {
                StatusCode = HttpStatusCode.InternalServerError,
                LastException = ex,
                ResultMessage = "Error attempting to convert JSON into C# object"
              };
            }
          }
          else if (resp.StatusCode == HttpStatusCode.BadRequest) {
            // Validation Errors
            ValidationError? val = await resp.Content.ReadFromJsonAsync<ValidationError>();
            if (val != null) {
              val.DictionaryToValidationMessages();
              throw new ValidationException(val);
            }
          }
          else {
            // Store exception info into DataResponse object
            ret = new()
            {
              StatusCode = resp == null ? HttpStatusCode.BadRequest : resp.StatusCode,
              LastException = new ApplicationException("Response status code is NOT successful"),
              ResultMessage = "Response status code is NOT successful"
            };
          }
        }
        else {
          // Store exception info into DataResponse object
          ret = new()
          {
            StatusCode = HttpStatusCode.InternalServerError,
            LastException = new("HttpResponseMessage Object is null"),
            ResultMessage = "HttpResponseMessage object is null"
          };
        }
      }
      catch (ValidationException ex) {
        // Rethrow the Validation Exception
        throw ex;
      }
      catch (Exception ex) {
        // Store the last exception
        LastException = ex;
        // Store exception info into DataResponse object
        ret = new()
        {
          StatusCode = HttpStatusCode.InternalServerError,
          LastException = LastException,
          ResultMessage = ex.Message
        };
      }

      // Set DataResponse Message
      ret.StatusMessage = string.IsNullOrEmpty(ret.StatusMessage) ? Enum.GetName(ret.StatusCode) : ret.StatusMessage;
    }

    return ret;
  }
  #endregion
}
