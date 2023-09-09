using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Follower : BaseEntity
    {
        public User User { get; set; }
        public Guid UserId { get; set; }
        public User FollowingUser { get; set; }
    }
}
