using System;
namespace CyclingMates.Models
{
	public class Activity
	{
        // by default this is the primary key
        public int ID { get; set; }

        public string Title { get; set; }

        public string AuthorID { get; set; }

        public Activity()
        {
            Title = "";
            AuthorID = "";
        }

        public Activity(string title, string authorID)
        {
            Title = title;
            AuthorID = authorID;
        }
    }
}

