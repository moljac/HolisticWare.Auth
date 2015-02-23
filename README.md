# HolisticWare.Auth

HolisticWare.Auth temporary refactoring repo for Xamarin.Auth

## Architecture / Structure

*	Dependencies (NuGet packages)		
	*	HolisticWare.Core.Json		
		System.JSON replacement
		*	HolisticWare.Core.Reflection		
			*	HolisticWare.Core

			
### Nuget commands - Visual Studio
			
	Get-Project -All | Install-Package Microsoft.Net.Http
	Get-Project -All | Install-Package HolisticWare.Core.Json
	Get-Project HolisticWare.Auth.* | Install-Package Microsoft.Net.Http
	
	Get-Project HolisticWare.Auth.Xamarin* | UnInstall-Package Microsoft.Net.Http
	Get-Project HolisticWare.Auth.Xamarin* | Install-Package ModernHttpClient
	Get-Project HolisticWare.Auth.Portable | Install-Package System.Security.Cryptography.Hashing -Pre
	Get-Project HolisticWare.Auth.Portable | Install-Package System.Security.Cryptography.Hashing.Algorithms -Pre

## Differences with Xamrin.Auth

1.	Windows Phone		
	1.	preprocessor define PLATFORM_WINPHONE replaced with default WINDOWS_PHONE
	
## References / Links