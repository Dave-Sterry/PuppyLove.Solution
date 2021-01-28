using PuppyLoveClient.Models;
using System;
using System.Linq;
using System.Diagnostics;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace PuppyLoveClient.Controllers
{
  public class DogsController : Controller
  {

    private readonly PuppyLoveClientContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public DogsController(UserManager<ApplicationUser> userManager, PuppyLoveClientContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public IActionResult Index()
    {
      try{
          var randomDog = Dog.GetRandom();
          return View(randomDog);
      } catch(NullReferenceException){
          return RedirectToAction("DogError");
      }
    }

    public IActionResult DogError()
    {
      return View();
    }

    [Authorize]
    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Dog dog)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      dog.User = currentUser.Id;
      Dog.Post(dog);
      return RedirectToAction("Index", "Home");
    }

    public IActionResult Details(int id)
    {
      var dog = Dog.GetDetails(id);
      return View(dog); 
    }
    
    [Authorize]
    public IActionResult Edit(int id)
    {
      
      var dog = Dog.GetDetails(id);
      return View(dog);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(int id, Dog dog)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      dog.User = currentUser.Id;
      dog.DogId = id;
      Dog.Put(dog);
      return RedirectToAction("Details", new {id = id});
    }

    [Authorize]
    public async Task<IActionResult> Delete(int id, Dog dog)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      dog.User = currentUser.Id;
      Dog.Delete(id);
      return RedirectToAction("Index");
    }
  }
}