using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.EF
{
    public class EFNewsRepository : INewsRepository
    {
        private readonly CommentContext Context;

        public EFNewsRepository(CommentContext commentContext)
        {
            Context = commentContext;
        }

        public News AddNews(News news)
        {
            Context.News.Add(news);
            Context.SaveChanges();
            return news;
        }

        public News GetByNewsAppRef(string Id)
        {
           return Context.News.Where(c => c.NewsAppRef == Id).FirstOrDefault();
            
        }

    }
}
