using Trinsic;

var providerService = new ProviderService();

var (ecosystem, authToken) = await providerService.CreateEcosystemAsync(new());

Console.WriteLine($"AuthToken = {authToken}");
Console.WriteLine($"Ecosystem = {ecosystem.ToString()}");