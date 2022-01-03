using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace monacoEditorDotNet.Pages;

public class CustomLanguageModel : PageModel
{
    private readonly ILogger<CustomLanguageModel> _logger;

    public CustomLanguageModel(ILogger<CustomLanguageModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
