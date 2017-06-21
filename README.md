# katanaFirst
Sample App Created in Console Application for starting with Microsoft Katana

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
