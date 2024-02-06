using DAL.Data;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IUser
    {
        //זה מה שהיה מראש 
        //Task<List<User>> getarrUseres();
        //Task<bool> AddUser(Todo todo);
        //Task<bool> DeleteUser(int Id);
        //Task<bool> PutUser(Todo todo);
        //כאן שינתי
        Task<List<User>> getarrUseres();
        Task<bool> AddUser(User user);
        Task<bool> DeleteUser(int Id);
        Task<bool> PutUser(User user);



    }
}
