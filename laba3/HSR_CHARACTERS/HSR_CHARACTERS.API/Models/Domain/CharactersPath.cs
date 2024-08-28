namespace HSR_CHARACTERS.API.Models.Domain
{
    public class CharactersPath
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        //public List<CharactersInformation> CharacterInformation { get; } = [];

        public string? PathImageIRL { get; set; }
    }
}
