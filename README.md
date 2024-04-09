---

# Console Plugin Manager

The Console Plugin Manager is a basic application that demonstrates the concept of plugin architecture in a console-based environment. This README provides an overview of the project, installation instructions, and usage guidelines.

## Overview

The Console Plugin Manager allows users to load and execute custom plugins dynamically. It provides a simple demonstration of how plugins can be integrated into an application to extend its functionality.

### Features

- Dynamic loading and execution of plugins
- Basic plugin management (loading and executing)

## Installation

Follow these steps to install and run the Console Plugin Manager:

1. Clone the repository to your local machine:

   ```bash
   git clone https://github.com/timothy-kumah/Plugin-Architecture-c-.git
   ```

2. Navigate to the project directory:

   ```bash
   cd Plugin-Architecture-c-
   ```

3. Build the project:

   ```bash
   dotnet build
   ```

4. Run the application:

   ```bash
   dotnet run
   ```

## Usage

Once the application is running, follow these steps to load and execute plugins:

1. Place your plugin DLL files in the `Plugins` directory within the project folder.

2. Start the Console Plugin Manager application.

3. The application will automatically load and execute any plugins found in the `Plugins` directory.

4. You will see the output generated by each plugin in the console.

## Contributing

Contributions to the Console Plugin Manager are welcome! If you would like to contribute, please follow these guidelines:

- Fork the repository and create a new branch for your feature or bug fix.
- Make your changes and ensure that the code remains simple and easy to understand.
- Submit a pull request with a clear description of your changes and their purpose.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---
