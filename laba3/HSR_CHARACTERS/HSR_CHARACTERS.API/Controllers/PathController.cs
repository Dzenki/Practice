using HSR_CHARACTERS.API.Data;
using HSR_CHARACTERS.API.Models.Domain;
using HSR_CHARACTERS.API.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HSR_CHARACTERS.API.Controllers
{
    // https://localhost:7060/api/path
    [Route("api/[controller]")]
    [ApiController]
    public class PathController : ControllerBase
    {
        private readonly HSR_CHARACTERSDbContext dbContext;

        public PathController(HSR_CHARACTERSDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET ALL PATHS
        // GET: https://localhost:7060/api/path
        [HttpGet]
        public IActionResult GetAll()
        {
            /*var paths = new List<CharactersPath>
            {
                new CharactersPath
                {
                    Id = Guid.NewGuid(),
                    Name = "Destruction",
                    PathImageIRL = "https://static.wikia.nocookie.net/houkai-star-rail/images/d/df/Path_Destruction.png/revision/latest?cb=20240417234659"
                },
                new CharactersPath
                {
                    Id = Guid.NewGuid(),
                    Name = "The Hunt",
                    PathImageIRL = "https://static.wikia.nocookie.net/houkai-star-rail/images/1/1c/Path_The_Hunt.png/revision/latest?cb=20240417235336"
                },
                new CharactersPath
                {
                    Id = Guid.NewGuid(),
                    Name = "Erudition",
                    PathImageIRL = "https://static.wikia.nocookie.net/houkai-star-rail/images/5/53/Path_Erudition.png/revision/latest?cb=20240417235548"
                },
                new CharactersPath
                {
                    Id = Guid.NewGuid(),
                    Name = "Harmony",
                    PathImageIRL = "https://static.wikia.nocookie.net/houkai-star-rail/images/7/7e/Path_Harmony.png/revision/latest?cb=20240417235441"
                },
                new CharactersPath
                {
                    Id = Guid.NewGuid(),
                    Name = "Nihility",
                    PathImageIRL = "https://static.wikia.nocookie.net/houkai-star-rail/images/4/45/Path_Nihility.png/revision/latest?cb=20240417235304"
                },
                new CharactersPath
                {
                    Id = Guid.NewGuid(),
                    Name = "Preservation",
                    PathImageIRL = "https://static.wikia.nocookie.net/houkai-star-rail/images/3/37/Path_Preservation.png/revision/latest?cb=20240417235425"
                },
                new CharactersPath
                {
                    Id = Guid.NewGuid(),
                    Name = "Abundance",
                    PathImageIRL = "https://static.wikia.nocookie.net/houkai-star-rail/images/9/94/Path_Abundance.png/revision/latest?cb=20240417235352"
                }
            };*/

            // Get Data from Database - Domain models

            var pathsDomain = dbContext.CharactersPaths.ToList();

            // Map Domain models to DTOs

            var pathsDTOs = new List<CharactersPathDTOs>();
            foreach (var pathDomain in pathsDomain)
            {
                pathsDTOs.Add(new CharactersPathDTOs()
                {
                    Id = pathDomain.Id,
                    Name = pathDomain.Name,
                    PathImageIRL = pathDomain.PathImageIRL
                });
            }

            // Return DTOs back to the client
            return Ok(pathsDTOs);
        }

        //GET SINGLE PATH (Get Path by ID)
        // GET: // https://localhost:7060/api/path/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            //var path = dbContext.CharactersPaths.Find(id);
            // Get Path Domain model from  Database 
            var pathDomain = dbContext.CharactersPaths.FirstOrDefault(x => x.Id == id);

            if (pathDomain == null)
            {
                return NotFound();
            }

            // Map/Convert Path Domain model to Path DTO
            var pathDTOs = new CharactersPathDTOs
            {
                Id = pathDomain.Id,
                Name = pathDomain.Name,
                PathImageIRL = pathDomain.PathImageIRL
            };

            // Return DTO back to client          
            return Ok(pathDTOs);
        }

        // POST To Create a New Path
        // POST: // https://localhost:7060/api/path/
        [HttpPost]
        public IActionResult Create([FromBody] AddPathRequestDTOs addPathRequestDTOs)
        {
            // Map/Convert DTO to Domain model
            var pathDomainModel = new CharactersPath
            {
                Name = addPathRequestDTOs.Name,
                PathImageIRL = addPathRequestDTOs.PathImageIRL
            };

            //Use Domain Model to create Path
            dbContext.CharactersPaths.Add(pathDomainModel);
            dbContext.SaveChanges();

            // Map Domain Model back to DTO
            var pathDTO = new CharactersPathDTOs
            {
                Id = pathDomainModel.Id,
                Name = pathDomainModel.Name,
                PathImageIRL = pathDomainModel.PathImageIRL
            };
            return CreatedAtAction(nameof(GetById), new { id = pathDTO.Id }, pathDTO);
        }

        // UPDATE A SINGLE TYPE
        // UPDATE: // https://localhost:7060/api/path/{id}
        [HttpPut]
        [Route("{id:Guid}")]
        public IActionResult UpdatePath([FromRoute] Guid id, UpdateCharactersPathDTOs updateCharactersPathDTOs)
        {
            var pathDomain = dbContext.CharactersPaths.FirstOrDefault(x => x.Id == id);

            // Get Path Domain Model from Database
            if (pathDomain == null)
            {
                return NotFound();
            }

            // Use Domain Model to update Path

            pathDomain.Name = updateCharactersPathDTOs.Name;
            pathDomain.PathImageIRL=updateCharactersPathDTOs.PathImageIRL;

            dbContext.SaveChanges();
            return Ok(pathDomain);
        }

        // DELETE A SINGLE PATH
        // DELETE: // https://localhost:7060/api/path/{id}
        [HttpDelete]
        [Route("{id:Guid}")]
        public IActionResult DeletePath([FromRoute] Guid id)
        {
            var path = dbContext.CharactersPaths.FirstOrDefault(x => x.Id == id);

            if (path == null)
            {
                return NotFound();
            }
            dbContext.CharactersPaths.Remove(path);

            dbContext.SaveChanges();
            return Ok();
        }
    }
}
