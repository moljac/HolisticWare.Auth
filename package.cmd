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

@IF %ERRORLEVEL% NEQ 0 PAUSE	

