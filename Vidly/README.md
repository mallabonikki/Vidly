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
   * Overriding Conventions from model to database
	 * use or include DataAnnotations namespace.
	 * Add DataAnnotation or Attribute in the Customers Name property .i.e [StringLength(255)].
	 * add-migration ApplyAnnotationsToCustomerName
	 * update-database
   * Quering Objects
	 * Inside the CustomersController.cs create the following:
	   * Create a private field with a type of ApplicationDBContext and named it _context.
	   * Create a constructor - a method with the same name of the class(type ctor).
		 * Initialize the _context with it.
		 * Also dispose it - override dispose method(type override dispose).
	   * Initialize the customer variable from _context.customer property and use ToList() for iteration.
	   * In the Details ActionResult change the GetCustomer() to _context.Customers property to get the data from the database.
		 * note: no parenthesis because it's a property not a method anymore.
	   * Remove the GetCustomer() method.
	   * Populate a data/record in the customers table manually because it's just a dummy data.
		 * dummy data or arbitrary records will not be deploy.
   * Eager Loading to the view(Customers => Index)
	 * Add table headings(th)
	 * Add table data(td)
	 * A null exception will occur, to solve we need eager loading.
	   * Add A directive System.Data.Entity
	   * In the Index Action Result, modify the customer variable and put "Include method" with parameter of MembershipType.
   * Exercise 1 Solution - Add a new property in a domain model called Name.
	 * Add Name property to MembershipType Domain Model.
	   * add-migrgation <AddNameToMembershipType>
	 * Upadate the database.
	   * update-database
	 * Create another migration to update existing records to the database.
	   * add-migration UpdateMembershipTypeToAddDataToName
	   * write sql statement into this new migration.
		 * use update sql statement in the migration.
   * Exercise 2 Solution - Add Membership Type and Birthdate in the customer's Detail View
	 * In the Customer's Domain Model add Birthdate property with a type of DateTime appended with question mark to accect nullable value.
	 * add-migration AddBirthdateToCustomer
	 * update-database
	 * In the CustomersController Details ActionResult, modify the customer variable and use Include method with appended SingleOrDefault Method.
	 * In the Customer's Details View, create <li> into <ul> and inside the <li> put the customer's model value of MembeshipType Name and Customer Birthdate.
	   * Addionally check Birthdate null value in the view using If statement.
	 * In the Customers' table populate Birthdate data manually.
   * Exercise 3 Solution - Display Movies and its details
	 * Create GenreType Domain Model(Child/Type) with DataAnnotations if required.
	 * Add the additional properties in the Movie Domain Model with DataAnnotations and ComponentModel
	   * include the Navigation Property and Foreign Key of the GenreType Model for reference.
	   * add-migration and update-database
	 * Populate the GenreTypes table using migration.
	   * add-migration <string name>
	   * write insert into sql statement inside this migration into the Up method.
	   * update-database
	 * Modify MoviesController and its Views.
	   * In the MoviesController, create variable movie and use Include and SingleOrDefault Methods.
	   * In the Movies Views use HTML helpers for the LabelFor and DisplayFor to effect the DataAnnotions in the Domain Model.
	 * Populate the Movies table manually.
### 4 - Building Forms
#### The Markup
* Create form and objects in the customers View.
  * Create ActionResult New() in the CustomersController.
  * Add new View and name it New.
	* put the directives on top of it.
	* Create a form here and render it using @html.beginform helper.
	  * Create a <div class="form-group"> for all textboxes and labels
	  * For checkbox, go to getbootstrap.com click CSS, Forms and find the checkbox div and copy.
		* change the html tag to @html helper.
#### Label the textbox
* Use @html helper or html tag with attributes.
#### Drop-down Lists
* In the IdentityModel, create DBset Membershiptype
* In the CustomersController, create a variable for membershipTypes to pass it to the View.
* In the ViewModel folder create NewCustomerViewModel - 
  * To encapsulates all the data required in the Views which include Customers and MembershipTypes Relationship for editing and deleting record/data.
  * Create a property with a type of IEnumarable<MembeshipType> for the MembeshipTypes(plural, collection) property to make iteration.
  * Create a property with a type of Customer for Customer property. Re-use from the Domain Model 
* In the New View 
  * Change the directive to ViewModel,
  * Add a drop-down object using @html helper and use MembershpTypeId to reference the Name property for listing.
* In the Customer Model add DataAnnotaion for Display Name of MembershipTypeId property.
* use @class="form-control" to have hover of the objects in your form.
* variable names should be small letter at first word and big letter on the second word.
#### Model Binding
* Create ActionResult Create with paramenter type of NewCustomerViewModel and variable name is viewModel
  * In New View add a submit button and name it Save.
  * put breakpoint in the return View() line
  * Fill up the New View Form and click Save
  * Go to the browser, inspect click Network Tab, click the Create request and select Hearder Tab
	* Look at the Form Data properties and values.
  * In ActionResult Create parameter change the viewModel to customer variable and type.
	* No need to use the viewModel here as we only need to populate the Customers not the MembeshipTypes.
#### Saving Data
* In the ActionResult Create(), 
  * use dbcontext and Add method to save it in the memory, 
  * use SaveChanges Method to save in the database,
  * RedirectToAction to Customers Index View.
#### Edit Form
* In the Customers-Index-View change the ActionLink_actionName parameter from Details to Edit
* In the CustomersController make ActionResult Edit()
  * Initialize customer using Linq and dbcontext
  * Initialize viewModel using the reference ViewModel
  * Change ViewModel and View-name for naming convention to standards
* In the Customers-Index-Page click the customer's name link
  * The CustomerForm-View will render the customer's properties/details.
#### Updating Data
* In the CustomersController
  * Change the ActionResult Create() to Save()
  * Create a if/else statement to check if the customer is 0 or doesn't exist.
	* If exist use Add method to add it first in the memory.
	* Else update it by mapping dbcontext properties and customer properties.
  * Lastly, create a HiddenFor helper in the CustomerForm-View to get the customer id.
#### Exercise 1 Solution - Build form and CRUD for Movies and GenreTypes
##### Createing ActionResult New(), ActionResult Edit(int id) and MovieForm View
* Create MovieFormViewModel
* Add Dbset for GenreTypes in the IdentityModel
* In the MoviesController 
  * Add ActionResult New() no parameter as no need to retrieve specific record
	* Create ViewModel variable and inside of this put all the model with inialiazation from the database
	* return View(ViewName, Object model)
  * Add ActionResult Edit(int id), with parameter as we need the specific movie to edit
	* Create ViewModel variable and inside of this put all the model with inialiazation from the database
	* return View(ViewName, Object model)
* Create a View and name it MovieForm
  * use Html.Beginform
	* Create the textboxes and other objects
	* Create submit button.
##### Adding and Updating Movie Record
* In the MoviesController
  * This time create HttpPost-ActionResult Save() with the parameter of the object model
  * Check the Id if 0 to Add else records exist and should be ready for Update.
  * SaveChanges to the database
* In the MovieForm-View
  * In Html helper BeginForm ActionName parameter put "Save"
  * Add Html HiddenFor for the movie.id using Linq.
  * Note: Check you Request Post Method in the browser.
* In the Movies-Index-View write ActionLink with html btn btn-primary attribute to have get request for new movie.
### 5 - Implementing Validation
#### Adding Validation
* In CustomersController ActionResult-Save Post-Method use ModelState for validation
  * Inside of this write ViewModel and return the View to CustomerForm-View if it is invalid.
* In the CustomerForm-View, all the needed object to be validate add @html.ValidationMesssageFor with the Linq expression.
* In the Customer Model-Properties add [Required]-Data-Annotation to the properties needed to be validated.
  * Not-Null DataTypes doesn't need to put [Required]-Data-Annotation
#### Styling Validation
* Go to Content-Folder select site.cs add field-validation-erro color and input-validation-error border.
#### Custom Validation
* Create anew class for the Custom-validaton in the Models-Folder and name it Min18YearsIfAMember
  * Add the required Directive for Data Annotation.
  * Inside the class, type override isvalid then select the one with two parameters.
	* remove any code here and implement our own business rules. 
* Inherit ValidationAttribute to the class
* put the Custom-DataAnnotation on the Customer-Birthdate-Model-Property 
* In the CustomerForm-View inside the <div> of the Birthdate add @html.ValidationMessageFor with the Linq expression.
* In CustomForm-Page populate Date of Birth = 1/1/2000 and Memship Type = Monthly and observe the validaton error messages. 
#### Refactoring Magic Numbers
* In the Domain Model MembershipType create static readonly variable name it Unknown and PayAsYouGo
  * In the Min18YearsIfAMember Custom-Data-Annotation in the If statement replace the 0 and 1 to this static readonly variables.
#### Validation Summary
* In the CustomerForm-View add @Html.ValidationSummary()
  * Go to Customer/New click save and observe the list of validation summary, specially the Id-Field.
  * In CustomerController ActionResult-New() initialize the Customer-Model to New-Customer()
  * replace @Html.ValidationSummary() to @Html.ValidationSummary("Please fix the following errors")
	* But before this go to the browser and inspect the hidden input to see the value.
  * You are now able to add new Customer!
  * For better user friendly navigation move the Membership-Type-Textbox at the bottom of the Name-Textbox.
#### Client-side Validation - Using "~/bundle/jqueryval"
* The bundle is generated in the App_Start-Folder BundleConfig.cs
* Go to _Layout-View to see the scripts render but there's no jqueryval so we need to create in the CustomerForm-View
  * Create a section and render the jqueryval bundle.
  * Go to the browser test the validaton-error-message and inspect to see the network activity.
* The properties in the html objects would understand the jqueryval bundles for validation-error-messages. 
#### Anti-forgery Token
* In the CustomersController add attribute and name it [ValidateAntiForgeryToken]
* In the CustomerForm-View on top of the submit-button write  @Html.AntiForgeryToken()
* To check, go to the brower, populate Name=ccc, Membership Type=Quarterly and click save, a validation-error-messaage appear and the page will remain.
  * Inspect and check the AntiForgeryToken value that was auto generated and encripted
  * Inspect and change the AntiForgeryToken value=any-string then save.
  * The submit would not be successful as a CSRF exemption prevented it.
#### Exercise solution on adding and editing movies with client-side validation
##### Validating via server-side
* Fixed the Movie-model and the Movies-table using code-first.
* Fixed the order of all the ActionResult Methods to stardard.
* In the MovieForm-view write @html.ValidationSummary() and @html.ValidationMessageFor.
* In the MoviesController on top of ActionResult-New() put [ValidateAntiForgeryToken] 
  * Check the ModelState.IsValid using If-statement.
	* Create viewModel variable for Movie and Genre Types
	* return the view to the MovieForm-view with the viewModel object.
##### Validtation from client-side
* In the MovieForm-view create a section then write and render the jqueryval-bundle-script.
##### Solution on get rid of the default value of Release Date and Date Added properties which was initialize in the viewModel variable.
* In the MoviesController ActionResult New() viewModel variable delete the Movie initialization.
* In the MovieForm view add @html.hidden helper.
##### Solution 2 on get rid of the model default values by using construtor in th MovieFormViewModel.
* In the Movie model, copy the all the properties then paste to MovieFormViewModel.
  * Remove the unnecessary properties which is not needed.
  * Fix the Data types and Data annotations
  * Create constructor for passing the new Movie properties
  * Create a method which return string for the MovieForm page title.
* In the MoviesController, for all the viewModel variable parameter pass the movie to get the 2nd overload constructor in the MovieFormViewModel.
  * Except in the ActionResult New() as you don't need the movie here just the Genre Types.
* In the MovieForm view, replace all ".Movie." to "."
  * Remove the hidden helper.
  * Put the Title Page using the TitleChange property defined in the MovieFormViewModel.
##### Eager Deployement and Publishing
  * In Azure Portal, create Wep + Mobile
	* Create App name, Resource Group name, On application insight and click create button.
	* Create Database by adding Database name, use the Existing Resource Group, select source is Blank Database.
	* Create a server by adding Server name, Server admin login, password, Location = Australia SoutEast, check Allow Azure services to access server and click seelect button.
	* Click the database created and look the Show database connection string link and copy the connection string.
	* Click and select the App Service for VidlyVideoRentalApp and click the link Get publish profile and save.
  * In Visual Studio select Publish, Import profile and import the profile that was saved from the Azure portal.
	* In the Setting tab, Configuration is Testing or Release, paste the connection string from Azure, select Execute code-first migration, Click Save and Publish.
  * In Visual Studio, Connect the remote database created from Azure in you SQL Server Object Explorer to manipulate the database.
  * Errors....
	* Sql("ALTER TABLE Movies DROP CONSTRAINT DF__Movies__NumberOf__4BAC3F29");
	* Sql("ALTER TABLE Movies DROP CONSTRAINT DF__Movies__GenreTyp__4CA06362");
#### Building an API for Customers
* In the Controllers folder, create a folder and name it Api
	* In this folder right click select Add select controller select Web Api 2 controller - Empty.
	* Create methods for CRUD operations and REST services.
* To test CRUD operation for Web API application use Postman by getpostman.com
#### Data Transfer Object(DTO)
	* In the root of the project create a folder named Dtos
		* Add a class named CustomerDto
			* from the Customer domain model copy all the properties and paste here.
			* Remove all the data annotations as we don't need it here.
#### Auto Mapper
* install-package automapper -version:4.1
* In the App_Start folder create a class named MappingProfile then inherit the Profile class from the AutoMapper namespace.
	* create a constructor for the MappingProfile.
	* this will load when the application starts up.
	* go Global.asax initialize and add the MappingProfile class.
* In CustomersController create the CRUD operations and REST services with AutoMapper tool.
##### Camel notation
In the App_start folder WebApiConfig.cs set the setting for camelcase notation
#### IHttActionResult for Web API
* Instead of using Domain Models to Return a value in the CRUD operation Methods, use IHttpActionResult, to see a better statuscode response.
	* Also use Helper method to return bad requerst or not found, instead of throwing new exception.
	* Custom made data annotion wouldn't work here, so remove all data annotions in the Dto's model.
#### Solution on Exercise 6 - Create a Web API for the Movies
* Create MovieDto - 
	* Add "Dtos" folder in the root folder
	* Go to Movie model copy all the properties
	* Add a class "MovieDto" then paste the properties from the "Movie" model and remove all data annotations
* Create MappingProfile - "App_start" folder create a class for MappingProfile.cs and inherit the "AutoMapper.Profile" class
	* Map the "Movie" and "MovieDto" models by using Mapper.CreateMap method
* Initialize the mapper in the "Global.asax.cs"
* Create API MoviesController - right click "API" folder add Controller and select Web API 2-Empty
	* Add the directives for Vidly.Models, Vidly.Dtos and AutoMapper
	* Create the CRUD operations with AutoMapper tool, IHttpActionResult
* Set JsonFormatters - "App_start", "WebApiConfig.cs" and the JsonFormatters settings
#### Create a Web API for Customers and add comments and fix models
* Createing CustomerDto
	* Add Dtos folder in the root folder
	* Go to Customer model copy all the properties
	* add a class "CustomerDto" and paste the copied properties of Customer model here.
* Createing Mapping profile - App_start folder create a class "MappingProfile.cs" and inherit the Automapper.Profile class(Profile)
	* Map the Customer model to CustomerDto model by using Mapper.CreateMap method
* Initialize the mapper in the Global.asax.cs
* Adding API CustomerController - right click "API folder" and Controller and select Web API 2 - Empty
	* Add the directives
	* Create CRUD operations with AutoMapper and IHttpActionResult type
Setting JsonFormatters - "App_start" then WebApiConfig.cs add the JsonFormatters settings

### Client-side Developemnt
#### Calling an API using jQuery
##### Implement Delete Customer
* Add a <th> Delete then Add <td> and put Delete button with a class btn-link
* create section script at the buttom of index file and write your jQuery code here
* Add a second class on the delete button named js-delete(for jQuery not presentation)
* In the table add id=customers
* In the Delete button add data attribute as data-customer-id=@customer.Id
* To debug jQuery click console on the the browser, also use XHR tab to check the status code
* Create a variable to reference to a button
##### Bootbox Dialog Boxes - Bootstrap
* PM> install-package bootbox -version:4.3.0
* App_Start - BundleConfig.cs add bootbox.js here
##### Data Tables Plug-in
* PM> install-package jquery.datatables -version:1.10.11
* BundleConfig.cs and _Layout.cshtml consolidate the bundles
#### Data Tables with Ajax source
* Inside the DataTable method parameter, write the configuration objects for the Customers.
* Use Ajax to get the source. 
* Includes Pagination, Sorting and Searching
##### Returning Hierarchical Data, Relational Model of Customer and its MembershipType
* Create MembershipTypeDto and AutoMapper in the MappingProfile.cs.
	* Write only the desired properties.
* In the CustomerDto add a MembershipType properyty with type of MembershipType
* In the IHttpActionResult GetCustomer() add the include(c => c.MembershipType).Tolist() to include the relationship
* In the jQuery Script add the membershipType column data.
	* Observe the camelCase settings of the data properties returned by API
##### Removing Records in the DataTable
* Create a variable for the DataTable
* In the Delete Click event script call back function use the table variable with its row(), remove() and draw()
##### Exercise 1 - List and delete movies implemeting Web API and DataTable jQuery Plug-in.
* Create GenreTypeDto, and AutoMapper it in the MappingProfile.cs(desired properties only).
* In the MovieDto, add GenreType property with type of GenreType.
* In the MoviesController, create simple ViewResult Index() and use System.Data.Entity.
* In the Movies Index, create a table for the list of movies (id="movies").
	* Create section scripts and write the jQuery View action and Delete action for movies.

### Authentication and Authorization - Restrict all capabilites to logged-in users or to anonymous users
#### Authentication Options - Implement Individual User Accounts
#### ASP.NET Identity - Includes Microsoft.AspNet.Identity.Core, Microsoft.AspNet.Identity.EntityFramework, Microsoft.AspNet.Identity.Owin
* ASP.NET Identity
	* Has a number of domain classes like IdentityUser and Role classes
	* To provide with simple API/Services to work with UserManager, RoleManager and SignInManager classes
	* The InitialModel migration was generated a scripts for creating the AspNetRoles, AspNetUserRoles and etc table in the database
		* In the IdentityModels.cs we have ApplicationUser class which derived from IdentityUser ASP.NET Identity Framework.
		* Also we have ApplicationDBContext which derived from IdentityDbContext ASP.NET Identity Framework.
	* In AccountController.cs  - exposes a number of action like login, logout, register and so on.
#### Restricting Access
* Adding a filter globally
	* In the FilterConfig.cs add filters.Add(new AuthorizeAttribute());
* Making the home page accessible to anonymous users
	* In the HomeController.cs, add [AllowAnonymous] attribute.
##### Seeding Users and Roles - restrict movie management operations to store managers
* Login by Clicking Register - email=guest@vidly.com password=Keyboard-1978
* In the AccountController, add a Temporary code to populate the database with a user in the store manager role.
	* Logoff and Register as admin@vidly.com and password=Admin-123
* add-migration SeedUsers
	* In the up(), add sql Insert Into statement to populate the AspNetUsers, AspNetRoles and AspNetUserRoles
* Delete all this users and user roles from the database.
* update-database
##### Working with Roles
* Restrict anonynous users from deleting, updating and creating movies.
	* In the Movies Views, rename the Index.cshtml as List.cshtml.
		* Duplicate the List.cshtml and Rename it to ReadOnlyList(ctrl+v to paste).
	* In the ReadOnlyList.cshtml, remove the html tags and scripts which are not needed here(be carefull on removing scripts).
	* In the MoviesController, use User.IsInRole() to check and return the List view.
		* In the ViewResult New() add [Authorize(Roles="CanManageMovies")]
		* Apply this to other ViewResult actions like Create, update, delete and Edit and applies to movies API's as well.
	* In the Models folder, add new class named RoleName and create a constant variables for the name of the user roles.
		* Then in the MoviesController change all the magic string "CanManageMovies" to RoleName.CanManageMovies.	 
##### Adding Profile Data to the User
* In the Model folder, IdentityModels.cs Domain Model, add a new property for DrivingLicense.
* add-migration AddDrivingLicenseToApplicationUser and update-database
* Find the RegisterViewModel class which is in the AccoutViewModels.cs file then create a property for the DrivingLicense
* In the View Folder, Account Folder select Register.cshtml and create the input field for the DrivingLicense by using Div, LabelFor and TextboxFor helpers.
* In the AccountController, ActionResult Register(RegisterViewModel model), user variable, set the DrivingLicense here.
* Register user1@vidly.com password=User1-123 Driving License=123 and it will automatically login.
* Go to the datebase, AspNetUser table, finde the user1@vidly user and observe the DrivingLicense field.
##### Social Logins - Facebook
* In the Vidly project, press F4 and set SSL Enabled = true to establish secure connection to Vidly and copy the new url.
	* Right click, properties, Web tab, Project Url and paste the new Url(https://localhost:44301/)
* To fully secure the Web Site, In the FilterConfig.cs, add a filter for RequireHttpsAttribute().
* Go to Developers.facebook.com and register then create App ID then put you Url Site and click "Skip to Developer Dashboard"
	* Copy the App ID, go to App_start, StartupAuth.cs, scroll down then uncomment the app.UseFacebookAuthentication() and paste the App ID and App Secret here.
* View, Account folder select Register.cshtml copy the form group of the DrivingLicense and paste(before the submit button) to ExternalLoginConfirmation.cshtml. 
* In the AccountViewModels.cs, ExternalLoginConfirmationViewModel class add a property for the DrivingLicense.
* In the AccountController.cs, ActionResult "ExternalLoginConfirmation(ExternalLoginConfirmationViewModel model, string returnUrl)", user variable add and set DrivingLicense property to model.DrivingLicense.
* NuGet Package Manager, NuGet Package Manager-Solution install Microsoft.Owin.Security.Facebook

### Building a Feature End-to-End Systematically
##### Understanding the Problem
* Add the ability to record rentals
	* Start from the back-end
	* Input: Customer and Movies (the ids)
	* Output: None
* To return markup use MVC Controller
* To return data use API Controller
* Exercise: Create an API New Rental use case, start on the back-end
	* Create a NewRentalDto in the Dtos = this is a Customer - Movies 1 to many relationship, one CustomerId have List of MovieIds
	* Create a NewRentalsController = plural, IHttpActionResult
##### Domain Modelling - Adding Rental Domain Model
* UML Class = Customer and Movies
* Association Class = Create a domain class/model and name it Rental, singular
##### Exercise 2 - Building the Simplest API
* In the API NewRentalsController, write a IHttpActionResult CreateNewRentals()
	* Apply comments every block of code
##### Adding the details for the Movies Stock
* Add new property to the Movie class called NumberAvailable
* Update the availability of the movies
	* add-migration AddNumberAvailablePropertyToMovieClass
		* modify the this migration by adding sql update statement
	* update-database
	* In the NewRentalsController, modify the CreateNewRentals()
##### Edge Cases - a problems might arrived
* Defensive Approach
	* No MovieIds
		* Check the NewRentalDto.MovieIds.Count, if it is 0 return BadRequest()
	* CustomerId is invalid
		* change Single method to SingleOrDefault() and check if customer is null and return BadRequest
	* One or more MovieIds are invalid
		* check movies.Count != newRentalDto.MovieIds.Count if true return bad request
	* One or more movies are not available
		movies.Count != newRentalDto.MovieIds.Count
* Optomistic Approach
	* Delete all edge case except checking the movies.Count != newRentalDto.MovieIds.Count
	* Change SingleOrDefault() to Single()
##### Building the Front-end for the New Rental
* Add RentalsController()
	* Add ActionResult New()
	* Add a View for this controller
		* Create a raw form html
		* div.form-group>label+input[type='text'].form-control
		* button.btn.btn-primary
* In the _NavBar.cshtml, add the action link for the NewRental
##### Adding Autocompletion using Typeahead
* install-package Twitter.Typeahead
* In the BundleConfig.cs, add the Typeahead script path under bundles/lib
* go google and typeahead.js example page (https://twitter.github.io/typeahead.js/examples/)
	* right click select View page source
	* find this then click this ../css/examples.css and copy the selected css code only
* In the Content folder, add typeahed.css, delete the body and paste the typeahed css code.
* In the Bundle.config, under /Content/css add the typeahed.css
* Back to the example page, find the Remote link and click.
	* copy only the jQuery script
* In the Rentals\New.cshtml, add section scripts, add script tag, add jQuery standard initialization and paste
	* In the jQuery script, change the variables, routes and values
##### Ex1: Adding Auto-completion using Typeahead for Movies and Updating the DOM
	* In the Rentals/New.cshtml, add ul#movies.list.group
	* input id="movie"
	* copy the jQuery script and modify the variables
##### Improving the look and feel
* In the /Rentals/New.cshtml, add a div.tt-container and wrap the input text of the customer and the input textbox of movie
	* In the script, change the bullet to list and fix the width
	* wrap the ul tag to div.row>div.col-md-4
* In the typeahead.css, add .tt-contatiner
##### Filtering Records for Customer in the typehead input
* In the API CustomersController, GetCustomer() add a parameter type of string
	* modify the code block 
##### Ex2: Filter records in the input typehead for the name of Movies and the Movies availability
* In the  API MoviesController, GetMovies, add a string parameter to query the movies, also check the movies availability
	* Modify the block code
##### Submitting the Form for the New Rentals
* In the Rentals/New.cshtml, form tag id="newRental"
	* Add submit jQuery script
##### Displaying Toast Notification
* install-package toastr
* In the BundleConfig.cs, add the toastr.css and toastr.js
* In the Rentals/New.cshtml, .done extension method, add the toastr.success and same as in the .fail method
##### Implementing Client-side Validation for Customers
* In the Rentals/New.cshtml, modify the html tags and scripts
##### EX1: Implement Client-side Validation for Movies
* In the Rentals/New.cshtml, input tag, add attributes data-rule-atLeastOneMovie="true" and name="movie"
	* In the script, use selector.validate({ajax route settings}) to validate and submit the form
		* Use validator.addMethod(data-rule, function, message)