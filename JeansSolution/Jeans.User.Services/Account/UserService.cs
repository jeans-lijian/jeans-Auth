using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jeans.User.Core.Domain.Account;
using Jeans.User.Data;

namespace Jeans.User.Services.Account
{
    public class UserService : IUserService
    {
        private readonly IRepository<Users> _userRepository;
        public UserService(IRepository<Users> userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(Users entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _userRepository.Insert(entity);
        }

        public void DeleteUser(Users entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _userRepository.Delete(entity);
        }

        public Users GetUser(int id)
        {
            return _userRepository.GetById(id);
        }

        public Users GetUser(string empNo)
        {
            if (string.IsNullOrWhiteSpace(empNo))
            {
                throw new ArgumentNullException(nameof(empNo));
            }

            Users entity = _userRepository.TableNoTracking.SingleOrDefault(user => user.EmpNo == empNo.Trim());

            return entity;
        }

        public List<Users> GetUsers(int pageIndex, int pageSize, out int total, string nameOrEmpNo)
        {
            var query = _userRepository.TableNoTracking;
            if (!string.IsNullOrWhiteSpace(nameOrEmpNo))
            {
                query = query.Where(user => user.EmpNo.Contains(nameOrEmpNo) || user.Name.Contains(nameOrEmpNo));
            }

            total = query.Count();

            query = query.OrderByDescending(order => order.ResignDate);
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);

            return query.ToList();
        }

        public void UpdateUser(Users entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _userRepository.Update(entity);
        }
    }
}
