using BookStoreHammondMission11Take2.Models.ViewModels;

namespace BookStoreHammondMission11Take2.Models.ViewModels
{
    public class BookListViewModel
    {
        public IQueryable<Book> Books { get; set;}

        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
