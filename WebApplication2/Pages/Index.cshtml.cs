using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace WebApplication2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<string> Output { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Output = new List<string>();
        }

        public void OnGet()
        {
            Animal animal = new Animal();
            Output.Add(animal.MakeSound());

            Dog dog = new Dog("Askal");
            Output.Add(dog.MakeSound());

            Cat cat = new Cat("Askal");
            Output.Add(cat.MakeSound());
        }
    }

    public class Animal
    {
        protected string sound = "Default sound";

        public Animal()
        {
        }

        public virtual string MakeSound()
        {
            return sound;
        }
    }

    public class Dog : Animal
    {
        protected string breed;

        public Dog(string breed)
        {
            this.breed = breed;
            sound = "Bark";
        }

        public override string MakeSound()
        {
            return $"A {breed} dog says: {sound}";
        }
    }

    public class Cat : Animal
    {
        protected string breed;

        public Cat(string breed)
        {
            this.breed = breed;
            sound = "Meow";
        }

        public override string MakeSound()
        {
            return $"A {breed} cat says: {sound}";
        }
    }
}