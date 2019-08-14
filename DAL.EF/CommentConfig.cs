using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EF
{
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(c => c.Text).HasMaxLength(1000).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(256);
            builder.Property(c => c.FullName).HasMaxLength(50);

        }
    }
}
