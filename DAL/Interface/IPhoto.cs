using DAL.Data;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IPhoto
    {

        Task<List<Photo>> getarrPhotos();
        Task<bool> AddPhoto(Photo photo);
        Task<bool> DeletePhoto(int Id);
        Task<bool> PutPhoto(Photo photo);
      

    }
}
