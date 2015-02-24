//
//  Copyright 2012-2013, Xamarin Inc.
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Xamarin.Auth.Test
{
	[TestFixture]
	public partial class OAuth2Facebook
	{
		OAuth2Authenticator	auth = null;


		[Test]
		public void Login()
		{
			SensitiveData.InitializeSensitveDataFacebook();

			auth = new OAuth2Authenticator 
				(
				clientId: "App ID from https://developers.facebook.com/apps",
				scope: "",
				authorizeUrl: new Uri ("https://m.facebook.com/dialog/oauth/"),
				redirectUrl: new Uri ("http://www.facebook.com/connect/login_success.html")
				);

			return;
		}

	}
}

