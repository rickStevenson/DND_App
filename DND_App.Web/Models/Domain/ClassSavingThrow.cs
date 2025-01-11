namespace DND_App.Web.Models.Domain
{
    public class ClassSavingThrow
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; }

        public int CharacterClassId { get; set; } // Foreign Key
        public CharacterClass CharacterClass { get; set; } // Navigation Property
    }
}

