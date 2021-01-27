using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PuppyLoveClient.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace PuppyLoveClient.Controllers
{
  public class DogsController : Controller
  {
    // public IActionResult Index()
    // {
    //   var allDogs = Dog.GetDogs();
    //   return View(allDogs);
    // }

    private readonly PuppyLoveClientContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public DogsController(UserManager<ApplicationUser> userManager, PuppyLoveClientContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public IActionResult Index()
    {
      var randomDog = Dog.GetRandom();
      return View(randomDog);
    }

    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(Dog dog) // user id
    {
      // var dog.User = this.User.FindFirst(ClaimTypes.NameIdentifier)?.currentUser.Id;
      Dog.Post(dog);
      return RedirectToAction("Index", "Home");
    }

    public IActionResult Details(int id)
    {
      var dog = Dog.GetDetails(id);
      return View(dog);
    }

    public IActionResult Edit(int id)
    {
      
      var dog = Dog.GetDetails(id);
      return View(dog);
    }

    [HttpPost]
    public IActionResult Edit(int id, Dog dog)
    {

      // currentUser = asdfasdf
      // if dog.userId == currentUser.Id
      dog.DogId = id;
      Dog.Put(dog);

      // else
      // return failed to execute
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Dog.Delete(id);
      return RedirectToAction("Index");
    }
  }
}