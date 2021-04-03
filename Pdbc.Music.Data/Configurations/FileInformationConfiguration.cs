using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pdbc.Music.Domain.Model;
using Pdbc.Music.Domain.Validation;

namespace Pdbc.Music.Data.Configurations
{
    internal class FileInformationConfiguration : AuditableIdentifiableMapping<FileInformation>
    {
        public override void Configure(EntityTypeBuilder<FileInformation> builder)
        {
            base.Configure(builder);

            builder.ToTable("FileInformations");
        }
    }
}