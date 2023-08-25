//using FacadePattern.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace FacadePattern.FacadePattern
//{
//    public class CommentFacade : ICommentFacade
//    {
//        private readonly ICommentService _commentService;
//        public CommentFacade(ICommentService commentService)
//        {
//            _commentService = commentService;
//        }

//        public async Task<int> Comment(CommentDTO model)
//        {
//            var result = await _commentService.PostComment(model);
//            return result;
//        }
//    }

//    internal interface ICommentService
//    {
//        Task PostComment(CommentDTO model);
//    }
//}
