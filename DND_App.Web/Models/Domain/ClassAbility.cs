﻿namespace DND_App.Web.Models.Domain
{
    public class ClassAbility
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; }
        public string Description { get; set; }

        public int CharacterClassId { get; set; } // Foreign Key
        public CharacterClass CharacterClass { get; set; } // Navigation Property
    }
}

