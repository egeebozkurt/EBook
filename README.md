# Project Overview

EBook is a web application that allows users to perform CRUD (Create, Read, Update, Delete) operations on books stored in a database. The application enables users to list books, add new books, update existing books, or delete books. These operations can be performed via Swagger UI or a customized HTML interface.

<br>

# Technologies Used
- **C#**  
- **.NET Core**  
- **Entity Framework Core**  
- **RESTful API**  
- **OpenAPI (Swagger)**  
- **SQL**  
- **HTML - CSS**
- **JavaScript**

<br>

# Architecture Overview

The application consists of four layers: Entities, Presentation, Repositories, and Services. These layers are integrated into the main project using a layered architecture. The interaction between the layers ensures the modularity and sustainability of the project.

## Entitites ###
The Entities layer is the layer that contains the application's data models. In this layer, there are classes corresponding to database tables and data transfer objects (DTOs). The application's data structures are defined and managed here.
![](/EBook/.thumbnails/L-Entities.png)

## Presentation
The Presentation layer is the layer that manages the user interface or API endpoints presented to the user. In this layer, Controllers, Views, and API endpoints are found. Requests from the user are processed here, and appropriate responses are generated.
![](/EBook/.thumbnails/L-Presentation.png)

## Repositories
The Repositories layer is the layer that manages interaction with the database. This layer contains CRUD operations and data access methods. By abstracting database access, it prevents business logic from being directly dependent on data access code.
![](/EBook/.thumbnails/L-Repositories.png)

## Services
The Services layer is the layer that manages business logic. This layer contains data processing, validation, and business rules. It provides the connection between the Repository layer and the Presentation layer, and manages business rules in a centralized manner.
![](/EBook/.thumbnails/L-Services.png)

# Swagger Page
![](/EBook/.thumbnails/EBookHTML-1.png)

<br>

# HTML Page
### Main Page
![](/EBook/.thumbnails/EBookHTML-2.png)
### List All
![](/EBook/.thumbnails/EBookHTML-3.png)
### List By ID
![](/EBook/.thumbnails/EBookHTML-4.png)
### Create
![](/EBook/.thumbnails/EBookHTML-5.png)
### Delete 
![](/EBook/.thumbnails/EBookHTML-6.png)
### Update
![](/EBook/.thumbnails/EBookHTML-7.png)

<br>

# How to Run the Application

To run the EBook application locally, follow the steps below:

### 1. **Clone the Repository**  
Clone the project repository to your local machine using Git:

    git clone https://github.com/egeebozkurt/EBook.git

### 2. **Install Dependencies**  
Make sure you have the required dependencies installed. This project uses **.NET Core** and **Entity Framework Core** for development. Run the following command to restore the required packages:

    dotnet restore

### 3. **Set Up the Database**  

    dotnet ef migrations add InitialCreate
    dotnet ef database update

### 4. **Run the Application**  
After setting up the database, you can run the application using the following command:

    dotnet run
    

### 5. **Access the Application**  
Open a web browser and navigate to:

   - **API**: `http://localhost:5027/swagger/index.html` (for Swagger UI)
   - **Web Interface**: `http://localhost:5027/index.html` (for the customized HTML interface)

### 6. **Testing CRUD Operations**  
You can now use the Swagger UI to test the CRUD operations for the books (Create, Read, Update, Delete).






