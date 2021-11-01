using System;
using System.Diagnostics;
using System.Xml.Linq;
using System.Xml.XPath;

namespace PDSC.Common.Tracing
{
	/// <summary>
	/// This class is used to trace calls during debug or runtime. This class uses the Trace classes built into .NET
	/// <remarks>
	/// Add the following to the .config file for your application
	/// 
	/// &lt;system.diagnostics&gt;
	///   &lt;trace autoflush="true"/&gt;
	///   &lt;sources&gt;
	///     &lt;source name="CSTracer"
	///             switchName="CompusourceTracerSwitch"
	///             switchType="System.Diagnostics.SourceSwitch" &gt;
	///       &lt;listeners&gt;
	///         &lt;add name="CSTracer"
	///              type="System.Diagnostics.TextWriterTraceListener"
	///              initializeData="MyApplication.log" /&gt;
	///         &lt;remove name="Default" /&gt;
	///         &lt;!-- Uncomment the following to stop tracing --&gt;
	///         &lt;!--&lt;remove name="CSTracer" /&gt;--&gt;
	///       &lt;/listeners&gt;
	///     &lt;/source&gt;
	///   &lt;/sources&gt;
	///   &lt;switches&gt;
	///     &lt;add name="CompusourceTracerSwitch"
	///          value="Information" /&gt;
	///   &lt;/switches&gt;
	/// &lt;/system.diagnostics&gt;
	/// </remarks>
	/// 
	/// <example>
	/// CSTracer.Instance.Log("ClassName", "MethodName", "Message to write");
	/// CSTracer.Instance.Log("MethodName", "Message to write");
	/// CSTracer.Instance.Log("Message to write");
	/// </example>
	/// </summary>
	public class PDSCTracer
	{
		#region Constructors
		/// <summary>
		/// Constructor for CSTracer class
		/// </summary>
		public PDSCTracer() {
			Init();
		}

		/// <summary>
		/// Constructor for CSTracer class
		/// </summary>
		/// <param name="listenerName">Listener Name</param>
		/// <param name="switchName">Switch Name</param>
		public PDSCTracer(string listenerName, string switchName) {
			Init();

			ListenerName = listenerName;
			SwitchName = switchName;
		}
		#endregion

		#region Instance Property
		// This approach ensures that only one instance is created and only when the instance is needed. 
		// Also, the variable is declared to be volatile to ensure that assignment to the instance variable 
		// completes before the instance variable can be accessed. 
		// Lastly, this approach uses a syncRoot instance to lock on, rather than locking on the type itself, to avoid deadlocks. 
		//
		// This double-check locking approach solves the thread concurrency problems while avoiding an exclusive lock 
		// in every call to the Instance property method. 
		// It also allows you to delay instantiation until the object is first accessed.
		// In practice, an application rarely requires this type of implementation. 
		// In most cases, the static initialization approach is sufficient.
		private static volatile PDSCTracer _Instance = null;
		private static object syncRoot = new();

		/// <summary>
		/// Get/Set a Thread-Safe Instance of the CSTracer class
		/// </summary>
		public static PDSCTracer Instance
		{
			get
			{
				if (_Instance == null) {
					lock (syncRoot) {
						if (_Instance == null) {
							_Instance = new PDSCTracer();
						}
					}
				}

				return _Instance;
			}
			set { _Instance = value; }
		}
		#endregion

		#region Public Properties
		/// <summary>
		/// Get/Set the Trace Provider
		/// </summary>
		public TraceSource TraceProvider = null;
		/// <summary>
		/// Get/Set the Listener Name. This property is required.
		/// </summary>
		public string ListenerName { get; set; }
		/// <summary>
		/// Get/Set the Listener Name. This property is required.
		/// </summary>
		public string SwitchName { get; set; }
		/// <summary>
		/// Get/Set the Class Name you are tracing
		/// </summary>
		public string ClassName { get; set; }
		/// <summary>
		/// Get/Set the Method Name you are tracing
		/// </summary>
		public string MethodName { get; set; }
		/// <summary>
		/// Get/Set whether or not add the Date and Time to the message
		/// </summary>
		public bool AddDateTime { get; set; }
		/// <summary>
		/// Get/Set whether or not add the Class Name to the message
		/// </summary>
		public bool AddClassName { get; set; }
		/// <summary>
		/// Get/Set whether or not add the Method Name to the message
		/// </summary>
		public bool AddMethodName { get; set; }
		/// <summary>
		/// Get/Set whether or not add to write the message to the debug window using Debug.WriteLine()
		/// </summary>
		public bool WriteToDebugWindow { get; set; }
		/// <summary>
		/// Get/Set whether or not to use DateTime.UtcNow or DateTime.Now
		/// </summary>
		public bool UseUTCDateTime { get; set; }
		#endregion

		#region Init Method
		/// <summary>
		/// Initialize all properties to a valid start state
		/// NOTE: ListenerName is initialized to "CSTracer" and SwitchName is initialized to "CompusourceTracerSwitch"
		/// All 'Add' properties are initialized to true.
		/// </summary>
		public virtual void Init() {
			GetDefaultTracerAndSwitch();

			if (string.IsNullOrEmpty(ListenerName)) {
				ListenerName = PDSCConstants.TRACE_LISTENER_NAME;
			}
			if (string.IsNullOrEmpty(SwitchName)) {
				SwitchName = PDSCConstants.TRACE_LISTENER_SWITCH_NAME;
			}
			ClassName = string.Empty;
			MethodName = string.Empty;

			AddDateTime = true;
			AddClassName = true;
			AddMethodName = true;
			WriteToDebugWindow = true;
			UseUTCDateTime = false;
		}
		#endregion

		#region GetDefaultTracerAndSwitch Method
		/// <summary>
		/// Get the default ListenerName and SwitchName from the .Config file
		/// </summary>
		protected virtual void GetDefaultTracerAndSwitch() {
			//XDocument xd;

			//xd = XDocument.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

			//XElement elem = xd.XPathSelectElement("//configuration/system.diagnostics/sources/source");
			//if (elem != null) {
			//	if (elem.Attribute("name") != null) {
			//		ListenerName = elem.Attribute("name").Value;
			//	}
			//	if (elem.Attribute("switchName") != null) {
			//		SwitchName = elem.Attribute("switchName").Value;
			//	}
			//}
		}
		#endregion

		#region Log Methods
		/// <summary>
		/// Write a message to the listener
		/// </summary>
		/// <param name="msg">The message to write</param>
		public virtual void Log(string msg) {
			Log(string.Empty, string.Empty, msg);
		}

		/// <summary>
		/// Write a message to the listener
		/// </summary>
		/// <param name="methodName">A method name</param>
		/// <param name="msg">The message to write</param>
		public virtual void Log(string methodName, string msg) {
			MethodName = methodName;

			Log(string.Empty, methodName, msg);
		}

		/// <summary>
		/// Write a message to the listener
		/// </summary>
		/// <param name="className">A class name</param>
		/// <param name="methodName">A method name</param>
		/// <param name="msg">The message to write</param>
		public virtual void Log(string className, string methodName, string msg) {
			string msgFormat;
			DateTime dateToWrite = DateTime.Now;

			if (UseUTCDateTime) {
				dateToWrite = DateTime.UtcNow;
			}

			ClassName = className;
			MethodName = methodName;

			if (TraceProvider == null) {
				TraceProvider = new(ListenerName);
				TraceProvider.Switch = new(SwitchName);
				TraceProvider.Switch.Level = SourceLevels.Information;
			}

			msgFormat = "{0} - {1} - {2}: {3}";

			msg = string.Format(msgFormat,
				(AddDateTime ? dateToWrite.ToString() : ""),
				(AddClassName ? className : ""),
				(AddMethodName ? methodName : ""),
				msg);

			TraceProvider.TraceInformation(msg);

			if (WriteToDebugWindow)
				System.Diagnostics.Debug.WriteLine(msg);
		}
		#endregion

		#region Close Method
		/// <summary>
		/// Flush and Close the Tracer
		/// </summary>
		public virtual void Close() {
			if (TraceProvider != null) {
				TraceProvider.Flush();
				TraceProvider.Close();
			}
		}
		#endregion
	}
}
