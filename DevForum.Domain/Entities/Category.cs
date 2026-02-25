using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevForum.Domain.Entities
{
    public class Category : BaseEntity
    {
        public int Id { get; private set; }

        public string Name { get; private set; } = null!;
        public string Description { get; private set; } = null!;
        public string Slug { get; private set; } = null!;

        public ICollection<Topic> Topics { get; set; } = new List<Topic>();

        private Category() { } // EF

        public Category(string name, string description, string slug)
        {
            Name = name;
            Description = description;
            Slug = slug;
        }
    }
}
