using SuperShop.Data;
using SuperShop.Entity;
using System.Collections.Generic;

namespace SuperShop.Repository
{
    public class UserRepository
    {
        public User VerifyUser(string username,string password) {

            var result = DataAccess.SelectQuery<User>("select * from users as u join userRoles as r on u.roleID = r.roleID WHERE  username = @username and password = @password;", new { username, password });
            if ( result.Count < 1 || result == null)
            {
                return null;
            }
            return result[0];
        }

        public List<User> GetAll() {
        
        var result = DataAccess.SelectQuery<User>("select * from users as u join userRoles as r on u.roleID = r.roleID;");
        return result;
        }
    }
}
