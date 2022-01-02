using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace monacoEditorDotNet.Pages;

public class CompareModel : PageModel
{
    private readonly ILogger<CompareModel> _logger;

    public CompareModel(ILogger<CompareModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

