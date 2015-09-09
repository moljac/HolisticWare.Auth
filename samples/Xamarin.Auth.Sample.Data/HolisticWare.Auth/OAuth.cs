using System;
using System.Collections.Generic;

namespace HolisticWare.Auth
{
	/*
			WORKING!!
				Facebook
					OAuth2
						scope = "";				// email, basic, ...
						uri_authorize =  new Uri("https://m.facebook.com/dialog/oauth/");
						uri_callback_redirect = new Uri("http://xamarin.com");

				Twitter
					OAuth1
						  "DynVhdIjJDZSdQMb8KSLTA",
						  "REvU5dCUQI4MvjV6aWwUWVUqwObu3tvePIdQVBhNo",
						  new Uri("https://api.twitter.com/oauth/request_token"),
						  new Uri("https://api.twitter.com/oauth/authorize"),
						  new Uri("https://api.twitter.com/oauth/access_token"),
						  new Uri("http://twitter.com"

			LINKS / REFERENCES:

				https://forums.xamarin.com/discussion/3420/xamarin-auth-with-twitter
				https://forums.xamarin.com/discussion/16100/oauth-twitter-and-xamarin-article-authenticate-with-xamarin-auth
				http://visualstudiomagazine.com/articles/2014/04/01/using-oauth-twitter-and-async-to-display-data.aspx?m=2
				https://forums.xamarin.com/discussion/15869/xamarin-auth-twitter-authentication-process-failing
				https://forums.xamarin.com/discussion/4178/does-twitter-oauth-work-with-xamarin-auth
				http://www.codeproject.com/Tips/852742/Simple-Twitter-client-using-Xamarin-Forms-Xamarin

	*/
	public abstract partial class OAuth
	{
		public OAuth ()
		{
		}


		/// <summary>
		///		OAuth = OAuth1 and OAuth2
		/// 		Facebook: 	API ID / Client ID
		///			Twitter:	Consumer key / API key
		///			LinkedIn:	API key
		///			google:		
		///		
		/// </summary>
		public string OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer
		{
			get;
			set;
		}

		/// <summary>
		/// 	OAuth = OAuth1 and OAuth2
		/// </summary>
		public Uri OAuth_UriAuthorization
		{
			get;
			set;
		}

		/// <summary>
		/// 	OAuth = OAuth1 and OAuth2
		/// </summary>
		public Uri OAuth_UriCallbackAKARedirect
		{
			get;
			set;
		}


		//-------------------------------------------------------------------------
		# region Property Dictionary<string,string> AccountProperties w Event post (AccountPropertiesChanged)
		/// <summary>
		/// AccountProperties
		/// </summary>
		public
		  Dictionary<string,string>
		  AccountProperties
		{
			get
			{
				return account_properties;
			} // AccountProperties.get
			set
			{
				//if (account_properties != value)		// do not write if equivalent/equal/same
				{
					// for multi threading apps uncomment lines beginnig with //MT:
					//MT: lock(account_properties) // MultiThread safe				
					{
						account_properties = value;
						if (null != AccountPropertiesChanged)
						{
							AccountPropertiesChanged(this, new EventArgs());
						}
					}
				}
			} // AccountProperties.set
		} // AccountProperties

		/// <summary>
		/// private member field for holding AccountProperties data
		/// </summary>
		private
			Dictionary<string,string>
			account_properties
			;

		///<summary>
		/// Event for wiring BusinessLogic object changes and presentation
		/// layer notifications.
		/// AccountPropertiesChanged (<propertyname>Changed) is intercepted by Windows Forms
		/// 1.x and 2.0 event dispatcher 
		/// and for some CLR types by WPF event dispatcher 
		/// usually INotifyPropertyChanged and PropertyChanged event
		///</summary>
		public
			event
			EventHandler
			AccountPropertiesChanged
			;
		# endregion Property Dictionary<string,string> AccountProperties w Event post (AccountPropertiesChanged)
		//-------------------------------------------------------------------------
	
	}
}

