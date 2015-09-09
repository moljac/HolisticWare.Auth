using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinAuth.Views
{
	public partial class PageMain : ContentPage
	{
		public PageMain ()
		{
			InitializeComponent ();
		}



		Page page = null;

		
		public void OnItemSelected (object sender, ItemTappedEventArgs args_tapped)
		{
			object item = args_tapped.Item;

			KeyValuePair<string, string> kvp = (KeyValuePair<string, string>)item;

			string authentication_provider = kvp.Value;


			switch (authentication_provider)
			{
				case "Google OAuth2":
					SetPublicDemoDataGoogleOAuth2();
					SetSensitiveDataGoogleOAuth2();

					page = new HolisticWare.XamarinForms.Authentication.PageLogin(oauth2);

					break;
				case "Facebook OAuth2":
					SetPublicDemoDataFacebookOAuth2();
					SetSensitiveDataFacebookOAuth2();

					page = new HolisticWare.XamarinForms.Authentication.PageLogin(oauth2);

					break;
				case "Twitter OAuth1":
					SetPublicDemoDataTwitterOAuth1();
					SetSensitiveDataTwitterOAuth1();

					page = new HolisticWare.XamarinForms.Authentication.PageLogin(oauth1);

					break;
				case "Microsoft Live OAuth2":
					SetPublicDemoDataMicrosoftLiveOAuth2();
					SetSensitiveDataMicrosoftLiveOAuth2();

					page = new HolisticWare.XamarinForms.Authentication.PageLogin(oauth2);

					break;
				case "Instagram OAuth2":
					SetPublicDemoDataInstagramOAuth2();
					SetSensitiveDataInstagramOAuth2();

					page = new HolisticWare.XamarinForms.Authentication.PageLogin(oauth2);

					break;
				case "LinkedIn OAuth1":
					SetPublicDemoDataLinkedInOAuth1();
					SetSensitiveDataLinkedInOAuth1();

					page = new HolisticWare.XamarinForms.Authentication.PageLogin(oauth1);

					break;
				case "LinkedIn OAuth2":
					SetPublicDemoDataLinkedInOAuth2();
					SetSensitiveDataLinkedInOAuth2();

					page = new HolisticWare.XamarinForms.Authentication.PageLogin(oauth2);

					break;
				case "Github OAuth2":
					SetPublicDemoDataGithubOAuth2();
					SetSensitiveDataGithubOAuth2();

					page = new HolisticWare.XamarinForms.Authentication.PageLogin(oauth2);

					break;
				default:
					string msg = "Unknown Authentication Provider: " + authentication_provider;
					throw new NotImplementedException(msg);
			}

			this.Navigation.PushAsync(page);

			return;

		}

	}
}

