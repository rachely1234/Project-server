using DAL.Interface;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class UserData : IUser
    {
		private readonly IMapper _mapper;
		private readonly ProjectCotext _context;
        public UserData(ProjectCotext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public Task<bool> AddUser(User user)
        {
            var TodoFromModel = _mapper.Map<User>(user);
            _context.Add(TodoFromModel);
            var isOk = _context.SaveChanges() >= 0;
            return isOk;
        }

        public Task<bool> DeleteUser(int Id)
        {
            try
            {
                // Fetch the full Todo object using its ID
                var user = await _context.Todos.FindAsync(Id);

                if (user == null)
                {
                    return false; // Todo not found
                }

                _context.Remove(user);
                int affectedRows = await _context.SaveChangesAsync();

                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                return false;
            }
        }

        public async Task<List<User>> getarrUseres()
        {
            try
            {
                var users = await _context.Todos.ToListAsync();
                return users;
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                return null;
            }
        }

        public Task<bool> PutUser(User user)
        {
           
                try
                {
                    if (user == null)
                    {
                        return false; // Todo not found
                    }

                    _context.Update(user);  // Assuming todo is already a Todo instance
                    int affectedRows = await _context.SaveChangesAsync();

                    return affectedRows > 0;
                }
                catch (Exception ex)
                {
                    // Handle exceptions appropriately
                    return false;
                }
            }
       
        }
    }
}
