using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfPostDal : EfEntityRepositoryBase<Post, SocialMediaContext>, IPostDal
    {                    
    }
}
