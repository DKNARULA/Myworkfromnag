using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Interfaces
{
    public interface ICommentFacade
    {

        Task<int> Comment(CommentDTO model);



    }
}
