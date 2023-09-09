using System;
using System.Collections.Generic;

namespace Domain
{
    public class Question : BaseEntity
    {
        public User AskingUser { get; set; }
        public Guid AskingUserId { get; set; }
        public string  Content { get; set; } = string.Empty;
        public ICollection<Hashtag> Hastags { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
