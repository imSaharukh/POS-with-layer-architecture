using SuperShop.Data;
using SuperShop.Entity;
using System.Collections.Generic;

namespace SuperShop.Repository
{
    public class UserRepository
    {
        public User VerifyUser(string username,string password) {

            var result = DataAccess.SelectQuery<User>("select * from users WHERE  username = @username and password = @password;", new { username, password });

            return result[0];
        }

        public List<User> GetAll() {
        
        var result = DataAccess.SelectQuery<User>("select * from users;");
        return result;
        }
    }
}
