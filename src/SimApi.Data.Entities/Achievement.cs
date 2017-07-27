using System.Collections.Generic;

namespace SimApi.Data.Entities
{
    public class Achievement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public bool Disabled { get; set; }
        public int GameId { get; set; }
        public virtual Game Game { get; set; }

        public virtual ICollection<PlayerAchievement> PlayerAchievements { get; set; }
        public virtual ICollection<PlayerAchievement> PlayerHighScores { get; set; }
    }
}