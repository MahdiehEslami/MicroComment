using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.EF
{
    public class CommentRepository : ICommentRepository
    {
        private readonly CommentContext Context;

        public CommentRepository(CommentContext commentContext)
        {
            Context = commentContext;
        }
        
        public void Add(int newsId, Comment comment)
        {
            Context.Comments.Add(comment);
            News news = new News
            {
                CommentId=comment.CommentId,
                NewsId=newsId
            };
            Context.News.Add(news);
            Context.SaveChanges();
      
        }

        public void Delete(int commentId)
        {
            
            Context.Comments.Remove(GetById(commentId));
            var a = Context.News.Find(GetById(commentId));
            Context.News.Remove(a);


        }

        public List<Comment> GetActived(int newsId)
        {
            return Context.Comments.Where(c => c.Status == true).ToList();
        }

        public List<Comment> GetAll()
        {
            return Context.Comments.ToList();
        }

        public Comment GetById(int commentId)
        {
           return Context.Comments.Find(commentId);
        }

        public List<Comment> GetNonActived(int newsId)
        {
            return Context.Comments.Where(c => c.Status == false).ToList();
        }

        public void Update(int commentId, Comment comment)
        {
            Comment FindComment = GetById(commentId);
            FindComment.Status = comment.Status;
            Context.Comments.Update(FindComment);
            Context.SaveChanges();
           
        }
    }
}
