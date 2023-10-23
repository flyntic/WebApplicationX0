
using WebApplicationX0.Services;
namespace WebApplicationX0.Models
{
    public class HomeViewModel
    {
        public int? number { get;  set; }
        public string? romeNumber { get; set; } // { return number.RomeNumber(); }

        public HomeViewModel()
        {
            number = 0;
            romeNumber = "0";
         }
    }
}
