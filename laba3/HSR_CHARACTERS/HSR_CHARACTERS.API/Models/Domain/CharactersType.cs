namespace HSR_CHARACTERS.API.Models.Domain
{
    public class CharactersType
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        //public List<CharactersInformation> CharacterInformation { get; } = [];

        public string? TypeImageIRL { get; set; }
    }
}
