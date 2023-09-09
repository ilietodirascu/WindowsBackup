using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Message : BaseEntity
    {
        public DateTimeOffset UpdatedOn { get; set; }
        public string Content { get; set; }
        public User Sender{ get; set; }
        public User Receiver { get; set; }
        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }
    }
}
