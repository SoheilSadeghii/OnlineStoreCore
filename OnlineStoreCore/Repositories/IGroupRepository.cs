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
        public IEnumerable<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ShowGroupViewModel> GetGroupForShow()
        {
            throw new NotImplementedException();
        }
    }
}
