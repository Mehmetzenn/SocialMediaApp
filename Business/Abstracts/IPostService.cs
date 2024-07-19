using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IPostService
    {
        IDataResult<List<Post>> GetAll();
        Result Add(Post post);
        Result Delete(Post post);
        Result Update(Post post);
        //IDataResult<List<PostDetailDto>> GetAllPostDetail();
        IDataResult<Post> GetById(int id);
    }
}
