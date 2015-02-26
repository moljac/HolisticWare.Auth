#!/bin/bash

NUGET=.nuget\nuget

%NUGET% ^
	pack ^
	"src\Xamarin.Auth.nuspec" ^
	-Symbols ^
	-OutputDirectory artifacts ^
	-Build ^
	-IncludeReferencedProjects ^
	-NonInteractive

@IF %ERRORLEVEL% NEQ 0 PAUSE	

