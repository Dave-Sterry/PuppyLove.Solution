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
    public IActionResult Index()
    {
      var allDogs = Dog.GetDogs();
      return View(allDogs);
    }

    [HttpPost]
    public IActionResult Index(Dog dog)
    {
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
    public IActionResult Details(int id, Dog dog)
    {
      dog.DogId = id;
      Dog.Put(dog);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Dog.Delete(id);
      return RedirectToAction("Index");
    }
  }
}