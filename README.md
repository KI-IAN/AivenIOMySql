Markdown

# Aiven MySQL Connection Example using .Net Core Web App

This repository demonstrates how to connect to a MySQL database hosted on [Aiven.io](https://aiven.io/). The connection requires a `ca.pem` file for SSL verification, which is stored in the `AivenIOMySql/Secrets` folder.

## Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) installed on your machine.
- Access to an Aiven MySQL instance.
- MySQL client or any database management tool for testing connections.

## Setup

1. **Clone the Repository**

   ```bash
   git clone git clone https://github.com/KI-IAN/AivenIOMySql.git
   cd AivenIOMySql
   
### Add Your Aiven MySQL Credentials

Update the appsettings.json file with your Aiven MySQL connection details:

string connectionString = "Server=Aiven_Cloud_Host_Name;Port=17302;Database=YOUR_DB;Uid=USER_id;Pwd=PASSWORD;SslMode=VerifyCA;SslCa=Secrets/ca.pem;";

Replace Aiven_Cloud_Host_Name, YOUR_DB, USER_id, and PASSWORD with your actual Aiven MySQL credentials.

### Build and Run the Application

```bash
dotnet build
dotnet run

The application will attempt to connect to the Aiven MySQL database using the provided credentials and SSL certificate.

### Connection String Explanation
The connection string used to connect to the Aiven MySQL database is structured as follows:

- Server: The hostname of your Aiven MySQL instance. Replace Aiven_Cloud_Host_Name with the actual host name provided by Aiven.
- Port: The port number for the MySQL service. Typically, Aiven provides a specific port, such as 17302.
- Database: The name of the database you want to connect to. Replace YOUR_DB with your database name.
- Uid: The user ID for authentication. Replace USER_id with your actual user ID.
- Pwd: The password for the specified user. Replace PASSWORD with your actual password.
- SslMode: Specifies the SSL mode. VerifyCA ensures that the server's certificate is verified against the provided CA certificate.
- SslCa: The path to the CA certificate file used for SSL verification. In this example, it is set to Secrets/ca.pem, which should be the relative path to your ca.pem file.

### Connecting to Aiven MySQL
The connection to Aiven MySQL is secured using SSL. The ca.pem file is used to verify the server's certificate. Ensure that the ca.pem file is correctly placed in the AivenIOMySql/Secrets directory.


### Troubleshooting
SSL Errors: Ensure the ca.pem file is correctly placed and the path in the connection string is accurate.
Connection Issues: Double-check your Aiven MySQL credentials and network settings.


### Notes:
- Make sure to replace placeholders like `Aiven_Cloud_Host_Name`, `YOUR_DB`, `USER_id`, and `PASSWORD` with actual values specific to your Aiven MySQL setup.
- Ensure the `ca.pem` file is correctly placed in the `Secrets` directory as specified in the connection string.
