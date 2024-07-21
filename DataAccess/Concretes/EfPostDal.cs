using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.RateLimiting;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfPostDal : EfEntityRepositoryBase<Post, SocialMediaContext>, IPostDal
    {
    }
}
