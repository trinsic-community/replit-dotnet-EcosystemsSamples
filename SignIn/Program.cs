using Trinsic;

var accountService = new AccountService();

var authToken = await accountService.SignInAsync(new());

var infoResponse = await accountService.GetInfoAsync();

Console.WriteLine($"AuthToken = {authToken}");
Console.WriteLine($"Info = {infoResponse.ToString()}");