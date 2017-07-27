
using System;

namespace SimApi.Data.Entities
{
    public class PlayerAchievement
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public DateTime AchievedOn { get; set; }
        public int PlayerId { get; set; }
        public int AchievementId { get; set; }
        public virtual Player Player { get; set; }
        public virtual Achievement Achievement { get; set; }
    }
}