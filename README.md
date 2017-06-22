# katanaFirst
Sample App Created in Console Application for starting with Microsoft Katana

## Either Clone repository and open the KatanaIntro.sln in Visual Studio 2015
## OR
## Create a new project, install Nuget packages , paste the content in Program.cs file to your main file

## Creating a New Project
1. Open Microsoft Visual Studio 2015
2. File -> New -> Project -> Visual C# -> Console Application
3. Enter Name: KatanaIntro


## Nuget Packages
1. Open Package Manager Console
2. Package source as `nuget.org`
3. Run 
  * `install-package Microsoft.Owin.Hosting`
  * `install-package Microsoft.Owin.Host.HttpListener`
  * `install-package Microsoft.Owin.Host.Diagnostics`


## Run the Application
1. `Ctrl + f5` for running the Application.
2. Open a browser and type `http://localhost:8080` as the URL.
3. If you want to see some of the Default middleware available in 'Microsoft.Owin.Diagnostics' type 'app.' then you can see 'app.UseWelcomePage()' as an example. 
