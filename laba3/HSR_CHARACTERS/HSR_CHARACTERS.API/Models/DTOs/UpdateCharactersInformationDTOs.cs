using HSR_CHARACTERS.API.Models.Domain;

namespace HSR_CHARACTERS.API.Models.DTOs
{
    public class UpdateCharactersInformationDTOs
    {

        public string Name { get; set; }

        public string? SecondName { get; set; }

        //public CharactersType CharactersType { get; set; }

        //public CharactersPath CharactersPath { get; set; }

        public string CharactersType { get; set; }

        public string CharactersPath { get; set; }
        
    }
}
