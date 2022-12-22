using Entity;
using System.Collections.Generic;

namespace ReadLater5.Controllers
{
    public interface IBookmarkService
    {
        Bookmark CreateBookmark(Bookmark bookmark);
        List<Bookmark> GetBookmark();
        Bookmark GetBookmark(int Id);
        Bookmark GetBookmark(string Name);
        void UpdateBookmark(Bookmark bookmark);
        void DeleteBookmark(Bookmark bookmark);
    }
}