using System.ComponentModel.DataAnnotations;
using System;
using Entity;

namespace ReadLater5.Models
{
    public class BookmarkViewModel
    {
        public string URL{ get; set; }

        public string ID { get; set; }

        public string ShortDescription { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
