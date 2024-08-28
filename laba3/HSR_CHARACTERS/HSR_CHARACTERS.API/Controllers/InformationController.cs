using HSR_CHARACTERS.API.Data;
using HSR_CHARACTERS.API.Models.Domain;
using HSR_CHARACTERS.API.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection.Metadata.Ecma335;

namespace HSR_CHARACTERS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationController : ControllerBase
    {
        private readonly HSR_CHARACTERSDbContext dbContext;

        public InformationController(HSR_CHARACTERSDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET ALL INFORMATION
        // GET: https://localhost:7060/api/information
        [HttpGet]
        public IActionResult GetAll()
        {
            var infosDomain = dbContext.CharactersInformations.ToList();

            var infosDTOs = new List<CharactersInformationDTOs>();

            foreach (var infoDomain in infosDomain) 
            {
                infosDTOs.Add(new CharactersInformationDTOs()
                {
                    Id = infoDomain.Id,
                    Name = infoDomain.Name,
                    SecondName = infoDomain.SecondName,
                    CharacterImageIRL = infoDomain.CharacterImageIRL,
                    CharactersType = infoDomain.CharactersTypes,
                    CharactersPath = infoDomain.CharactersPaths,
                });
            }

            return Ok(infosDTOs);
        }

        // GET SOME INFORMATION
        // GET: https://localhost:7060/api/information/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            var infoDomain = dbContext.CharactersInformations.FirstOrDefault(x => x.Id == id);
        
            if (infoDomain == null)
            {
                return NotFound();
            }

            var infoDTOs = new CharactersInformationDTOs
            {
                Id = infoDomain.Id,
                Name = infoDomain.Name,
                SecondName = infoDomain.SecondName,
                CharacterImageIRL = infoDomain.CharacterImageIRL,
                CharactersType = infoDomain.CharactersTypes,
                CharactersPath = infoDomain.CharactersPaths,
            };

            return Ok(infoDTOs);
        }

        // POST TO ADD INFORMATION
        // POST: https://localhost:7060/api/information/{id}
        [HttpPost]
        public IActionResult Create([FromBody] AddInformationRequestDTOs addInformationRequestDTOs)
        {
            var infoDomainModel = new CharactersInformation()
            {
                Name = addInformationRequestDTOs.Name,
                SecondName = addInformationRequestDTOs.SecondName,
                CharactersPaths = addInformationRequestDTOs.CharactersPath,
                CharactersTypes = addInformationRequestDTOs.CharactersType,
                CharacterImageIRL = addInformationRequestDTOs.CharacterImageIRL,
            };

            var pathDomainModdel = new CharactersPath() 
            {
                Name = addInformationRequestDTOs.CharactersPath,
            };

            var typeDomainModdel = new CharactersType()
            {
                Name = addInformationRequestDTOs.CharactersType,
            };

            //ДОДЕЛАТЬ ЛОГИКУ
            var infooftype = dbContext.CharactersTypes.FirstOrDefault(x => x.Name == addInformationRequestDTOs.CharactersType);

            if (infooftype == null)
            {
                var typeDomainModel = new CharactersType 
                {
                    Name = addInformationRequestDTOs.CharactersType,
                };
                dbContext.CharactersTypes.Add(typeDomainModel);
                dbContext.SaveChanges();

                var typeDTO = new CharactersTypeDTOs
                {
                    Id = typeDomainModel.Id,
                    Name = typeDomainModel.Name
                };

                CreatedAtAction(nameof(GetById), new {id = typeDTO.Id}, typeDTO);
            }

            var infoofpath = dbContext.CharactersPaths.FirstOrDefault(x => x.Name == addInformationRequestDTOs.CharactersPath);

            if (infoofpath == null)
            {
                var pathDomainModel = new CharactersPath
                {
                    Name = addInformationRequestDTOs.CharactersPath,
                };
                dbContext.CharactersPaths.Add(pathDomainModel);
                dbContext.SaveChanges();

                var pathDTO = new CharactersPathDTOs
                {
                    Id = pathDomainModel.Id,
                    Name = pathDomainModel.Name
                };

                CreatedAtAction(nameof(GetById), new { id = pathDTO.Id }, pathDTO);
            }

            dbContext.CharactersInformations.Add(infoDomainModel);
            dbContext.CharactersPaths.Add(pathDomainModdel);
            dbContext.CharactersTypes.Add(typeDomainModdel);
            dbContext.SaveChanges();

            return Ok(infoDomainModel);

        }



        // UPDATE SOME INFORMATION
        // UPDATE: https://localhost:7060/api/information/{id}
        [HttpPut]
        [Route("{id:Guid}")]
        public IActionResult UpdateInformation([FromRoute] Guid id, UpdateCharactersInformationDTOs updateCharactersInformationDTOs)
        {
            var infoDomain = dbContext.CharactersInformations.FirstOrDefault(x => x.Id == id);

            if (infoDomain == null)
            {
                return NotFound();
            }

            infoDomain.Name = updateCharactersInformationDTOs.Name;
            infoDomain.SecondName = updateCharactersInformationDTOs.SecondName;
            infoDomain.CharactersPaths = updateCharactersInformationDTOs.CharactersPath;
            infoDomain.CharactersTypes = updateCharactersInformationDTOs.CharactersType;



            //ДОДЕЛАТЬ ЛОГИКУ
            var infooftype = dbContext.CharactersTypes.FirstOrDefault(x => x.Name == updateCharactersInformationDTOs.CharactersType);

            if (infooftype == null)
            {
                var typeDomainModel = new CharactersType
                {
                    Name = updateCharactersInformationDTOs.CharactersType,
                };
                dbContext.CharactersTypes.Add(typeDomainModel);
                dbContext.SaveChanges();

                var typeDTO = new CharactersTypeDTOs
                {
                    Id = typeDomainModel.Id,
                    Name = typeDomainModel.Name
                };

                CreatedAtAction(nameof(GetById), new { id = typeDTO.Id }, typeDTO);
            }

            //else
            //{

            //}

            var infoofpath = dbContext.CharactersPaths.FirstOrDefault(x => x.Name == updateCharactersInformationDTOs.CharactersPath);

            if (infoofpath == null)
            {
                var pathDomainModel = new CharactersPath
                {
                    Name = updateCharactersInformationDTOs.CharactersPath,
                };
                dbContext.CharactersPaths.Add(pathDomainModel);
                dbContext.SaveChanges();

                var pathDTO = new CharactersPathDTOs
                {
                    Id = pathDomainModel.Id,
                    Name = pathDomainModel.Name
                };

                CreatedAtAction(nameof(GetById), new { id = pathDTO.Id }, pathDTO);
            }

            //else
            //{

            //}

            dbContext.SaveChanges();
            return Ok(infoDomain);
        }

        // DELETE SOME INFORMATION
        // DELETE: https://localhost:7060/api/information/{id}
        [HttpDelete]
        [Route("{id:Guid}")]
        public IActionResult DeletePath([FromRoute] Guid id)
        {
            var info = dbContext.CharactersInformations.FirstOrDefault(x => x.Id == id);

            if (info == null) 
            { 
                return NotFound();  
            }
            dbContext.CharactersInformations.Remove(info);

            dbContext.SaveChanges();
            return Ok();
        }

    }
}
