﻿namespace DND_App.Web.Models.Domain
{
    public class Spell
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string School { get; set; } = string.Empty;
        public int Level { get; set; }
        public bool IsPrepared { get; set; } = false;
        public string CastingTime { get; set; } = string.Empty;
        public string SpellRange { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public bool RequiresConcentration { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<string> Components { get; set; } = new List<string>();
    }
}
