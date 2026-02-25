using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevForum.Domain.Entities
{
    public class Topic : BaseEntity
    {
        public int Id { get; private set; }

        public string Title { get; private set; } = null!;
        public string Slug { get; private set; } = null!;
        public string Content { get; private set; } = null!;

        public int ViewCount { get; private set; }
        public bool IsLocked { get; private set; }
        public bool IsPinned { get; private set; }

        // FK
        public string UserId { get; private set; } = null!;
        public int CategoryId { get; private set; }

        // Navigation
        public ApplicationUser User { get; set; } = null!;
        public Category Category { get; set; } = null!;
        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public ICollection<TopicTag> TopicTags { get; set; } = new List<TopicTag>();

        private Topic() { }

        public Topic(string title, string slug, string content, string userId, int categoryId)
        {
            Title = title;
            Slug = slug;
            Content = content;
            UserId = userId;
            CategoryId = categoryId;
        }

        public void IncrementView() => ViewCount++;
        public void Lock() => IsLocked = true;
        public void Unlock() => IsLocked = false;
    }
}
