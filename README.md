## Vidly - Tutorial for Video Rental Application

### Your First ASP.NET MVC App
 ##### Creating a new ASP.NET MVC 5 project
  * https://www.twilio.com/docs/guides/creating-aspnet-mvc-webhook-project#creating-the-project
 ##### MVC Folder Structure
  * http://www.tutorialsteacher.com/mvc/mvc-folder-structure
  * http://www.c-sharpcorner.com/uploadfile/0c1bb2/understanding-asp-net-mvc-folder-structure/
 ##### MVC Routing
  * https://www.exceptionnotfound.net/attribute-routing-vs-convention-routing/
  * https://docs.microsoft.com/en-us/aspnet/core/fundamentals/routing
 ##### Controller
  * https://www.tutorialspoint.com/asp.net_mvc/asp.net_mvc_controllers.htm
 ##### Model or a Data Model
  * https://www.tutorialspoint.com/asp.net_mvc/asp.net_mvc_data_model.htm
 ##### View
  * https://www.tutorialspoint.com/asp.net_mvc/asp.net_mvc_views.htm 
 ##### NuGet Package Manager
  * https://www.tutorialspoint.com/asp.net_mvc/asp.net_mvc_nuget_package_management.htm

### MVC in ACtion
 ##### Create Model
  * On the Model folder right click select Add, Class and Name = Movie
 ##### Create Controller
  * On the Controller folder right click select Add, Controller
  * On the list of Scaffold select MVC 5 controller - Empty and Controller Name = MoviesController(plural of the model + append controller)
 ##### Create View 
  * On /Views/Movies folder right click, Add View and View name = Random
  * Use a layout page = ~/Views/Shared/_Layout.cshtml and click Add

### Adding a Theme
 ##### Adding bootstrap
  * Go to http://bootswatch.com then on the Themes menu select lumen.
   * On the lumen menu select bootstrap.css
.	* Or simple go directly to http://bootswatch.com/lumen/bootstrap.css
   * Select all and copy the css content
   * On the Solution Explorer right click Content folder select add then style sheet bootstrap-lumen.css and paste the copied css code.
   * On the App_Start folder open up BundleConfig.cs. = this is where the bundles installed e.g. css, jquery, modernizer etc..
     * Inside the created style bundlde for /content/css change boostrap.css to bootstrap-lumen.css and save
   * Compile and run or press F5
