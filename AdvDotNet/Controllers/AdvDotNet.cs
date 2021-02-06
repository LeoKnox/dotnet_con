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

        public string Welcome()
        {
            return "Welcome to an adventure...";
        }
    }
}