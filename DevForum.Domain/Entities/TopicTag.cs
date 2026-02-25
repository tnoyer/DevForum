using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevForum.Domain.Entities
{
    public class TopicTag
    {
        public int TopicId { get; set; }
        public int TagId { get; set; }

        public Topic Topic { get; set; } = null!;
        public Tag Tag { get; set; } = null!;
    }
}
