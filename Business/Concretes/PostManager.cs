using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class PostManager : IPostService
    {
        IPostDal _postDal;
        ILikeService _likeService;
        ICommentService _commentService;

        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }

        public Result Add(Post post)
        {
            _postDal.Add(post);
            return new SuccessResult();
        }

        public Result Delete(Post post)
        {
            _postDal.Delete(post);
            return new SuccessResult();
        }

        public IDataResult<List<Post>> GetAll()
        {
            return new SuccessDataResult<List<Post>>(_postDal.GetAll());
        }

        //public IDataResult<List<PostDetailDto>> GetAllPostDetail()
        //{
        //    return new SuccessDataResult<List<PostDetailDto>>(_postDal.GetPostDetail());
        //}

        public IDataResult<Post> GetById(int id)
        {
            return new SuccessDataResult<Post>(_postDal.Get(p=>p.PostId==id));
        }

        public Result Update(Post post)
        {
            _postDal.Update(post);
            return new SuccessResult(); 
        }
    }
}
