using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace QrWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public byte[] Image;

        public void OnGet()
        {
            Image = QrCodeGenerator.GenerateByteArray("https://balta.io");
        }
    }
}
