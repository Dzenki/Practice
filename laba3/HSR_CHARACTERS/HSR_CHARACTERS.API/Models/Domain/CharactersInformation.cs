using System.ComponentModel.DataAnnotations.Schema;

namespace HSR_CHARACTERS.API.Models.Domain
{
    public class CharactersInformation
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string? SecondName { get; set; }

        public string? CharacterImageIRL { get; set; }

        [ForeignKey("CharactersType")]
        public int TypeId { get; set; }
        [ForeignKey("CharactersPath")]
        public int PathId { get; set; } 

        public string CharactersTypes { get; set; }//можно поменять на string

        public string CharactersPaths { get; set; }
    }
}
