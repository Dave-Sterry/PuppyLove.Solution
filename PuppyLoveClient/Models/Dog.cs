using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PuppyLoveClient.Models
{
    public class Dog
    {
        public int DogId { get; set; }
        public string Name { get; set; }
        public string OwnerName { get; set; }
        public string User { get; set; }
        public string Mood { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Size { get; set; }
        public string Location { get; set; }
        public string ImgUrl { get; set; }

        public static Dog GetRandom()
        {
            var apiCallTask = ApiHelper.Random();
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Dog dog = JsonConvert.DeserializeObject<Dog>(jsonResponse.ToString());

            return dog;
        }

        public static Dog GetDetails(int id)
        {
            var apiCallTask = ApiHelper.Get(id);
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Dog dog = JsonConvert.DeserializeObject<Dog>(jsonResponse.ToString());

            return dog;
        }

        public static void Post(Dog dog)
        {
            string jsonDog = JsonConvert.SerializeObject(dog);
            var apiCallTask = ApiHelper.Post(jsonDog);
        }

        public static void Put(Dog dog)
        {
            string jsonDog = JsonConvert.SerializeObject(dog);
            var apiCallTask = ApiHelper.Put(dog.DogId, jsonDog);
        }

        public static void Delete(int id)
        {
            var apiCallTask = ApiHelper.Delete(id);
        }
    }
}