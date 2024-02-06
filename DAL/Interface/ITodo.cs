using DAL.Data;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface ITodo
    {

        Task<List<Todo>> getarrTodoes();

        Task<bool> AddToDo(Todo todo);
        Task<bool> DeleteToDo(int Id);
        Task<bool> PutToDo(Todo todo);

    }
}
