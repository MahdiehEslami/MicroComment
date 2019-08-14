using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationServices
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository commentRepo;
        private readonly INewsRepository newsRepo;

        public CommentService(ICommentRepository commentRepository,INewsRepository newsRepository)
        {
            commentRepo = commentRepository;
            newsRepo = newsRepository;
        }
        public void AddCheck(string newsId, Comment comment)
        {
            if (newsRepo.GetByNewsAppRef(newsId)!=null)
            {
                var oldNews = newsRepo.GetByNewsAppRef(newsId);
                commentRepo.AddComment(oldNews, comment); 
            }
            else
            {
                News news = new News()
                {
                    NewsAppRef = newsId
                };
                newsRepo.AddNews(news);
                commentRepo.AddComment(news, comment);
                
            }
        }

        public List<Comment> GetActived(string newsId)
        {
            IEnumerable<Comment> result = commentRepo.GetAll();

           return result.Where(c => c.Status == true).ToList();
        }

        public List<Comment> GetNonActived(string newsId)
        {
            throw new NotImplementedException();
        }
    }
}
