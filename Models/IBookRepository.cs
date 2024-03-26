namespace BookStoreHammondMission11Take2.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
