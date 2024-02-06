using DAL.Data;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IPost
    {
        //Task<List<PostData>> getarrPostes();
        //Task<bool> AddPost(PostData post);
        //Task<bool> DeletePost(int Id);
        //Task<bool> PutPost(PostData post);
        //מכאן שינוי
        Task<List<Post>> getarrPostes();
        Task<bool> AddPost(Post post);
        Task<bool> DeletePost(int Id);
        Task<bool> PutPost(Post post);


    }
}
