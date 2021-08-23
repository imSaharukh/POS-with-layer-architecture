using Dapper;
using SuperShop.Data;
using SuperShop.Entity;
using System.Collections.Generic;
using System.Linq;

namespace SuperShop.Repository
{
    public class UserRepository
    {
        public User VerifyUser(string username,string password) 
        {
            var result = DataAccess.sqlcon.Query<User, UserRole, User>("select * from users as u join userRoles as r on u.roleID = r.roleID WHERE  username = @username and password = @password;", (user, role) => { user.userRole = role; return user; }, new { username, password }, splitOn: "roleID").Distinct()
                .ToList();

            if ( result.Count < 1 || result == null)
            {
                return null;
            }
            return result[0];
        }

        public List<User> GetAll(bool isSellerOnly=false) {


            var result = DataAccess.sqlcon.Query<User, UserRole, User>(@"select * from users u inner join 
                        userRoles r on u.roleID = r.roleID " + (isSellerOnly ? "where u.roleID=3 and r.roleID=3" : ""),
                        (user, role) => { user.userRole = role; return user; }, splitOn: "roleID").Distinct()
        .ToList();
        return result;
        }

        public List<User> SearchByUsername(string search, bool isSellerOnly = false)
        {
            search = "%"+  search + "%";

            var result = DataAccess.sqlcon.Query<User, UserRole, User>("select * from users u inner join userRoles r on u.roleID = r.roleID where username like @search" + (isSellerOnly ? " and (u.roleID=3 and r.roleID=3)" : ""), (user, role) => { user.userRole = role; return user; }, new { search }, splitOn: "roleID").Distinct()
        .ToList();
            return result;
        }



        public int? CreateOne(User user)
        {


            var r = DataAccess.SelectQuery<User>("select * from users where username = @username", new { user.username });

            if (r.Count > 0)
            {
                return -1;
            }

            var role = user.userRole.RoleName;
            var id = DataAccess.SelectQuery<UserRole>("select * from userRoles where RoleName = @role",new {role})[0].roleID;


            var result = DataAccess.sqlcon.Execute(@"insert into users (username,password,roleID,firstName,lastName) values (@username,@password,@id,@firstName,@lastName);" , new { user.username,user.password, id, user.firstName,user.lastName});


            return result;
        }

        public List<UserRole> GetUserRoles()
        {
            var result = DataAccess.SelectQuery<UserRole>("select * from userRoles;");

            return result;
        }


        public int? UpdateOne(User user)
        {
            //var role = user.userRole.RoleName;
            //var id = DataAccess.SelectQuery<UserRole>("select * from userRoles where RoleName = @role", new { role })[0].roleID;


            var result = DataAccess.sqlcon.Execute(@"update users set password = @password,firstName = @firstName,lastName = @lastName where username = @username;", new { user.username, user.password, user.firstName, user.lastName });


            return result;
        }

        public List<User> GetAllSeller()
        {
             var result = DataAccess.SelectQuery<User>("select * from users where roleID = 3");
            return result;
        }



        public int? DeleteOne(string username)
        {
            //var role = user.userRole.RoleName;
            //var id = DataAccess.SelectQuery<UserRole>("select * from userRoles where RoleName = @role", new { role })[0].roleID;


            var result = DataAccess.sqlcon.Execute(@"delete from users where username = @username;", new { username});


            return result;
        }
    }

 
}
