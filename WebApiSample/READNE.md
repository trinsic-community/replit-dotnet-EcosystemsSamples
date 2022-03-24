# Web API Sample

This project shows how Trinsic SDK can be used with ASP.NET Core hosted web API. 
The Trinsic services are injected using the dependency injection extensions.
This sample requires that `AUTH_TOKEN` be set in the `.replit` file in order to configure the 
running server instance.

To run the project simply run `dotnet run` from the console.
You can then open a new shell and run `curl http://localhost:5000/templates/list` to fetch the results 
from the exposed API