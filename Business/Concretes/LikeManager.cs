using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class LikeManager : ILikeService
    {
        ILikeDal _likeDal;

        public LikeManager(ILikeDal likeDal)
        {
            _likeDal = likeDal;
        }

        public Result Add(Like like)
        {
            _likeDal.Add(like);
            return new SuccessResult("Like attın");
        }

        public Result Delete(Like like)
        {
            _likeDal.Delete(like);
            return new SuccessResult("Like iptal edildi");
        }

        public IDataResult<List<Like>> GetAll()
        {
            return new SuccessDataResult<List<Like>>(_likeDal.GetAll());
        }

        //public IDataResult<List<LikeDetailDto>> GetLikeDetail()
        //{
        //    return new SuccessDataResult<List<LikeDetailDto>>(_likeDal.GetLikeDetail());
        //}
    }
}
