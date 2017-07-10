using AutoMapper;
using BloggerDotNet.Api.Models;
using BloggerDotNet.Core.Interfaces;
using BloggerDotNet.Core.Objects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BloggerDotNet.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;


        public PostController(IPostService postService, IMapper mapper)
        {
            _postService = postService ?? throw new ArgumentNullException();
            _mapper = mapper ?? throw new ArgumentNullException();
        }

        [HttpPost]
        public async Task<PostModel> CreatePost([FromBody]PostModel model)
        {
            var result = await _postService.CreatePost(_mapper.Map<Post>(model));
            return _mapper.Map<PostModel>(result);
        }

        [HttpGet]
        public async Task<List<PostModel>> GetAllPublishedPosts()
        {
            var result = await _postService.GetAllPosts();
            return _mapper.Map<List<PostModel>>(result);
        }

    }
}
