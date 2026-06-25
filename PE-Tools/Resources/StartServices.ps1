param([string]$folder)

Set-Location "$folder\integration\bin\Debug\Server\bin"

Start-Process CMSService.exe -Verb runAs

Start-Sleep -s 1

Set-Location "$folder\integration\bin\Debug"

Start-Process .\ClickOneLegalService.exe "Console NoScheduler" -Verb runAs

Start-Sleep -s 5

Start-Process "OfficeEvolveDesktop.exe"
