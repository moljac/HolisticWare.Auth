@echo off

set NUGET=.nuget\nuget

::=============================================================================
:: 	NOTE: do not push this to public repos!
:: 	sample snippet for the .gitignore
	**/*.secure*
	**/*.secret*	
::----------------------------------------------------------------------------
::	following script sets only few environment variables
::	API_KEY
::
set FILE=nuget-set-api-key.secure.cmd

If exist %FILE% (
call %FILE%
)

echo API_KEY = %API_KEY%

::=============================================================================

%NUGET% ^
	push ^
	artifacts\HolisticWare*.nupkg
	
pause
::@IF %ERRORLEVEL% NEQ 0 PAUSE	
