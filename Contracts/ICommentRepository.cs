using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contracts
{
    public interface ICommentRepository
    {
        IQueryable<Comment> GetAll();
        Comment GetById(int commentId);
        Comment AddComment(News news, Comment comment);
        void Update(int commentId, Comment comment);
        void Delete(int commentId);


    }
}
