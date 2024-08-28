using HSR_CHARACTERS.API.Data;
using HSR_CHARACTERS.API.Models.Domain;
using HSR_CHARACTERS.API.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HSR_CHARACTERS.API.Controllers
{
    // https://localhost:7060/api/type
    [Route("api/[controller]")]
    [ApiController]
    public class TypeController : ControllerBase
    {
        private readonly HSR_CHARACTERSDbContext dbContext;

        public TypeController(HSR_CHARACTERSDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET ALL TYPES
        // GET: // https://localhost:7060/api/type
        [HttpGet]
        public IActionResult GetAll()
        {
            /*var types = new List<CharactersType>
            {
                new CharactersType
                {
                    Id = Guid.NewGuid(),
                    Name = "Ice",
                    TypeImageIRL = "https://static.wikia.nocookie.net/houkai-star-rail/images/3/35/Type_Ice.png/revision/latest?cb=20220610120329"
                },
                new CharactersType
                {
                    Id = Guid.NewGuid(),
                    Name = "Fire",
                    TypeImageIRL = "https://static.wikia.nocookie.net/houkai-star-rail/images/f/f0/Type_Fire.png/revision/latest?cb=20220610120131"
                },
                new CharactersType
                {
                    Id = Guid.NewGuid(),
                    Name = "Physical",
                    TypeImageIRL = "https://static.wikia.nocookie.net/houkai-star-rail/images/6/69/Type_Physical.png/revision/latest?cb=20220610120901"
                },
                new CharactersType
                {
                    Id = Guid.NewGuid(),
                    Name = "Lightning",
                    TypeImageIRL = "https://static.wikia.nocookie.net/houkai-star-rail/images/1/15/Type_Lightning.png/revision/latest?cb=20220610120726"
                },
                new CharactersType
                {
                    Id = Guid.NewGuid(),
                    Name = "Wind",
                    TypeImageIRL = "https://static.wikia.nocookie.net/houkai-star-rail/images/e/ec/Type_Wind.png/revision/latest?cb=20220610121015"
                },
                new CharactersType
                {
                    Id = Guid.NewGuid(),
                    Name = "Quantium",
                    TypeImageIRL = "https://static.wikia.nocookie.net/houkai-star-rail/images/5/54/Type_Quantum.png/revision/latest?cb=20220610121124"
                },
                new CharactersType
                {
                    Id = Guid.NewGuid(),
                    Name = "Imaginary",
                    TypeImageIRL = "https://static.wikia.nocookie.net/houkai-star-rail/images/2/2f/Type_Imaginary.png/revision/latest?cb=20220610120517"
                }
            };*/

            // Get Data from Database - Domain models

            var typesDomain = dbContext.CharactersTypes.ToList();

            // Map Domain models to DTOs

            var typesDTOs = new List<CharactersTypeDTOs>();
            foreach(var typeDomain in typesDomain)
            {
                typesDTOs.Add(new CharactersTypeDTOs()
                {
                    Id = typeDomain.Id,
                    Name = typeDomain.Name,
                    TypeImageIRL = typeDomain.TypeImageIRL
                });
            }

            // Return DTOs back to the client
            return Ok(typesDTOs);
        }

        //GET SINGLE TYPE (Get Type by ID)
        // GET: // https://localhost:7060/api/type/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetById([FromRoute]Guid id)
        {
            //var type = dbContext.CharactersTypes.Find(id);
            // Get Type Domain model from  Database 
            var typeDomain = dbContext.CharactersTypes.FirstOrDefault(x => x.Id == id);

            if (typeDomain == null)
            {
                return NotFound();
            }

            // Map/Convert Type Domain model to Type DTO
            var typeDTOs = new CharactersTypeDTOs
            {
                Id = typeDomain.Id,
                Name = typeDomain.Name,
                TypeImageIRL = typeDomain.TypeImageIRL
            };

            // Return DTO back to client          
            return Ok(typeDTOs);
        }

        // POST To Create a New Type
        // POST: // https://localhost:7060/api/type/
        [HttpPost]
        public IActionResult Create([FromBody] AddTypeRequestDTOs addTypeRequestDTOs)
        {
            // Map/Convert DTO to Domain model
            var typeDomainModel = new CharactersType
            {
                Name = addTypeRequestDTOs.Name,
                TypeImageIRL = addTypeRequestDTOs.TypeImageIRL
            };

            //Use Domain Model to create Type
            dbContext.CharactersTypes.Add(typeDomainModel);
            dbContext.SaveChanges();

            // Map Domain Model back to DTO
            var typeDTO = new CharactersTypeDTOs
            {
                Id = typeDomainModel.Id,
                Name = typeDomainModel.Name,
                TypeImageIRL = typeDomainModel.TypeImageIRL
            };

            return CreatedAtAction(nameof(GetById), new { id = typeDTO.Id }, typeDTO);
        }

        // UPDATE A SINGLE TYPE
        // UPDATE: // https://localhost:7060/api/type/{id}
        [HttpPut]
        [Route("{id:Guid}")]
        public IActionResult UpdateType([FromRoute] Guid id, UpdateCharactersTypeDTOs updateCharactersTypeDTOs)
        { //add domain -> dto and dto -> domain
            var typeDomain = dbContext.CharactersTypes.FirstOrDefault(x => x.Id == id);
            
            // Get Type Domain Model from Database
            if (typeDomain == null)
            {
                return NotFound();
            }

            // Use Domain Model to update Type

            typeDomain.Name = updateCharactersTypeDTOs.Name;
            typeDomain.TypeImageIRL = updateCharactersTypeDTOs.TypeImageIRL;

            dbContext.SaveChanges();
            return Ok(typeDomain);
        }

        // DELETE A SINGLE TYPE
        // DELETE: // https://localhost:7060/api/type/{id}
        [HttpDelete]
        [Route("{id:Guid}")]
        public IActionResult DeleteType([FromRoute] Guid id)
        { 
            var type = dbContext.CharactersTypes.FirstOrDefault(x => x.Id == id);

            if (type == null)
            {
                return NotFound();
            }
            dbContext.CharactersTypes.Remove(type);

            dbContext.SaveChanges();
            return Ok();
        }

    }
}
