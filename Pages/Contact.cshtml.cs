using Microsoft.AspNetCore.Mvc.RazorPages;

public class ContactModel : PageModel
{
    public string Title { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public void OnGet()
    {
        Title = "Contact Us";
        Email = "contact@company.com";
        Phone = "123-456-7890";
    }
}
