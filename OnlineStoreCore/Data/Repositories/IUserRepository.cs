using OnlineStoreCore.Models;

namespace OnlineStoreCore.Data.Repositories
{
    public interface IUserRepository
    {
        void AddUser(User user);
        bool IsExistUserByEmail(string email);
    }

    public class UserRepository : IUserRepository
    {
        private OnlineStoreCoreContext _context;
        public UserRepository(OnlineStoreCoreContext context)
        {
            _context = context;
        }
        public void AddUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }

        public bool IsExistUserByEmail(string email)
        {
            return _context.Users.Any(e => e.Email == email);
        }
    }
}
