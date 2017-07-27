using System;
using System.Collections.Generic;

namespace SimApi.Data.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string ApiKey { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<PlayerAchievement> PlayerAchievements { get; set; }
        public virtual ICollection<PlayerHighScores> PlayerHighScores { get; set; }
    }
}