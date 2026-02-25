using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevForum.Domain.Entities
{
    public class Report : BaseEntity
    {
        public int Id { get; private set; }

        public int PostId { get; private set; }
        public string UserId { get; private set; } = null!;

        public string Reason { get; private set; } = null!;
        public bool IsResolved { get; private set; }

        public Post Post { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;

        private Report() { }

        public Report(int postId, string userId, string reason)
        {
            PostId = postId;
            UserId = userId;
            Reason = reason;
        }

        public void Resolve() => IsResolved = true;
    }
}
