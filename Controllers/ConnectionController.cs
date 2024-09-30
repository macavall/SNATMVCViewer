using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

namespace SNATMVCViewer.Controllers
{
    public class ConnectionController : Controller
    {
        private static TcpClient _tcpClient;

        public IActionResult Index()
        {
            return View();
        }
    }
}
