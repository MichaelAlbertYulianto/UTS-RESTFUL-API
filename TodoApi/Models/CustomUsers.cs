using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi
{
    public class CustomUsers
    {
        public List<UserPost> userposts { get; set; }

        public CustomUsers(List<Users> users, List<Posts> posts)
        {
            userposts = new List<UserPost>();

            foreach (var user in users)
            {
                var userPost = new UserPost
                {
                    id = user.id,
                    name = user.name,
                    email = user.email,
                    posts = new List<Posts>()
                };

                foreach (var post in posts)
                {
                    if (post.user_id == user.id)
                    {
                        userPost.posts.Add(post);
                    }
                }

                userposts.Add(userPost);
            }
        }
    }

    public class UserPost
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public List<Posts> posts { get; set; }
    }
}
