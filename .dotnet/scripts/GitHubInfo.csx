#r "nuget: Octokit, 0.48.0"

using Octokit;
using System;
using System.Threading.Tasks;

var client = new GitHubClient(new ProductHeaderValue("OctokitSamples"));
var user = "octocat";

try
{
    var repositories = await client.Repository.GetAllForUser(user);
    Console.WriteLine($"Public repositories owned by {user}:");

    foreach (var repo in repositories)
    {
        Console.WriteLine($"{repo.Name} - {repo.GitUrl}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

