using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface ICommentService
    {
        List<Comment> GetActived(string newsId);
        List<Comment> GetNonActived(string newsId);
        void AddCheck(string newsId,Comment comment);
    }
}
