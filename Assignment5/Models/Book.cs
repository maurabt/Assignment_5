using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    //class for book entries
    public class Book
    {
        //making BookID public key
        [Key] 
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int ISBN { get; set; }
        public string Class { get; set; }
        public string Price { get; set; }


    }
}
