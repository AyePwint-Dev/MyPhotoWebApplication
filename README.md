# MyPhotoWebApplication
# Image Gallery Application

This is a responsive **Image Gallery Application** built using **C# .NET** for the backend and **HTML, CSS, and JavaScript** for the frontend. The application provides a modern and intuitive gallery interface similar to Instagram, allowing users to upload, view, and manage images efficiently.

## Features

-   **Responsive Design**: Adapts to all screen sizes (desktop, tablet, mobile).
    
-   **Dynamic Grid Layout**: Uses CSS Grid to create a visually appealing image gallery.
    
-   **Image Upload**: Upload images and generate thumbnail previews.
    
-   **Hover Effects**: Interactive zoom effects on image hover.
    
-   **Database Integration**: Images and metadata stored in SQL Server.
    
-   **Scalable Backend**: Built using C# .NET 7.0 and Entity Framework Core.
    

## Prerequisites

To run this project, ensure the following are installed:

-   [.NET SDK](https://dotnet.microsoft.com/) (7.0 or higher)
    
-   [SQL Server](https://www.microsoft.com/en-us/sql-server/)
    
-   [Visual Studio Code](https://code.visualstudio.com/) or Visual Studio
    

## Getting Started

### 1. Clone the Repository

```
git clone https://github.com/your-username/image-gallery-app.git
cd image-gallery-app
```

### 2. Set Up the Database

1.  Ensure SQL Server is running.
    
2.  Update the connection string in `appsettings.json`:
    

```
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=ImageGalleryDb;Trusted_Connection=True;"
}
```

3.  Run the following commands to apply migrations and create the database:
    

```
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 3. Run the Application

Start the application using the .NET CLI:

```
dotnet run
```

Access the application in your browser at `http://localhost:5000`.

## File Structure

```
project-root/
|-- Controllers/
|   |-- GalleryController.cs
|-- Models/
|   |-- Image.cs
|-- Views/
|   |-- Gallery/
|       |-- Index.cshtml
|       |-- Upload.cshtml
|-- wwwroot/
|   |-- css/
|       |-- styles.css
|   |-- images/
|-- appsettings.json
|-- Program.cs
```

## Key Functionalities

### **Frontend**

-   **HTML/CSS**: Responsive layout using CSS Grid.
    
-   **JavaScript**: Enhances interactivity (e.g., image preview before upload).
    

### **Backend**

-   **C# .NET**: Handles image uploads, processing, and serving.
    
-   **Entity Framework Core**: Manages database interactions.