using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevForum.Domain.Entities
{
    public class Post : BaseEntity
    {
        public int Id { get; private set; }

        public string Content { get; private set; } = null!;

        public string UserId { get; private set; } = null!;
        public int TopicId { get; private set; }

        public ApplicationUser User { get; set; } = null!;
        public Topic Topic { get; set; } = null!;

        public ICollection<PostLike> Likes { get; set; } = new List<PostLike>();
        public ICollection<Report> Reports { get; set; } = new List<Report>();

        private Post() { }

        public Post(string content, string userId, int topicId)
        {
            Content = content;
            UserId = userId;
            TopicId = topicId;
        }
    }
}
