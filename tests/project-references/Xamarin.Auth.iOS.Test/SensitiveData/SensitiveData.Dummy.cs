using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Auth.Test
{
	public partial class SensitiveData
	{
		public static Dictionary<string, string> Data = null;


		public static void InitializeSensitveDataFacebook()
		{
			LoadInitialDummyDataFacebook();

			//	thic call will be removed if not found
			//	put sources in SensitiveData/User/ 
			//	or modify wildcards for inclusion in project file (csproj)

			LoadRealSensitiveDataForMoljacFacebook();

			return;
		}
		private static void LoadInitialDummyDataFacebook()
		{
			Data = new Dictionary<string, string>()
			{
				{"client_id", "<Client/App ID from https://developers.facebook.com/apps>"},
				{"scope",""},
				{"url_authorize","https://m.facebook.com/dialog/oauth/"},
				{"url_redirect","http://xamarin.com"},
			};

			return;
		}

		/// <summary>
		///  Following methods (calls to them) will be removed 
		///  if the definition/implementation is not found
		///  
		///		add partial class file in SensitiveData/ folder
		///  
		///		the c# source files are in SensitiveData/ folder and are
		///		included in project through wildcards...
		///		
		/// 
		/// </summary>
		static partial void LoadRealSensitiveDataForMoljacFacebook();
		static partial void LoadRealSensitiveDataForMoljacLinkedIn();


	}
}
