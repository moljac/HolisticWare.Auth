@echo off

set NUGET=.nuget\NuGet.exe

del /q artifacts\*.*

%NUGET% ^
	pack ^
	"nuget\HolisticWare.Auth.nuspec" ^
	-Symbols ^
	-OutputDirectory artifacts ^
	-Build ^
	-IncludeReferencedProjects ^
	-NonInteractive

:: this nuget wiil be unpacked and folder structure used to pack the last one
%NUGET% ^
	pack ^
	"nuget\Xamarin.Auth.Unpack.nuspec" ^
	-Symbols ^
	-OutputDirectory artifacts ^
	-Build ^
	-IncludeReferencedProjects ^
	-NonInteractive

%NUGET% ^
	pack ^
	"nuget\xamarin[]duplo-dep-nugets\nuspec\Xamarin.Auth.nuspec" ^
	-Symbols ^
	-OutputDirectory artifacts ^
	-Build ^
	-IncludeReferencedProjects ^
	-NonInteractive

	
echo ========================================================================
dir artifacts\
echo ========================================================================
	
pause	
	
::@IF %ERRORLEVEL% NEQ 0 PAUSE	

