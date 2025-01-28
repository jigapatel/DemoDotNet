using Microsoft.AspNetCore.Mvc.RazorPages;

public class AboutModel : PageModel
{
    public string Title { get; set; }
    public string Message { get; set; }

    public void OnGet()
    {
        Title = "About Us";
        Message = "Your application description page.";
    }
}
