using HSR_CHARACTERS.API.Models.Domain;

namespace HSR_CHARACTERS.API.Models.DTOs
{
    public class CharactersInformationDTOs
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string? SecondName { get; set; }

        public string? CharacterImageIRL { get; set; }

        public Guid TypeId { get; set; }

        public Guid PathId { get; set; }

        //public CharactersType CharactersType { get; set; }

        //public CharactersPath CharactersPath { get; set; }

        public string CharactersType { get; set; }

        public string CharactersPath { get; set; }
    }
}
