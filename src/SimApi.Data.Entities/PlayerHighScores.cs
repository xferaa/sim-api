
using System;

namespace SimApi.Data.Entities
{
    public class PlayerHighScores
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public DateTime AchievedOn { get; set; }
        public int PlayerId { get; set; }
        public int HighScoreId { get; set; }
        public virtual Player Player { get; set; }
        public virtual HighScore HighScore { get; set; }
    }
}