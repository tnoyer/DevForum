using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevForum.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string? Bio { get; set; }

        public bool IsBanned { get; private set; }

        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;

        public void Ban()
        {
            IsBanned = true;
        }

        public void Unban()
        {
            IsBanned = false;
        }

        // Navigation
        public ICollection<Topic> Topics { get; set; } = new List<Topic>();
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
