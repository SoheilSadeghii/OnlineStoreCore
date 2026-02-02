using OnlineStoreCore.Models;

namespace OnlineStoreCore.Repositories
{
    public interface IGroupRepository
    {
        public List<Category> GetAllCategories();
        public List<CategoryToProduct> GetGroupForShow();
    }

    public class GroupRepository : IGroupRepository
    {
        public List<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public List<CategoryToProduct> GetGroupForShow()
        {
            throw new NotImplementedException();
        }
    }
}
