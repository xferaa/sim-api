using System.Collections.Generic;

namespace SimApi.Data.Entities
{
    public class Publisher
    {
        public int Id { get; set; }
        public string PublisherName { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}