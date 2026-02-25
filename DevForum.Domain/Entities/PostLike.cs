using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevForum.Domain.Entities
{
    public class PostLike
    {
        public int Id { get; private set; }

        public int PostId { get; private set; }
        public string UserId { get; private set; } = null!;

        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;

        public Post Post { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;

        private PostLike() { }

        public PostLike(int postId, string userId)
        {
            PostId = postId;
            UserId = userId;
        }
    }
}
