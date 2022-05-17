using LightweightStats.API.Models;
using System.Net.Http.Json;

namespace LightweightStats.HttpServices.Services;

public class ClubService
{
    private readonly HttpClient _httpClient;

    public ClubService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public Task<Club[]?> GetClubs() =>
        _httpClient.GetFromJsonAsync<Club[]>("v1/clubs");
}
