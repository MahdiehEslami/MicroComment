using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface INewsRepository
    {
        News AddNews(News news);
        News GetByNewsAppRef(string Id);
    
    }
}
