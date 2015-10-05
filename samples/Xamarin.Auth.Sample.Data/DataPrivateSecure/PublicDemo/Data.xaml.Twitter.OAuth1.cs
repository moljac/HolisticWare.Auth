﻿using System;

namespace Xamarin.Auth.SampleData
{
	public partial class Data
	{
		partial void SetPublicDemoDataTwitterOAuth1()
		{
			oauth1 = new HolisticWare.Auth.OAuth1()
			{
				OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer = "",
				OAuth1_SecretKey_ConsumerSecret_APISecret = "",
				OAuth1_UriRequestToken = new Uri("https://api.twitter.com/oauth/request_token"),
				OAuth_UriAuthorization = new Uri("https://api.twitter.com/oauth/authorize"), 
				OAuth_UriCallbackAKARedirect = new Uri("http://xamarin.com"),
				OAuth1_UriAccessToken = new Uri("https://api.twitter.com/oauth/access_token"),
			};

			TestCases.Add(oauth1);

			return;
		}
	}
}

