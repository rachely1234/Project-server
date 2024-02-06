using AutoMapper;
using DAL.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
namespace DAL.Data
{
    public class PostData : IPost
    {
        private readonly IMapper _mapper;
        private readonly ProjectCotext _context;
        public PostData(ProjectCotext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<bool> AddPost(Post post)
        {
            var TodoFromModel = _mapper.Map<Post>(post);
            _context.Add(TodoFromModel);
            try
            {

            var isOk = _context.SaveChanges() >= 0;
            }catch(Exception e)
            {

            }
            return true;
        }

        public async Task<bool> DeletePost(int Id)

        {
            try
            {
                // Fetch the full Todo object using its ID
                var post = await _context.Posts.FindAsync(Id);

                if (post == null)
                {
                    return false; // Todo not found
                }

                _context.Remove(post);
                int affectedRows = await _context.SaveChangesAsync();

                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                return false;
            }
        }

        public async Task<List<Post>> getarrPostes()
        {
            try
            {
                var posts = await _context.Posts.ToListAsync();
                return posts;
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                return null;
            }
        }
      
            public async Task<bool> PutPost(Post post)
        {
                try
                {
                    if (post == null)
                    {
                        return false; // Todo not found
                    }

                    _context.Update(post);  // Assuming todo is already a Todo instance
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
    

