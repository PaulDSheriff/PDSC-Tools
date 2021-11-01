using System;
using System.IO;
using System.Linq;

namespace PDSC.Common
{
	/// <summary>
	/// A class for common file methods
	/// </summary>
	public class FileCommon
	{
		private static string _CurrentDirectory = string.Empty;
		/// <summary>
		/// Get/Set the Current Directory to use for this application.
		/// This is useful for web applications where the CSFileCommon.CurrentDirectory() would not return the correct location
		/// </summary>
		public static string CurrentDirectory
		{
			get { return _CurrentDirectory; }
			set
			{
				_CurrentDirectory = value;
				if (_CurrentDirectory.EndsWith(@"\")) {
					_CurrentDirectory = _CurrentDirectory.Substring(0, _CurrentDirectory.Length - 1);
				}
			}
		}

		/// <summary>
		/// Gets the current directory in which your application is running
		/// If you are running in VS.NET it will remove the \bin folder from the path.
		/// </summary>
		/// <returns>The current directory</returns>
		public static string GetCurrentDirectory() {
			string ret;

			if (string.IsNullOrEmpty(CurrentDirectory)) {
				ret = Environment.CurrentDirectory;
			}
			else {
				ret = CurrentDirectory;
			}

			if (ret != null) {
				if (ret.IndexOf(@"\bin") > 0)
					ret = ret.Substring(0, ret.LastIndexOf(@"\bin"));
			}

			return ret;
		}
	}
}
