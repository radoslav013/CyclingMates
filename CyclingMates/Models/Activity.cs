using System;
namespace CyclingMates.Models
{
	public class Activity
	{
        // by default this is the primary key
        public int ID { get; set; }

        public DateTime PublishedDateTime { get; set; }

        public string AuthorID { get; set; }

        public string Title { get; set; }

        public string? Description { get; set; }

        public string? Place { get; set; }

        public DateTime? Date { get; set; }

        public string? Image { get; set; }

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

        public Activity(Activity activity)
        {
            ID = activity.ID;
            PublishedDateTime = activity.PublishedDateTime;
            AuthorID = activity.AuthorID;
            Title = activity.Title;
            Description = activity.Description;
            Place = activity.Place;
            Date = activity.Date;
            Image = activity.Image;
        }
    }
}

