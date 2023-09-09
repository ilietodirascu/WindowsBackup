using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Friend : BaseEntity 
    {
        //the primarykey is the same as the BefriendedUserId
        public User User { get; set; }
        public Guid UserId { get; set; }
        public User BefriendedUser { get; set; }
    }
}
