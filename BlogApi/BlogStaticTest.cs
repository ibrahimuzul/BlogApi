using BlogApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi
{
    public class BlogStaticTest
    {
        private static List<Blog> BlogList = new List<Blog>();
        private static long BlogId=1;

        public static List<Blog> GetBlogs()
        {
            if (BlogList.Count == 0)
            {
                BlogList.Add(new Blog() { id = 1, categories = "test 1", content = "content", title = "title 1" });
                BlogList.Add(new Blog() { id = 2, categories = "test 2", content = "content 2", title = "title 2" });
                BlogId = 3;
            }

            return BlogList;

        }

        public static void AddBlog(Blog blog)
        {
            if (blog.id == 0)
            {
                blog.id = BlogId;
                BlogId++;
            }
            BlogList.Add(blog);
        }

        public static Blog GetBlog(long id)
        {
            return BlogList.Where(x => x.id == id).FirstOrDefault();
        }

        public static long DeleteBlog(long id)
        {
            Blog blog = BlogList.Where(x => x.id == id).FirstOrDefault();

             BlogList.Remove(blog);

            return id;
        }
    }
}
