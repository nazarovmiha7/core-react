using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Blog")]
    public class BlogController : Controller
    {
        [Route("page")]
        public async Task<Page<PostLiteViewModel>> GetPosts(int pageIndex, string tag)
        {
            return new Page<PostLiteViewModel>
            {
                Records = new List<PostLiteViewModel>()
                {
                    new PostLiteViewModel()
                    {
                        PostId = 1,
                        Header = "Header_1",
                        Body = "Body_1"
                    },
                    new PostLiteViewModel()
                    {
                        PostId = 2,
                        Header = "Header_2",
                        Body = "Body_2"
                    }
                }
            };
        }
    }
}