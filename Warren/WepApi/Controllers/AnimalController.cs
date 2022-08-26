using Microsoft.AspNetCore.Mvc;
using Data.Model;
using Data.Repository;

namespace WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
       [HttpGet("GetCachorro")]
       public Animal Get()
        {
            Animal animal = new Animal
            {
                Id = 1,
                Nome = "Rex",
                Especie = "Cachorro",
                Peso = 3.8f
            };
            return animal;
        }

        [HttpPost]
        public string Post(Animal animal)
        {
            AnimalRepository repo = new AnimalRepository();
            return repo.Create(animal);
        }
    }
}
