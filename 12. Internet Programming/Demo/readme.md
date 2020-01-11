# Simple ASP.NET Core Demo

## 1. Class Library (.NET Core) 
Create **Class Library (.NET Core)** Project and Named it **Data**.

Add NuGet Packages
```
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.Proxies
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
```
Add Class Car
```
public class Car
{
	public int Id { get; set; }
	public string RegNo { get; set; }
	public string Model { get; set; }
	public string Brand { get; set; }
}
```
Add Class CarContext
```
public class CarContext : DbContext
{
	public CarContext()
	{
		;;
	}
	public CarContext(DbContextOptions<CarContext> options) : base(options)
	{
		;;
	}
	public virtual DbSet<Car> Cars { get; set; }
	protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
	{
		optionBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CarsDb;");
		optionBuilder.UseLazyLoadingProxies();
	}
}
```
Package Manager Console
```
Add-Migration InitialCreate
Update-Database
```

## 2. ASP.NET Core Web Application  
Create **ASP.NET Core Web Application** Project using the template **Web Application (Model-View-Controller)** and Named it **WebApp**.

- Add reference to the project **Data**.
- Add folder **Cars** in the Views.

- Right Click on Cars: Add > New Scafolded Item > MVC Controller with Views, using Entity Framework
```
Model: Car
Data content class: CarContext (Data)
```
Move **CarsController.cs** to the folder Controllers

appsettings.json
```
"ConnectionStrings": {
	"DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=CarsDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```
StartUp.cs
```
services.AddDbContext<CarContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
```
_Layout.cshtml
```
<li class="nav-item">
	<a class="nav-link text-dark" asp-area="" asp-controller="Cars" asp-action="Index">Cars</a>
</li>
```
