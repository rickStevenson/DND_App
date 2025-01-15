namespace DND_App.Web.Models.Domain
{
    public class Skill
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; }
        public string Description { get; set; }
        public string AlignedAttribute { get; set; }
    }
}
