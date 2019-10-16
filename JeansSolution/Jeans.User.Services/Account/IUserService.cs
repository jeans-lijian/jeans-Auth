using Jeans.User.Core.Domain.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeans.User.Services.Account
{
    public interface IUserService
    {
        Users GetUser(int id);

        Users GetUser(string empNo);

        List<Users> GetUsers(int pageIndex, int pageSize, out int total, string nameOrEmpNo);

        void AddUser(Users entity);

        void UpdateUser(Users entity);

        void DeleteUser(Users entity);
    }
}