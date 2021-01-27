using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PuppyLoveClient.Models;

namespace PuppyLoveClient.Controllers
{
  public class DogsController : Controller
  {
    // public IActionResult Index()
    // {
    //   var allDogs = Dog.GetDogs();
    //   return View(allDogs);
    // }

    public IActionResult Index()
    {
      var randomDog = Dog.GetRandom();
      return View(randomDog);
    }

    [HttpPost]
    public async Task<ActionResult> Create(Dog dog, str User )
    {

      // var dog.User = this.User.FindFirst(ClaimTypes.NameIdentifier)?.currentUser.Id;
      Dog.Post(dog);
      return RedirectToAction("Index");
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