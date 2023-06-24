using FrontToBack.Hubs;
using FrontToBack.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Controllers
{
    public class ChatController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly IHubContext<ChatHub> _hubcontext;



        public ChatController(UserManager<AppUser> usermanager, IHubContext<ChatHub> hubcontext )
        {
            _userManager = usermanager;
            _hubcontext = hubcontext;
        }

        public IActionResult Chat()
        {
            ViewBag.Users = _userManager.Users.ToList();
            return View();
        }
        public async Task<IActionResult> ShowAlert(string userid)
        {
          var user=  _userManager.FindByIdAsync(userid).Result;
            if (user == null) return NotFound();
;          await  _hubcontext.Clients.Client(user.ConnectionId).SendAsync("ShowAlert", user.FullName);
            return Content("");
        }
    }
}
