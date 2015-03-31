@echo off

set NUGET=.nuget\nuget

%NUGET% ^
	pack ^
	"src\HolisticWare.Auth.nuspec" ^
	-Symbols ^
	-OutputDirectory artifacts ^
	-Build ^
	-IncludeReferencedProjects ^
	-NonInteractive

:: this nuget wiil be unpacked and folder structure used to pack the last one
%NUGET% ^
	pack ^
	"src\Xamarin.Auth.Unpack.nuspec" ^
	-Symbols ^
	-OutputDirectory artifacts ^
	-Build ^
	-IncludeReferencedProjects ^
	-NonInteractive

%NUGET% ^
	pack ^
	"src\xamarin[]duplo-dep-nugets\nuspec\Xamarin.Auth.nuspec" ^
	-Symbols ^
	-OutputDirectory artifacts ^
	-Build ^
	-IncludeReferencedProjects ^
	-NonInteractive

	
echo ========================================================================
dir artifacts\
echo ========================================================================
	
	
	
@IF %ERRORLEVEL% NEQ 0 PAUSE	

