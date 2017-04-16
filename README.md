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

### ASP.NET MVC Fundamentals
 ##### Action Results
  * https://www.exceptionnotfound.net/asp-net-mvc-demystified-actionresults/
  * http://www.c-sharpcorner.com/article/different-types-of-action-results-in-asp-net-mvc/
 ##### Action Parameters
  * Parameter Sources or Parameter Values
    * /movies/edit/1 is an embeded url
    * /movies/edit?id=1 is a query string
    * form data: id=1 is a data posted using a form
  * http://www.c-sharpcorner.com/UploadFile/1e050f/pass-parameter-or-query-string-in-action-method-in-Asp-Net-m/
  * http://tutlane.com/tutorial/aspnet-mvc/how-to-use-querystring-parameters-in-asp-net-mvc-to-retrieve-or-send-data
  * http://www.binaryintellect.net/articles/8e64d05b-ab2e-45f6-b7f5-b8a90168915e.aspx
 ##### Convention-based Routing
  * Created a custom route
  * http://www.dotnetfunda.com/articles/show/3029/different-types-of-routing-in-aspnet-mvc
 ##### Attribute Routing
  * http://www.dotnettricks.com/learn/mvc/understanding-attribute-routing-in-aspnet-mvc
  * https://docs.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2
  * with custom route contraints
    * http://www.dotnet-stuff.com/tutorials/aspnet-mvc/understanding-url-rewriting-and-url-attribute-routing-in-asp-net-mvc-mvc5-with-examples 
 ##### Passing data to a view
  * Use model typed class to pass data to a view. Don't use ViewBag or ViewData Dictionary
  * https://chsakell.com/2013/05/02/4-basic-ways-to-pass-data-from-controller-to-view-in-asp-net-mvc/
  * https://www.codeproject.com/Articles/576514/AplusBeginner-splusTutorialplusonplusVariousplus
 ##### View Models
   * View a ViewModel. A model which has a relationship with another model.
     * Created movie and customer model.
     * Changed the directive to ViewModel
   * View a ViewModel with List of object using razor syntax
     * Used foreach to list the customers who rented the movie.
     * Used if then else statement to count the customers and message if there hasn't been rented to the movie.
     * Added popular to the classname of h2 tag if the customer is greater than one movie was rented.
 #### Creating a Partial View
   * Created a partial view for the navigation bar instead in the layout view.
     * Create a partial view named "Navbar".
     * Cut the navagation bar html code and paste it into partial view. 
     * Render the _Navbar view into the _Layout view (@Html.Partial()).
       * Invoke the _Navbar view as first parameter and Model Data as second parameter.
       * Include the the directive of the Model or ViewModel in the Layout view.
   * Note that inside the _Navbar view there is a partial view rendered called _LoginPartial.
     * It is possible to render a partial view inside a partial view.
   * http://www.tutorialsteacher.com/mvc/partial-view-in-asp.net-mvc
   * https://www.codeproject.com/Articles/698246/ASP-NET-MVC-Special-Views-Partial-View-and-Layout
   * http://www.matthewrenze.com/articles/clean-architecture-in-asp-net-mvc-5/
 #### Exercise 1 solution - List the customers with their details and the movies.
   * Create a model named Movie.
   * Check routes for the Movie(default at this time).
   * Create controller named MoviesController.
     * Create GetMovies method using IEnumerable.
	 * Invoke it in the Index ActionResult.
	 * Breakpoint the return and check the movies variable values.
   * Create an Empty View for the Movies.
     * Put the directives, use IEnumerable
	 * Create a table for the listing of the movies.
	   * Iterate each movie properties(Id, Title, ...) with ActionLink for the Details.
	   * Create additional validation messages.
	   * Add HtmlAttributes to make the UI better.
	   * Click one customer in the list to check the routes for the Details.
   * Add ActionResult named Details with Id parameter on the MoviesController.
     * Return the specific movie by the Id.
   * Create an Empty View for the Details of this movie model.
### Working With Data
 #### Code-first Migration
   * Click Tools menu select Nuget Package Manager and select Package Manager Console
   * To enable migrations on the console
     * Type enable-migrations
     * A folder called Migrations will be generated with a file Configuration.cs
   * To add migration
     * Type add-migration [migration-name]. e.g.(InitialModel)
	   * A new cs file was generated named [15 numbers + [migration-name].cs] in the Migration folder.
	     * In this file there is a CreateTable code for controling user authentication and authorization.
	   * Also a new cs file was generated called IdentityModel.cs in the Models folder.
	     * ApplicationUser and ApplicatonDBContext class was coded here.
		 * The ApplicationDBContext is the gateway to our database.
		   * Inside of this class write the DbSet for Customer Model to represent the Customer table in the database.
		   * add-migration IntialModel -force
		     * A LINQ Method called CreateTable was generated in the [migration-number]_[migration-name].
		   * Render this migration and generate the database.
		     * update-database
			 * Click Show All Files icon from the solution explorer.
			 * In the App_Data a new mdf file with version was generated.
 #### Changing/Adding a Model for new Migration
   * Changing the Customer Model
     * add-migration AddIsSubscribedToCustomer .i.e. AddIsSubscribedToCustomer = migration-name
     * update-database - no need to put the DBSet.
   * Adding a new Model - MembershipType
     * Add a Domain Model called MembershipType.
	 * Go to Customer Model and write a navigation property for MembershipType Model
	   * Also write a property for its foreign key.
     * add-migration AddMembershipType
	 * update-database
	 * Note: No need to write the DBset property in the IdentityModel.cs when creating child model/table.
   * Seeding the database
     * add-migration PopulateMembershipTypes
	 * update-database