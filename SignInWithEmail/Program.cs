using Trinsic;
using Trinsic.Sdk.Options.V1;
using Trinsic.Services.Account.V1;

Console.Write("Please enter your email: ");
var email = Console.ReadLine();

var accountService = new AccountService();

var authToken = await accountService.SignInAsync(new SignInRequest {
    Details = new AccountDetails {
        Email = email
    }
});

Console.Write("Check your email and enter security code: ");
var securityCode = Console.ReadLine();

authToken = AccountService.Unprotect(authToken, securityCode);
accountService.Options.AuthToken = authToken;

var infoResponse = await accountService.GetInfoAsync();

Console.WriteLine($"AuthToken = {authToken}");
Console.WriteLine($"Info = {infoResponse}");

var walletService = new WalletService(new ServiceOptions {
    AuthToken = authToken
});

var search = await walletService.SearchAsync("SELECT c.id, c.type FROM c");

Console.WriteLine($"Search Results = {search}");