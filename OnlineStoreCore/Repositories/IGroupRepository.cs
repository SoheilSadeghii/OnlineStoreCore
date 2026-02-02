using OnlineStoreCore.Data;
using OnlineStoreCore.Models;

namespace OnlineStoreCore.Repositories
{
    public interface IGroupRepository
    {
        public IEnumerable<Category> GetAllCategories();
        public IEnumerable<ShowGroupViewModel> GetGroupForShow();
    }

    public class GroupRepository : IGroupRepository
    {
        private OnlineStoreCoreContext _context;
        public GroupRepository(OnlineStoreCoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShowGroupViewModel> GetGroupForShow()
        {
            return _context.Categories
                .Select(c => new ShowGroupViewModel
                {
                    GroupId = c.Id,
                    Name = c.Name,
                    ProductCount = _context.CategoryToProducts.Count(g => g.CategoryId == c.Id)
                }).ToList();
        }
    }
}
