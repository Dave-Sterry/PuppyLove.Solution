using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using PuppyLoveClient.Models;
using System.Threading.Tasks;
using PuppyLoveClient.ViewModels;
using System.Linq;
using System.Security.Claims;

namespace PuppyLoveClient.Controllers
{
  public class AccountController : Controller
  {
    private readonly PuppyLoveClientContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, PuppyLoveClientContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public ActionResult Index() // async <Task>
    {
      //var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      //var currentUser = await _userManager.FindByIdAsync(userId);
      //var userDogs = _db.Dogs.Where(entry => entry.User.Id == currentUser.Id);
      return View(); // userDogs
    }

    public ActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register(RegisterViewModel model)
    {
      var user = new ApplicationUser { UserName = model.Email };
      IdentityResult result = await _userManager.CreateAsync(user, model.Password);
      if (result.Succeeded)
      {
        return RedirectToAction("Index");
      }
      else
      {
        return View();
      }
    }

    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Login(LoginViewModel model)
    {
      Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
      if (result.Succeeded)
      {
        return RedirectToAction("Index");
      }
      else
      {
        return View();
      }
    }

    [HttpPost]
    public async Task<ActionResult> LogOff()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index");
    }
  }
}