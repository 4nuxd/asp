```markdown
# ASP.NET Core Login Application

A simple ASP.NET Core MVC application featuring a login page with basic authentication. The app is designed to be hosted on Heroku.

## Features

- MVC architecture for clean separation of concerns.
- Basic login functionality with server-side validation.
- Clean and responsive login UI.
- Hosted on Heroku with proper deployment configurations.

---

## Prerequisites

Ensure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Heroku CLI](https://devcenter.heroku.com/articles/heroku-cli)
- Git

---

## Project Structure

```plaintext
LoginApp/
├── Controllers/
│   └── AuthController.cs        # Handles login logic
├── Models/
│   └── User.cs                  # User model
├── Views/
│   ├── Auth/
│   │   ├── Login.cshtml         # Login page UI
│   │   └── Welcome.cshtml       # Welcome page after login
├── wwwroot/                     # Static files (CSS/JS)
├── Program.cs                   # App startup configuration
├── Procfile                     # Heroku process file
└── appsettings.json             # App settings
```

---

## Getting Started

### 1. Clone the Repository
```bash
git clone <repository-url>
cd LoginApp
```

### 2. Run Locally
Restore dependencies and start the app locally:
```bash
dotnet restore
dotnet run
```
Visit **http://localhost:5000** to view the app.

---

## Deploying to Heroku

### 1. Publish the Application
Run the following command to publish the app:
```bash
dotnet publish -c Release -o publish
```

### 2. Set Up Heroku
Login to Heroku:
```bash
heroku login
```

Create a new Heroku app:
```bash
heroku create your-app-name
```

Set the .NET Core buildpack:
```bash
heroku buildpacks:set jincod/dotnetcore
```

### 3. Push to Heroku
Initialize Git (if not already initialized) and push the code:
```bash
git init
git add .
git commit -m "Initial commit"
git push heroku main
```

Open the app:
```bash
heroku open
```

---

## Environment Configuration

- **PORT**: Automatically set by Heroku.
- **Procfile**: Specifies how Heroku should run the app.

---

## Screenshots

### Login Page
![Login Page](https://via.placeholder.com/600x400?text=Login+Page)

### Welcome Page
![Welcome Page](https://via.placeholder.com/600x400?text=Welcome+Page)

---

## Technologies Used

- **ASP.NET Core MVC**: For building the web application.
- **Heroku**: For deployment and hosting.

---

## Future Enhancements

- Integrate with a database for dynamic user management.
- Implement password hashing and secure authentication.
- Add session management and logout functionality.

---

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---
