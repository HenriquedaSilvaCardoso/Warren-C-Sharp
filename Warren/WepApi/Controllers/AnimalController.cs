using Microsoft.AspNetCore.Mvc;
using Data.Model;
using Data.Repository;

namespace WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private AnimalRepository repo;

        public AnimalController()
        {
            repo = new AnimalRepository();
        }

        [HttpGet("GetAll")]
        public List<Animal> GetAll()
        {
            return repo.GetAll();
        }

        [HttpPost("InsertIntoAnimal")]
        public string InsertIntoAnimal(Animal animal)
        {
            return repo.Create(animal);
        }

        [HttpGet("GetById")]
        public Animal GetById(int id)
        {
            return repo.GetById(id);
        }

        [HttpDelete("DeleteAnimalById")]
        public string DeleteAnimalById(int id)
        {
            return repo.Delete(id);
        }

        [HttpPut("UpdateAnimal")]
        public string UpdateAnimal(Animal model)
        {
            return repo.Update(model);
        }
    }
}
