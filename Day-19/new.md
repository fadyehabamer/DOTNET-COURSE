# Hospital Reservation System

## Overview

The Hospital Reservation System is a web application built using the .NET MVC framework and Entity Framework for backend functionality, with Bootstrap for the frontend design. This system allows users to view general information about the hospital, learn about the hospital, browse through a list of doctors, view details of individual doctors, make appointments, and manage doctor information.

## Features

- **Home Page**: Displays general information about the hospital.
- **About Page**: Provides information about the hospital.
- **Doctors Page**: Retrieves and displays a list of doctors from the database.
- **Doctor Details Page**: Shows detailed information about a specific doctor.
- **Make Appointment Page**: Allows users to make an appointment with a doctor.
- **Appointment Page**: Lists all the appointments made.
- **Edit Doctor Page**: Allows editing the details of a specific doctor.
- **Delete Doctor**: Allows deleting a doctor from the database.

## Technologies Used

- **Backend**: .NET MVC, Entity Framework
- **Frontend**: Bootstrap
- **Database**: SQL Server (used via Entity Framework)

## Project Structure

### Models

The models represent the data structure of the application. The primary models include:

- **Doctor**: Represents the doctors in the hospital.
- **Appointment**: Represents the appointments made by patients.

### Controllers

Controllers handle the user input and responses. The primary controllers include:

- **HomeController**: Handles requests for the Home and About pages.
- **DoctorsController**: Manages the display of doctors, doctor details, appointment creation, and doctor management (edit and delete).
- **AppointmentController**: Manages the listing of appointments.

### Views

The views render the user interface. The primary views include:

- **Home/Index**: Displays general information about the hospital.
- **Home/About**: Displays information about the hospital.
- **Doctors/Index**: Displays a list of doctors retrieved from the database.
- **Doctors/Details**: Shows details for a specific doctor.
- **Doctors/MakeAppointment**: Provides a form for making an appointment with a doctor.
- **Doctors/EditDoctor**: Provides a form for editing a doctor's details.
- **Appointment/Index**: Lists all appointments.

## Routes

The application uses the following routes:

- **Home**
  - `/`: Displays the home page with general information about the hospital.
- **About**
  - `/home/about`: Displays the about page with information about the hospital.
- **Doctors**
  - `/doctors`: Displays a list of doctors.
  - `/doctors/details/{id}`: Displays details for a specific doctor identified by `{id}`.
  - `/doctors/makeappointment/{id}`: Displays a form to make an appointment with a specific doctor identified by `{id}`.
  - `/doctors/editdoctor/{id}`: Displays a form to edit a specific doctor identified by `{id}`.
  - `/doctors/deletedoctor/{id}`: Deletes a specific doctor identified by `{id}`.
- **Appointments**
  - `/appointment`: Displays a list of all appointments.

## Setup Instructions

1. **Clone the repository**:
   ```sh
   git clone <repository-url>
   ```

2. **Restore packages**:
   ```sh
   dotnet restore
   ```

3. **Update database**:
   ```sh
   dotnet ef database update
   ```

4. **Run the application**:
   ```sh
   dotnet run
   ```

## Screenshots

### Home Page
![Home Page](screenshots/home.png)

### About Page
![About Page](screenshots/about.png)

### Doctors List
![Doctors List](screenshots/doctors.png)

### Doctor Details
![Doctor Details](screenshots/doctor-details.png)

### Make Appointment
![Make Appointment](screenshots/make-appointment.png)

### Edit Doctor
![Edit Doctor](screenshots/edit-doctor.png)

### Appointments List
![Appointments List](screenshots/appointments.png)

## Contributing

1. Fork the repository.
2. Create a feature branch.
3. Commit your changes.
4. Push to the branch.
5. Create a new Pull Request.

## License

This project is licensed under the MIT License. See the LICENSE file for details.

---

By following this structure, you will have a comprehensive and organized Markdown documentation for your Hospital Reservation System project.