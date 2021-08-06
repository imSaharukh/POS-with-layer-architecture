using SuperShop.Data;
using SuperShop.Entity;
using System;

namespace SuperShop.Repository
{
    public class UserRepository
    {
        public bool VerifyUser(string username,string password) {

        var result =    DataAccess.SelectQuery<User>("select * from users WHERE  username = @username and password = @password",new { username,password});
        
        if(result.Count == 1)
            {
                return true;
            }
            return false;
        }
    }
}
