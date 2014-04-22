@echo off
if %1.==. goto :no1
if %2.==. goto :no2
if not %3.==. goto :no3

Call SPIway.py %1 %2
goto :end

:no1
echo No Com port specified
goto :end
:no2
echo No Methode specified
goto :end
:no3
Call SPIway.py %1 %2 %3
goto :end
:end