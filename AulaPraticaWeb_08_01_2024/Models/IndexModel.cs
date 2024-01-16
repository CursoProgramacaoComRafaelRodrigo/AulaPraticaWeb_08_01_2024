using Microsoft.AspNetCore.Session;
namespace AulaPraticaWeb_08_01_2024.Models;

public class IndexModel
{
    public const string SessionKeyName = "_Name";
    public const string SessionKeyAge = "_Age";
    private readonly ILogger<IndexModel> _logger;
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    public string OnGet()
    {
        return SessionKeyName;
    }
}