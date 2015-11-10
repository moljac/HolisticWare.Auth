using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Auth.Utilities
{
	public partial class AuthenticationService
	{
		public async Task<Account> OAuth2LoginAsync
									(
									object activity, 
									bool allowCancel,
									string client_id,
									string scope,
									Uri uri_authorize,
									Uri uri_redirect
									)
		{
			var auth = new OAuth2Authenticator
				(
				clientId: client_id,
				scope: scope,
				authorizeUrl: uri_authorize,
				redirectUrl: uri_redirect,
				getUsernameAsync: null
				)
			{
				AllowCancel = allowCancel
			};

			// If authorization succeeds or is canceled, .Completed will be fired.
			var tcs1 = new TaskCompletionSource<AuthenticatorCompletedEventArgs>();
			EventHandler<AuthenticatorCompletedEventArgs> d1 =
				(o, e) =>
				{
					try
					{
						tcs1.TrySetResult(e);
					}
					catch (Exception ex)
					{
						tcs1.TrySetResult(new AuthenticatorCompletedEventArgs(null));
					}
				};


			Account result = null;
			try
			{
				auth.Completed += d1;
				//var intent = auth.GetUI(activity);
				//activity.StartActivity(intent);
				AuthenticatorCompletedEventArgs ea = await tcs1.Task;
				result = ea.Account;
			}
			catch (Exception)
			{
				// todo you should handle the exception
				return null;
			}
			finally
			{
				auth.Completed -= d1;
			}

			return result;
		}
	}
}
