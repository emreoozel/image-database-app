# Image Database App

A Windows Forms desktop application (C#, .NET Framework) for cataloguing images in a SQL Server database. Users can log in, add images with auto-detected metadata (file size, type, creation date), and browse, edit, or delete existing records in a searchable table view.

## Features

- **Login screen** – validates username/password against a `Kullanıcılar` (Users) table before granting access to the app.
- **Add image** – pick an image file (`.jpg`, `.jpeg`, `.png`, `.bmp`, `.webp`) through a file dialog; the app automatically detects and fills in:
  - file size (formatted as Byte / KB / MB)
  - file type (extension)
  - creation date
  - next available record ID
  
  The user only needs to enter the image name and owner before saving.
- **Browse & manage images** – a data grid lists every saved record. Clicking a column label selects that field for editing; the value can then be updated via a text box and saved back to the database.
- **Delete records** – remove a selected image entry from the database with a confirmation prompt.
- **Refresh** – reload the table to reflect the latest database state.

## Tech Stack

- **Language / UI:** C#, Windows Forms (.NET Framework 4.7.2)
- **Data access:** ADO.NET (`System.Data.SqlClient`)
- **Database:** Microsoft SQL Server (tested with SQL Server Express, Windows Integrated Security)

## Database

The app expects a SQL Server database (default name: `Resimler`) with at least these tables:

- `Kullanıcılar` — `Kullanıcı_Adı`, `Kullanıcı_Sifresi` (login credentials)
- `Resimler` — `Resim_ID`, `Resim_Adi`, `Resim_Sahibi`, `Resim_Boyutu`, `Resim_Türü`, `Resim_Tarihi` (image records)

## Getting Started

1. Clone the repository:
   ```
   git clone https://github.com/emreoozel/image-database-app.git
   ```
2. Open `Proje.slnx` in Visual Studio.
3. Create the `Resimler` database and the tables listed above in your local SQL Server instance.
4. Update the connection string in `App.config` (and in each form's code-behind) to point to your own SQL Server instance name.
5. Build and run the project (F5).
6. Username: admin, Password: 1234

## Notes

This project was built as a learning exercise to practice Windows Forms UI development, ADO.NET database access, and basic CRUD operations with SQL Server.

## Author

**Emre Özel**
[GitHub](https://github.com/emreoozel)
