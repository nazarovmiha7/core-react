using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class PostLiteViewModel
    {
        public int PostId { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public int CommentCount { get; set; }
    }

    public class Tag
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public int PostId { get; set; }
    }

    public class Page<T>
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public List<T> Records { get; set; }

        public Page()
        {
            Records = new List<T>();
        }

        public Page(IEnumerable<T> records)
        {
            Records = new List<T>(records);
        }
    }
}
