using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Comment : BaseEntity
    {
        public DateTime UpdatedOn { get; set; }
        public User Author { get; set; }
        public Guid AuthorId { get; set; }
        public string Content { get; set; } = string.Empty;
        public Question Question { get; set; }
        public Guid QuestionId { get; set; }
        public bool IsAnswer { get; set; }
        public ICollection<Upvote> Upvotes { get; set; }
    }
}
