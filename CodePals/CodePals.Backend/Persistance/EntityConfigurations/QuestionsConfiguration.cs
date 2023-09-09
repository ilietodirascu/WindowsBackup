using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.EntityConfigurations
{
    public class QuestionsConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasOne(x => x.AskingUser).WithMany(x => x.QuestionsAsked);
            builder.HasMany(x => x.Comments).WithOne(x => x.Question);
            builder.HasMany(x => x.Hashtags).WithOne(x => x.Question);
        }
    }
}
