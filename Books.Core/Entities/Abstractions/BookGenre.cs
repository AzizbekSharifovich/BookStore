namespace Books.Core.Entities.Abstractions;
public class BookGenre
{
    public int BookId { get; set; }
    public virtual Book? Book { get; set; }
}

