using System;
using Xamarin.Auth.Helpers;

namespace Xamarin.Auth.SampleData
{
	public partial class Data 
	{
		static partial void SetSensitiveDataFacebookOAuth2()
		{
			oauth2 = new Xamarin.Auth.Helpers.OAuth2()
			{
				Description = "Facebook OAuth2",
				OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer = "1609587185978295",
				OAuth2_Scope = "email", 					// "", "basic", "email",
				OAuth_UriAuthorization = new Uri("https://m.facebook.com/dialog/oauth/"), 
				OAuth_UriCallbackAKARedirect = new Uri("https://xamarin.com"),
				AllowCancel = true,
			};

			if (TestCases.ContainsKey(oauth2.Description))
			{
				TestCases[oauth2.Description] = oauth2;
			}
			else
			{
				TestCases.Add(oauth2.Description, oauth2);
			}
						
			return;
		}
	}
}

