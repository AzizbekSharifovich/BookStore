using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Books.Core.Configurations;
public class BookSeriesConfiguration : IEntityTypeConfiguration<BookSeries>
{
    public void Configure (EntityTypeBuilder<>)
}

