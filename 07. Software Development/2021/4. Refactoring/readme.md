# XML Documentation

## 1. Install
Sandcastle Help File Builder project
https://github.com/EWSoftware/SHFB

Download Help File Builder and Tools v2020.3.6.0
https://github.com/EWSoftware/SHFB/releases/download/v2020.3.6.0/SHFBInstaller_v2020.3.6.0.zip

Microsoft HTML Help
https://docs.microsoft.com/en-us/previous-versions/windows/desktop/htmlhelp/microsoft-html-help-downloads

Download Microsoft HTML Help Workshop 
https://www.helpandmanual.com/download/htmlhelp.exe

## 2. Create
Command Prompt
```
"C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\MSBuild\Current\Bin\MSBuild.exe" /p:CleanIntermediates=True /p:Configuration=Debug "Refactoring.shfbproj"
```