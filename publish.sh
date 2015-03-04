#!/bin/bash

NUGET=.nuget\nuget

#=============================================================================
# 	NOTE: do not push this to public repos!
# 	sample snippet for the .gitignore
	**/*.secure*
	**/*.secret*	
#----------------------------------------------------------------------------
#	following script sets only few environment variables
#	API_KEY
#
FILE=nuget-set-api-key.secure.sh

If exist %FILE% (
call %FILE%
)

echo API_KEY = %API_KEY%

#=============================================================================

%NUGET% ^
	push ^
	artifacts\*.nupkg
	
@IF %ERRORLEVEL% NEQ 0 PAUSE	
