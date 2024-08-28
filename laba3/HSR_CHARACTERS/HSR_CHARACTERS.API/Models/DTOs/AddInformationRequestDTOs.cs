using HSR_CHARACTERS.API.Models.Domain;
using System.Numerics;


namespace HSR_CHARACTERS.API.Models.DTOs
{
    public class AddInformationRequestDTOs
    {

        public string Name { get; set; }

        public string? SecondName { get; set; }

        public string? CharacterImageIRL { get; set; }

        //public CharactersType CharactersType { get; set; }

        //public CharactersPath CharactersPath { get; set; }

        public string CharactersType { get; set; }

        public string CharactersPath { get; set; }
    }
}
