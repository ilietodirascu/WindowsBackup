using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User : BaseEntity
    {
        public string DateOfBirth { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string AboutMe { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public ICollection<Message> Messages { get; set; }
        public ICollection<Question> QuestionsAsked { get; set; }
        public ICollection<Friend> Friends { get; set; }
        public ICollection<Follower> Followers { get; set; }
    }
}
