namespace DND_App.Web.Models.Domain
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Weight { get; set; }

        public int CharacterId { get; set; }
        public Character Character { get; set; }
    }
}
