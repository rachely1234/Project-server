using DAL.Interface;
using Models.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Dtos;






namespace DAL.Data
{
    public class PhotoData:IPhoto
    {
        private readonly IMapper _mapper;
        private readonly ProjectCotext _context;

       
        public PhotoData(ProjectCotext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public Task<bool> AddPhoto(Photo photo)
        {
            throw new NotImplementedException();
        }


        public Task<bool> DeletePhoto(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Photo>> getarrPhotos()
        {
            throw new NotImplementedException();
            //var photoes = await _context.Photo.ToListAsync();
            //return photoes;

        }

        public Task<bool> PutPhoto(Photo photo)
        {
            throw new NotImplementedException();
        }

      
        
        
     


    }
}
