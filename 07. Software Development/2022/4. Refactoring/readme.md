# XML Documentation

## Download and Install

1. [Microsoft HTML Help Workshop 1.3](https://www.helpandmanual.com/download/htmlhelp.exe)

2. [Sandcastle Help File Builder and Tools v2020.3.6.0](https://github.com/EWSoftware/SHFB/releases/download/v2020.3.6.0/SHFBInstaller_v2020.3.6.0.zip)

## Create Help
Start Command Prompt as Administrator and execute following command:
```
"C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\MSBuild\Current\Bin\MSBuild.exe" /p:CleanIntermediates=True /p:Configuration=Debug "Refactoring.shfbproj"
```