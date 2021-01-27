using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PuppyLove.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace PuppyLove.Controllers
{
    [Route("api/dogs")]
    [ApiController]
    public class DogsController: ControllerBase
    {
        private PuppyLoveContext _db;
        
        public DogsController(PuppyLoveContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Dog>> Get(string name, string ownername, string mood, int age, string breed, string size, string location, string user)
        {
            var query = _db.Dogs.AsQueryable();

            if ( name != null)
            {
                query = query.Where(entry => entry.Name == name );
            }
            
            if ( ownername  != null)
            {
                query = query.Where(entry => entry.OwnerName == ownername);
            }

            if ( mood!= null)
            {
                query = query.Where(entry => entry.Mood == mood);
            }

            if ( age != 0)
            {
                query = query.Where(entry => entry.Age == age);
            }

            if ( breed != null)
            {
                query = query.Where(entry => entry.Breed == breed);
            }

            if ( size != null)
            {
                query = query.Where(entry => entry.Size == size);
            }

            if ( location != null)
            {
                query = query.Where(entry => entry.Location == location);
            }

            if ( user != null)
            {
                query = query.Where(entry => entry.User == user);
            }
            
            return query.ToList();
        }

        [HttpPost]
        public void Post([FromBody] Dog dog )
        {
            _db.Dogs.Add(dog);
            _db.SaveChanges();
        }

        [HttpGet("{id}")]
        public ActionResult<Dog> Get(int id)
        {
            return _db.Dogs.FirstOrDefault(entry => entry.DogId == id);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Dog dog )
        {
            dog.DogId = id;
            _db.Entry(dog).State = EntityState.Modified;
            _db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete (int id)
        {
            var dogToDelete = _db.Dogs.FirstOrDefault(entry => entry.DogId ==id);
            _db.Dogs.Remove(dogToDelete);
            _db.SaveChanges();
        }

        [HttpGet]
        [Route("random")]
        public ActionResult <Dog> Random()
        {
            Random random = new Random();
            int randomDog = random.Next(_db.Dogs.ToList().Count);
            return _db.Dogs.FirstOrDefault(entry => entry.DogId == randomDog);
        }

    }
}

