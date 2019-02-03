This has a sample Web API with one to many relationship mapping.
Steps:

1. Open Visual Studio -> New Project -> Visual C# -> Web -> .NET Core -> ASP.NET Core Web Application -> API
2. Add folder Model : This is where we put most of our DB Mappings related classes and Folders
3. Add a new Class in the Model folder. This class will be converted into a DB table hence some annoations done to replicate schema in code e.g: Required, Key etc. The alternative is Fluent APIs (More on this later).
