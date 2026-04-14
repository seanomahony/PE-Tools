# PE-Tools

PE-Tools is a Windows Forms application designed to manage database configurations for PE projects. It allows users to select project folders, view and modify database connection strings in configuration files, and execute PowerShell scripts for building and running PE services.

## Features

- **Database Configuration Management**: Select and update database connections for C1 and Document databases
- **Project Folder Selection**: Choose from configured project directories
- **Configuration File Viewing**: Display formatted XML configuration files with highlighted changes
- **PowerShell Integration**: Execute build and run scripts for PE components
- **Multi-View Interface**: Switch between database settings and PowerShell commands

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/seanomahony/PE-Tools.git
   cd PE-Tools
   ```

2. Open the solution in Visual Studio:
   ```
   PE-Tools.sln
   ```

3. Restore NuGet packages and build the solution.

4. Run the application as Administrator (required for PowerShell functionality).

## Configuration

### App.config Settings

Edit `PE-Tools\App.config` to configure:

- **folders**: Comma-separated list of project folder paths
  ```xml
  <add key="folders" value="c:\dev\onprem,c:\test\repo\onprem,c:\test\december\onprem"/>
  ```

- **databaseConnectionString**: SQL Server connection string for database discovery
  ```xml
  <add key="databaseConnectionString" value="server=localhost;Integrated Security=True;Pooling=True;"/>
  ```

- **c1ConfigFilename**: Relative path to C1 database configuration file
  ```xml
  <add key="c1ConfigFilename" value="\integration\bin\Debug\Config\Database.config"/>
  ```

- **docConfigFilename**: Relative path to Document database configuration file
  ```xml
  <add key="docConfigFilename" value="\integration\bin\Debug\Server\bin\CMSService.exe.config"/>
  ```

## Usage

### Database Settings

1. Select a project folder from the dropdown
2. Choose C1 and Document databases from the respective dropdowns
3. Click "Apply" to update the configuration files
4. View the updated XML by clicking the respective view buttons
5. Click "Save" to persist changes to disk

### PowerShell Commands

1. Select a project folder
2. Use the various build and run buttons to execute PowerShell scripts
3. View command output in the results textbox

## Project Structure

- `PE-Tools/`: Main application
  - `Views/`: User controls for different functionalities
  - `Models/`: Data models
  - `FileManager.cs`: Handles XML configuration file operations
  - `Database.cs`: Manages database discovery and connections

## Development

### Building

```bash
dotnet build PE-Tools.sln
```

### Running Tests

Currently no automated tests are implemented. Manual testing is required.

### Code Style

- Follow C# coding conventions
- Use meaningful variable and method names
- Add XML documentation comments for public APIs
- Handle exceptions appropriately

## Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Test thoroughly
5. Submit a pull request

## License

This project is proprietary software. See LICENSE file for details.

## Troubleshooting

### Common Issues

- **"Configuration file not found"**: Ensure the selected project folder contains the expected configuration files at the paths specified in App.config
- **"Database connection failed"**: Verify SQL Server is running and the connection string in App.config is correct
- **PowerShell execution errors**: Run the application as Administrator and ensure execution policies allow script running
- **"Access denied"**: Ensure the application has write permissions to the configuration files
