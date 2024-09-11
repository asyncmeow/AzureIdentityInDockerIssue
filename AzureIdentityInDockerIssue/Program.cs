using Azure.Core;
using Azure.Identity;

var cred = new DefaultAzureCredential();
var context = new TokenRequestContext(["https://storage.azure.com/.default"]); // wasn't sure of what context to use tbh
var token = await cred.GetTokenAsync(context);
Console.WriteLine(token.Token);