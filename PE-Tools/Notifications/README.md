# Notification System

## Overview

The PE-Tools application includes a toast-style notification system that displays read-only messages in the bottom-right corner of the application window. Notifications are designed to provide non-intrusive feedback to users about operations and status updates.

## Features

- **Bottom-right positioning**: Notifications appear in the bottom-right corner of the main application window
- **Automatic stacking**: Up to 3 notifications can be displayed simultaneously, stacked vertically
- **Smooth animations**: Slide-in and fade-out transitions for a polished user experience
- **Configurable duration**: Default display time is 2 seconds, configurable via App Settings
- **Themed appearance**: Automatically styled using the application's theme
- **Thread-safe**: Can be called from any thread
- **Logging**: All notifications are logged via NLog for troubleshooting

## Usage

### Basic Usage

```csharp
using PE_Tools.Notifications;

// Show a notification with default duration (2 seconds)
NotificationManager.Show("Operation completed successfully");
```

### Custom Duration

```csharp
// Show a notification for 5 seconds
NotificationManager.Show("Please review the changes carefully", 5);
```

### Error Notifications

```csharp
// Show error notification with longer duration (4 seconds)
NotificationManager.Show("Failed to save configuration", 4);
```

## Configuration

The default notification duration can be configured in the **App Settings** tab:

1. Navigate to the **App Settings** tab
2. Scroll to the **Notifications** section
3. Set the **Default Display Duration** (1-60 seconds)
4. Click **Save All Settings**

The duration is stored in `App.config` as `notificationDurationSeconds`:

```xml
<add key="notificationDurationSeconds" value="2"/>
```

## Technical Details

### Architecture

The notification system consists of two main components:

1. **NotificationForm**: A borderless, rounded-corner form that displays individual notification messages
2. **NotificationManager**: A static manager that handles notification lifecycle, positioning, and stacking

### Initialization

The NotificationManager must be initialized with the parent form before showing notifications. This is done automatically in `Form1.cs`:

```csharp
private void Form1_Load(object sender, EventArgs e)
{
    NotificationManager.Initialize(this);
    // ... rest of load logic
}
```

### Stacking Behavior

- Maximum of 3 concurrent notifications
- New notifications appear at the bottom
- Older notifications smoothly move upward
- When the limit is reached, the oldest notification is automatically closed

### Animation Details

- **Fade-in**: 10 steps over 200ms
- **Slide-in**: From right edge, 10 steps over 200ms
- **Fade-out**: 10 steps over 200ms
- **Smooth repositioning**: When notifications stack or close

## Examples in the Codebase

### FileManager.cs

```csharp
public void SaveC1File()
{
    c1Config.Save(c1Path);
    Logger.Info("Saved C1 config to {0}", c1Path);
    NotificationManager.Show("C1 config saved successfully");
}
```

Exceptions propagate to the caller (`DatabaseSettingsView`), which shows a `MessageBox` for errors requiring acknowledgment.

### DatabaseSettingsView.cs

```csharp
try
{
    fileManager.UpdateC1File(c1DbName);
    fileManager.UpdateDocFile(docsDbName, c1DbName);
    Logger.Info("Applied database selection: c1={0}, doc={1}", c1DbName, docsDbName);
    NotificationManager.Show($"Database settings applied: C1={c1DbName}, Doc={docsDbName}");
}
catch (Exception ex)
{
    Logger.Error(ex, "Error applying database changes");
    NotificationManager.Show("Failed to apply database settings", 4);
}
```

### AppSettingsView.cs

```csharp
try
{
    using var connection = new SqlConnection(connectionString);
    await connection.OpenAsync();
    NotificationManager.Show("Database connection successful!");
    MessageBox.Show("Connection successful!", "Test Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
}
catch (Exception ex)
{
    NotificationManager.Show("Database connection failed", 4);
    MessageBox.Show($"Connection failed: {ex.Message}", "Test Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
```

## Best Practices

1. **Keep messages concise**: Notifications should be brief and to the point
2. **Use appropriate durations**:
   - Success messages: 2 seconds (default)
   - Warnings: 3-4 seconds
   - Errors: 4-5 seconds
3. **Combine with logging**: Always log important operations in addition to showing notifications
4. **Don't replace MessageBox for critical errors**: Use MessageBox for errors requiring user acknowledgment
5. **Avoid notification spam**: Don't show notifications for every minor operation

## Accessibility

- Notifications write to NLog when shown/hidden for audit trails
- Screen position is DPI-aware
- High-contrast theme colors ensure readability

## API Reference

### NotificationManager

#### `Initialize(Form parentForm)`
Initializes the notification manager with the parent form. Must be called before showing any notifications.

**Parameters:**
- `parentForm`: The main application form

**Example:**
```csharp
NotificationManager.Initialize(this);
```

#### `Show(string message, int? durationSeconds = null)`
Shows a notification toast in the bottom-right corner of the application window.

**Parameters:**
- `message`: The message to display (required)
- `durationSeconds`: Optional duration in seconds. If null, uses the default from settings.

**Example:**
```csharp
NotificationManager.Show("Operation completed");
NotificationManager.Show("Warning: Check configuration", 4);
```

#### `CloseAll()`
Closes all active notifications immediately.

**Example:**
```csharp
NotificationManager.CloseAll();
```

### SettingsManager

#### `GetNotificationDuration()`
Gets the default notification duration in seconds from App.config.

**Returns:** `int` - Duration in seconds (default: 2)

#### `SaveNotificationDuration(int durationSeconds)`
Saves the notification duration to App.config.

**Parameters:**
- `durationSeconds`: Duration in seconds (1-60)

**Throws:** `ArgumentException` if duration is less than 1 second
