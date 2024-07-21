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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public Result Add(Comment comment)
        {
            _commentDal.Add(comment);
            return new SuccessResult();
        }

        public Result Delete(Comment comment)
        {
            _commentDal.Delete(comment);
            return new SuccessResult();
        }

        public IDataResult<List<Comment>> GetAll()
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll());
        }

        public IDataResult<List<Comment>> GetByPostId(int postId)
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll(l=>l.PostId == postId)); 
        }

        //public IDataResult<List<CommentDetailDto>> GetCommentDetail()
        //{
        //    return new SuccessDataResult<List<CommentDetailDto>>(_commentDal.GetCommentDetail());
        //}
    }
}
