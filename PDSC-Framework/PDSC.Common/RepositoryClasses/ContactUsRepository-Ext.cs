using PDSC.Common.EntityLayer;

namespace PDSC.Common.DataLayer
{
  public partial class ContactUsRepository
  {
    #region IsDuplicateReport Method
    public bool IsDuplicateReport(ContactUs entity)
    {
      bool ret = false;

      // Create SQL
      //string sql = "Lookup.ContactUsIsDuplicate @FirstName, @LastName, @EmailAddress, @ContactText ";
      //List<SqlParameter> parameters = new List<SqlParameter>
      //{
      //  // Create parameters
      //  new SqlParameter { ParameterName = "@FirstName", Value = (object)entity.FirstName},
      //  new SqlParameter { ParameterName = "@LastName", Value = (object)entity.LastName},
      //  new SqlParameter { ParameterName = "@EmailAddress", Value = (object)entity.EmailAddress},
      //  new SqlParameter { ParameterName = "@ContactText", Value = (object)entity.ContactText}
      //};
      //DbConnection cnn = _DbContext.Database.GetDbConnection();      
      //DbCommand cmd = cnn.CreateCommand();
      //cmd.CommandText = sql;
      //cmd.Parameters.AddRange(parameters.ToArray());

      //try {
      //  // Call SQL with parameters
      //  if (cnn.State == System.Data.ConnectionState.Closed) {
      //    cnn.Open();
      //  }
      //  int total = (int)cmd.ExecuteScalar();
      //  ret = total > 0;
      //}
      //catch (Exception ex) {
      //  // TODO: Do something with the exception
      //  Console.WriteLine(ex.ToString());

      //  //// Create a data exception object
      //  //DataException dex = new DataException("Exception in ContactUs.IsDuplicateReport() method.", ex)
      //  //{
      //  //  SQL = sql
      //  //};
      //  //dex.SetParameterValuesFromList(parameters);
      //  //// Throw the exception
      //  //throw dex;
      //}
      //finally {
      //  //if (cmd != null) {
      //  //  cmd.Dispose();
      //  //}
      //}

      return ret;
    }
    #endregion
  }
}
