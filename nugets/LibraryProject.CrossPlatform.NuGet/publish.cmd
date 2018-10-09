@echo off

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
set FILE=test.txt
If NOT exist %FILE% (
call %FILE%
)
::=============================================================================

.nuget\nuget ^
	push ^
	artifacts\*.nupkg
	
@IF %ERRORLEVEL% NEQ 0 PAUSE	
