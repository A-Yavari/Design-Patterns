using Application.FacadePattern;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Facade_Asp.Net.Core.Pages;

public class IndexModel : PageModel
{
    private readonly IFacadeService _facadeService;
    public IndexModel(IFacadeService facadeService)
    {
        _facadeService = facadeService;
    }

    public void OnGet()
    {
        _facadeService.RegisterUserService.Execute();
        _facadeService.LoginUserService.Execute();
    }
}