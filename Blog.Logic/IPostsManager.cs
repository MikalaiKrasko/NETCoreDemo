using Blog.ViewModels.Blog;
using System.Collections.Generic;

namespace Blog.Logic
{
    public interface IPostsManager
    {
        List<PostViewModel> GetPosts(string userId);
    }
}
