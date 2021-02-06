using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace AdvDotNet.Controllers
{
    public class AdvDotNetController : Controller
    {
        public string Index()
        {
            return "This is the beginning of an adventure...";
        }

        public string Welcome(string name, int ID=1)
        {
            return HtmlEncoder.Default.Encode($"Welcome {name}, you are level {ID}");
        }
    }
}