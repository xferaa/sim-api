using System.Collections.Generic;

namespace SimApi.Data.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ApiKey { get; set; }
        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }

        public virtual ICollection<Achievement> Achievements { get; set; }
        public virtual ICollection<HighScore> HighScores { get; set; }
    }
}