# .NET Samples for Trinsic Ecosystems

This repl is a collection of projects showcasing different use cases when working 
with Trinsic SDK. These use cases will cover mostly server setup scenarios, but they 
can be applied to client access, too, since the SDK is the same.

To run the samples, from the root directory run the command

```bash
dotnet run --project <directory>
```

For example `dotnet run --project SignIn`

## Configuring `AuthToken`

Some projects, such as `WebApiSample` showcase how a server hosted application can be configured 
using Trinsic SDK with auth token passed from an environment variable. To configure this variable, edit the `.replit` file 
and fill the `AUTH_TOKEN` variable. You can get an auth token by running the Trinsic CLI.

> This auth token will only be saved for the replit associated with your profile