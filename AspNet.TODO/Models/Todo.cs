using System;
namespace AspNet.TODO.Models
{
	public class Todo
	{
		public Todo()
		{
		}

        public int TodoID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime When { get; set; } 
    }
}

