# Mailroom Management System

This application provides a comprehensive mailroom management system for handling package delivery, pickup, and record-keeping processes. It includes a GUI interface, backend database integration, and email notifications.

## Features

1. **Login System**:
   - Authenticates staff users using stored procedures in a MySQL database.

2. **Package Management**:
   - **Delivery Process**: Log package delivery information and notify residents via email.
   - **Pickup Process**: Record package pickup confirmations and update pending packages.
   - **Record Retrieval**: Retrieve and display package delivery/pickup history.

3. **Database Integration**:
   - Stored procedures handle operations such as login validation, resident lookups, and package record updates.

4. **Email Notifications**:
   - Sends package notifications to residents with HTML email templates using the SMTP protocol.

## Project Structure

### Main Components

1. **`BusinessLogic`**: The main class that orchestrates the application's workflows, interacting with the GUI and database layers.
2. **`GuiTier`**: Handles user interaction, including login, dashboard navigation, and displaying package/resident information.
3. **`DataTier`**: Manages database connectivity and executes stored procedures for CRUD operations.
4. **`EmailSender`**: Sends email notifications to residents about package delivery status.

### Key Functionalities

#### Login System
- Uses the `LoginCount` stored procedure to validate user credentials.

#### Package Delivery Process
- Verifies the resident's existence in the database.
- Logs package information in the `Pending` and `Records` tables.
- Sends a package notification email to the resident.

#### Package Pickup Process
- Removes package information from the `Pending` table after confirmation.
- Updates the package status in the database.

#### Package Record Retrieval
- Retrieves package history based on the resident's name and unit number.

### Stored Procedures
The system relies on the following MySQL stored procedures:
- `LoginCount`: Validates user credentials.
- `CheckResident`: Checks if a resident exists.
- `AddPending`: Adds package information to the `Pending` area.
- `AddRecords`: Logs package information in the `Records` table.
- `RemovePending`: Removes package records from the `Pending` table.
- `CheckRecords`: Retrieves package records for a resident.

## Requirements

### Tools and Libraries
- **Programming Language**: C#
- **Database**: MySQL
- **Email Protocol**: SMTP
- **Libraries**:
  - `System.Data`
  - `MySql.Data.MySqlClient`
  - `System.Net.Mail`

### Prerequisites
- MySQL server with the necessary database and stored procedures.
- SMTP server for email notifications.

## Setup and Usage

1. **Database Configuration**:
   - Update the connection string (`connStr`) in the `DataTier` class to match your database credentials.

2. **SMTP Configuration**:
   - Update the sender email, password, and SMTP server details in the `EmailSender` class.

3. **Run the Application**:
   - Compile and execute the `BusinessLogic` class.

4. **Navigation**:
   - Log in using valid staff credentials.
   - Choose options from the dashboard to manage package deliveries, pickups, and record retrievals.

## Security Considerations

- Avoid hardcoding sensitive information like database credentials and email passwords. Use environment variables or a secure vault for these details.
- Ensure the database is properly secured with limited access permissions.

## Potential Improvements

- Implement role-based access control for different staff privileges.
- Add logging mechanisms for tracking user activities.
- Introduce a web-based frontend for enhanced user accessibility.
- Add unit tests for better code reliability.

## Disclaimer

This system is a prototype designed for demonstration purposes. It may require further enhancements for production use.
