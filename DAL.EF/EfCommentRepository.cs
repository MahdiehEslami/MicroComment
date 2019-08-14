using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.EF
{
    public class EFCommentRepository : ICommentRepository
    {
        private readonly CommentContext Context;

        public EFCommentRepository(CommentContext commentContext)
        {
            Context = commentContext;
        }
        
        public Comment AddComment(News news,Comment comment)
        {
            news.Comments.Add(comment);
            Context.SaveChanges();
            return comment;
      
        }

        public void Delete(int commentId)
        {
            
            Context.Comments.Remove(GetById(commentId));
           // List<News> n=Context.News.Where(c => c.CommentId == commentId).ToList();
            //var a = Context.News.Find(GetById(commentId));
           // Context.News.Remove();
            Context.SaveChanges();


        }
        public IQueryable<Comment> GetAll()
        {
            return Context.Comments;
        }

        public Comment GetById(int commentId)
        {
           return Context.Comments.Find(commentId);
        }

        //public List<Comment> GetNonActived(int newsId)
        //{
        //    return Context.Comments.Where(c => c.Status == false).ToList();
        //}

        public void Update(int commentId, Comment comment)
        {
            Comment FindComment = GetById(commentId);
            FindComment.Status = comment.Status;
            Context.Comments.Update(FindComment);
            Context.SaveChanges();
           
        }
    }
}
