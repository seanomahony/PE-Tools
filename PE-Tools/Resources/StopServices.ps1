Stop-Process -Name OfficeEvolveDesktop -ErrorAction SilentlyContinue

Stop-Process -Name CMSService -Force -ErrorAction SilentlyContinue

Stop-Process -Name ClickOneLegalService -Force -ErrorAction SilentlyContinue

Stop-Process -Name CMSDocumentContentIndexingService -Force -ErrorAction SilentlyContinue
