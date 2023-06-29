using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackerAppDemo.Models
{
    public class Category
    {
        public string CategoryId { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Type { get; set; }

        [NotMapped]
        public string? iconTitle 
        { 
            get { return Icon + " " + Title; } 
        }
    }
}