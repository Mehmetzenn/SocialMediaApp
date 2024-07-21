using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICommentService
    {
        Result Add(Comment comment);
        Result Delete(Comment comment);
        IDataResult<List<Comment>> GetAll();
        IDataResult<List<Comment>> GetByPostId(int postId);
    }
}
