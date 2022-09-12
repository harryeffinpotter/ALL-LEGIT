@echo off
cd "%~dp0"
for /f "USEBACKQ tokens=* Delims=" %%G IN (`file\bin\file.exe "%~1"`) DO echo %%G