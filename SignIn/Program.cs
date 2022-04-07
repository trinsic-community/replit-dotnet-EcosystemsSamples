using Trinsic;

var accountService = new AccountService();

var authToken = await accountService.SignInAsync(new());

// to sign in to a specific ecosystem pass the name of that
// ecosystem to the sign in request
// 
// var authToken = await accountService.SignInAsync(new() {
//   EcosystemId = "ecosystem-name-or-id"
// });

var infoResponse = await accountService.GetInfoAsync();

Console.WriteLine($"AuthToken = {authToken}");
Console.WriteLine($"Info = {infoResponse.ToString()}");

// the token will be saved automatically to local storage
// it can be optionally passed to the services using
// 
//   var walletService = new WalletService(new() { 
//      AuthToken = authToken
//   });

var walletService = new WalletService();

var search = await walletService.SearchAsync();

Console.WriteLine($"Search = {search}");