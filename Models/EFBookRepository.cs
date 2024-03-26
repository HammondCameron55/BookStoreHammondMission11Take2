namespace BookStoreHammondMission11Take2.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookstoreContext _context;

        public EFBookRepository(BookstoreContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
