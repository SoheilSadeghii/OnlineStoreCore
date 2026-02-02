using OnlineStoreCore.Models;

namespace OnlineStoreCore.Repositories
{
    public interface IGroupRepository
    {
        public IEnumerable<Category> GetAllCategories();
        public IEnumerable<CategoryToProduct> GetGroupForShow();
    }

    public class GroupRepository : IGroupRepository
    {
        public IEnumerable<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryToProduct> GetGroupForShow()
        {
            throw new NotImplementedException();
        }
    }
}
