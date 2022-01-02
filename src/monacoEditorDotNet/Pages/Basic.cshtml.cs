using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace monacoEditorDotNet.Pages;

public class BasicModel : PageModel
{
    private readonly ILogger<BasicModel> _logger;

    public BasicModel(ILogger<BasicModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
