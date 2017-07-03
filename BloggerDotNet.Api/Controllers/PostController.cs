using AutoMapper;
using BloggerDotNet.Api.Models;
using BloggerDotNet.Core.Interfaces;
using BloggerDotNet.Core.Objects;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BloggerDotNet.Api.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;

        public PostController(IPostService postService, IMapper mapper)
        {
            _postService = postService ?? throw new ArgumentNullException();
            _mapper = mapper ?? throw new ArgumentNullException();
        }

        public async Task<Post> CreatePost(PostModel model)
        {
            var post = _mapper.Map<Post>(model);
            var result = _postService.CreatePost(post);
            return _mapper.Map<PostModel>(result);
        }
    }
}
