using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ILikeService
    {
        Result Add(Like like);
        Result Delete(Like like);
        IDataResult<List<Like>> GetAll();
        //IDataResult<List<LikeDetailDto>> GetLikeDetail();
    }
}
