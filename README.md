# HolisticWare.Auth

HolisticWare.Auth temporary refactoring repo for Xamarin.Auth

This repo contains 

## Architecture / Structure

*	Dependencies (NuGet packages)		
	*	HolisticWare.Core.Json		
		System.JSON from Silverlight framework replacement
		*	HolisticWare.Core.Reflection		
			*	HolisticWare.Core

Xamarin.Auth projects:

1.	Xamarin.Auth.LinkSource		
	net45 library (desktop) can be used for unit tests
2.	Xamarin.Auth.Portable		
	portable version for bait-and-switch
3.	Xamarin.Auth.XamarinAndroid		
4.	Xamarin.Auth.XamarinIOS		
5.	Xamarin.Auth.WindowsPhone8		
	
			
### Xamarin.Auth

Xamarin.Auth = HolisticWare.Auth - nuget(HolisticWare.Core.Json) + dependency(System.Json)

System.Jsom

*	framework assembly for Xamarin.Android and Xamarin.iOS
*	linked source for WindowsPhone8

get-Project Xamarin.Auth.LinkSource			| UnInstall-Package 	HolisticWare.Core.Json
get-Project Xamarin.Auth.LinkSource			| UnInstall-Package 	HolisticWare.Core.Reflection
get-Project Xamarin.Auth.LinkSource			| UnInstall-Package 	HolisticWare.Core
get-Project Xamarin.Auth.Portable			| UnInstall-Package 	HolisticWare.Core.Json
get-Project Xamarin.Auth.Portable			| UnInstall-Package 	HolisticWare.Core.Reflection
get-Project Xamarin.Auth.Portable			| UnInstall-Package 	HolisticWare.Core
get-Project Xamarin.Auth.XamarinAndroid		| UnInstall-Package 	HolisticWare.Core.Json
get-Project Xamarin.Auth.XamarinAndroid		| UnInstall-Package 	HolisticWare.Core.Reflection
get-Project Xamarin.Auth.XamarinAndroid		| UnInstall-Package 	HolisticWare.Core
get-Project Xamarin.Auth.XamarinIOS			| UnInstall-Package 	HolisticWare.Core.Json
get-Project Xamarin.Auth.XamarinIOS			| UnInstall-Package 	HolisticWare.Core.Reflection
get-Project Xamarin.Auth.XamarinIOS			| UnInstall-Package 	HolisticWare.Core
get-Project Xamarin.Auth.XamarinIOS.Classic	| UnInstall-Package 	HolisticWare.Core.Json
get-Project Xamarin.Auth.XamarinIOS.Classic	| UnInstall-Package 	HolisticWare.Core.Reflection
get-Project Xamarin.Auth.XamarinIOS.Classic	| UnInstall-Package 	HolisticWare.Core
get-Project Xamarin.Auth.WindowsPhone8		| UnInstall-Package 	HolisticWare.Core.Json
get-Project Xamarin.Auth.WindowsPhone8		| UnInstall-Package 	HolisticWare.Core.Reflection
get-Project Xamarin.Auth.WindowsPhone8		| UnInstall-Package 	HolisticWare.Core

get-Project Xamarin.Auth.Sample.WinPhone	| UnInstall-Package 	HolisticWare.Core.Json
get-Project Xamarin.Auth.Sample.WinPhone	| UnInstall-Package 	HolisticWare.Core.Reflection
get-Project Xamarin.Auth.Sample.WinPhone	| UnInstall-Package 	HolisticWare.Core



Source in Portable version solves (this is normally in HolisticWare.Core packages)

*	missing complete System.Json assembly and namespace
*	errors due to portable subset:		
	*	'System.Type' does not contain a definition for 'GetTypeCode'			
		Xamarin.Auth.LinkSource\System.Json\JsonPrimitive.cs		
	*	'decimal' does not contain a definition for 'Round'			
		Xamarin.Auth.LinkSource\System.Json\JavaScriptReader.cs			





			
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