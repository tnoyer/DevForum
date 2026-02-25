using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevForum.Domain.Entities
{
    public class Tag
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string Slug { get; private set; } = null!;

        public ICollection<TopicTag> TopicTags { get; set; } = new List<TopicTag>();

        private Tag() { }

        public Tag(string name, string slug)
        {
            Name = name;
            Slug = slug;
        }
    }
}
