using AutoMapper;
using DAL.Dtos;
using DAL.Interface;
using Microsoft.EntityFrameworkCore;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class TodoData:ITodo
    {
        private readonly IMapper _mapper;
        private readonly ProjectCotext _context;
        public TodoData(ProjectCotext context, IMapper mapper)
        {
           _context = context;
          _mapper = mapper;
        }

        public async Task<bool> AddToDo(Todo todo)
        {
            var TodoFromModel = _mapper.Map<Todo>(todo);
            _context.Add(TodoFromModel);
            var isOk = _context.SaveChanges()>=0;
            return isOk;
        }





        public async Task<bool> PutToDo(Todo todo)
        {
            try
            {
                if (todo == null)
                {
                    return false; // Todo not found
                }

                _context.Update(todo);  // Assuming todo is already a Todo instance
                int affectedRows = await _context.SaveChangesAsync();

                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                return false;
            }
        }

        public async Task<List<Todo>> getarrTodoes()
        {
            try
            {
                var todos = await _context.Todos.ToListAsync();
                return todos;
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                return null;
            }
        }

        public async Task<bool> DeleteToDo(int Id)
        {
            try
            {
                // Fetch the full Todo object using its ID
                var todo = await _context.Todos.FindAsync(Id);

                if (todo == null)
                {
                    return false; // Todo not found
                }

                _context.Remove(todo);
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
