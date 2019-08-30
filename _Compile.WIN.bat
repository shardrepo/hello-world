@SET CURPATH=%~dp0
@SET CSCPATH=%windir%\Microsoft.NET\Framework\v4.0.30319\

@SET SDKPATH=%CURPATH%Ultima\
@SET SRVPATH=%CURPATH%Server\

@TITLE: UO Sunrise

::##########

@DEL "%CURPATH%Ultima.dll"

%CSCPATH%csc.exe /target:library /out:"%CURPATH%Ultima.dll" /recurse:"%SDKPATH%*.cs" /d:NEWTIMERS /d:NEWPARENT /nowarn:0618 /nologo /optimize /unsafe

::##########

::##########

@DEL "%CURPATH%Sunrise.exe"

%CSCPATH%csc.exe /win32icon:"%SRVPATH%runuo.ico" /r:"%CURPATH%Ultima.dll" /target:exe /out:"%CURPATH%Sunrise.exe" /recurse:"%SRVPATH%*.cs" /d:NEWTIMERS /d:NEWPARENT /nowarn:0618 /nologo /optimize /unsafe

::##########

@PAUSE
