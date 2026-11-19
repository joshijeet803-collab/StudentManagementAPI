# Student Management REST API (Experiment 10)

## Requirements
- .NET 8 SDK
- Visual Studio 2022 with ASP.NET and web development workload, or terminal

## Run
1. Extract the ZIP.
2. Open `StudentManagementAPI.csproj` in Visual Studio, or open this folder.
3. Run the project, or use `dotnet run` from this folder.
4. Open the root URL shown in the console (configured as http://localhost:5000).

## Endpoints
- GET `api/students` - list students
- GET `api/students/{id}` - student by ID
- POST `api/students` - add student
- PUT `api/students/{id}` - update student
- DELETE `api/students/{id}` - delete student

POST/PUT JSON example:
```json
{ "name": "Aarav Patel", "branch": "CE", "cgpa": 8.7, "email": "aarav@gmail.com" }
```
Use Postman or another HTTP client to test CRUD endpoints. Data is in memory and resets when the app restarts.
