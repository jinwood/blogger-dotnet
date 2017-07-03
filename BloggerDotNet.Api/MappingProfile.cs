using AutoMapper;
using BloggerDotNet.Api.Models;
using BloggerDotNet.Core.Objects;

namespace BloggerDotNet.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Post, PostModel>();
            CreateMap<PostModel, Post>();
        }
    }
}
