using System;
using System.Collections.Generic;
using ConsoleAppProject.Helpers;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Michael Kölling and David J. Barnes
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        private readonly List<Post> posts;
        
        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            posts = new List<Post>();
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        public void RemovePost(int id)
        {
            Post post = FindPost(id);

            if(post == null)
            {
                Console.WriteLine($"\n Post with ID: {id} does not exist");
            }
            else
            {
                Console.WriteLine($"\n The following post {id} has been removed");

                posts.Remove(post);
            }
        }

        public Post FindPost(int id)
        {
            foreach(Post post in posts)
            {
                if(post.PostID == id)
                {
                    return post;
                }
            }

            return null;
        }

        public void AddACommentToAPost(int id, string comment)
        {

           Post post = FindPost(id);
           post.AddComment(comment);
        }
        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        ///

        public void LikeAPost(int id)
        {
            Post post = FindPost(id);
            post.Like();
        }

        public void UnlikePost(int id)
        {
            Post post = FindPost(id);
            post.Unlike();
        }

        public void Display()
        {
            // display all posts
            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine();   // empty line between posts
            }
        }
    }

}
