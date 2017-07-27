
namespace SimApi.Data.Entities
{
    public class HighScore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int GameId { get; set; }
        public virtual Game Game { get; set; }
    }
}