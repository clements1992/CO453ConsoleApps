using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {

        private NewsFeed news = new NewsFeed();

        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading(" Alex's Facebook Spin-off ");

            string[] choices = new string[]
            {
                "Post Message", "Post Image", "Display All Posts", "Display Posts by Author", "Display by Date",
                 "Display All Interacted-with Posts", "Remove a Post", "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: DisplayAll(); break;
                    case 4: DisplayFromUser(); break;
                    case 5: DisplayFromDate(); break;
                    case 6: DisplayInteractions(); break;
                    case 7: RemovePost(); break;
                    case 8: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }

        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($" Removing a Post: ");

            int id = (int)ConsoleHelper.InputNumber(" Please enter the post ID > ",
                                            1, Post.GetNumberOfPosts());
            news.RemovePost(id);
        }

        private void DisplayInteractions()
        {
            throw new NotImplementedException();
        }

        private void DisplayFromDate()
        {
            throw new NotImplementedException();
        }

        private void DisplayFromUser()
        {
            ConsoleHelper.OutputHeading(" View posts from a specific user: ");
            Console.WriteLine(" Which user do you want to see mentions from > ");
            string name = Console.ReadLine();
            if (name.Contains(name) == true)
            {
                Console.WriteLine("See below Posts by " + name);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("User not found");
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Displays all posts - completed
        /// </summary>
        private void DisplayAll()
        {
            ConsoleHelper.OutputHeading(" Display Feed: ");
            news.Display();
            Console.WriteLine();
        }

        /// <summary>
        /// Allows the user to post an image - completed
        /// </summary>
        private void PostImage()
        {
            ConsoleHelper.OutputTitle("Post an Image");

            Console.WriteLine("Please enter your Name > ");
            string author = Console.ReadLine();

            Console.WriteLine("Please enter your image filename > ");
            string filename = Console.ReadLine();

            Console.WriteLine("Please enter your image caption > ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            news.AddPhotoPost(post);

            ConsoleHelper.OutputTitle("You have posted this image");
            post.Display();
        }

        /// <summary>
        /// Allows the user to post a message - completed
        /// </summary>
        private void PostMessage()
        {
            ConsoleHelper.OutputHeading(" Post a message: ");

            string author = InputName();
            
            // Console.WriteLine("Enter your name > ");
            // string name = Console.ReadLine();

            Console.WriteLine("Whats on your mind > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            ConsoleHelper.OutputTitle("You have posted this message");
            post.Display();

        }

        /// <summary>
        /// Links to the post message method and gets the users name
        /// </summary>
        /// <returns></returns>
        public string InputName()
        {
            Console.WriteLine("Whats your name > ");
            string author = Console.ReadLine();

            return author;
        }
    }
}
