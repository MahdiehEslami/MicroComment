using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface ICommentRepository
    {
        List<Comment> GetAll();
        List<Comment> GetActived(int newsId);
        List<Comment> GetNonActived(int newsId);
        Comment GetById(int commentId);
        Comment Add(Comment comment);
        Comment Update(int commentId, Comment comment);
        void Delete(int commentId);


    }
}
