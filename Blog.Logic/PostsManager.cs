using Microsoft.EntityFrameworkCore;
using Blog.DataProvider;
using Blog.DataProvider.Models;
using Blog.ViewModels.Blog;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Logic
{
    public class PostsManager : IPostsManager
    {
        private BlogDbContext _db;

        public PostsManager(BlogDbContext context)
        {
            _db = context;
        }

        public List<PostViewModel> GetPosts(string userId)
        {
            var posts = _db.Posts.AsNoTracking().ToList();

            var result = new List<PostViewModel>();

            foreach (Post o in posts)
            {
                result.Add(new PostViewModel
                {
                    Id = o.Id,
                    Author = o.UserId, // add method to get user by Id
                    Title = o.Title,
                    Text = o.Text
                });
            }

            return result;
        }
    }
}