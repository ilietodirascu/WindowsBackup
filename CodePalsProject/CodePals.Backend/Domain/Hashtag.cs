using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Hashtag : BaseEntity
    {
        public string Name { get; set; }
        public int NrOfUses { get; set; }
        public User Creator { get; set; }
        public Guid CreatorId { get; set; }
        public Question Question { get; set; }
    }
}
