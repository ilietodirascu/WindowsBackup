using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Upvote : BaseEntity
    {
        public Comment Comment { get; set; }
        public Guid CommentId { get; set; }
        public int Count { get; set; }
        public User UpvotingUser { get; set; }
        public Guid UpvotingUserId { get; set; }
    }
}
