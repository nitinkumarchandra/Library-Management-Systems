using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NitinChandraMVC.Models
{
    public class Books
    {
        [Key]
        public int  BookId { get; set; }
        [Required]
        public string Book_Name { get; set; }
        [Required]
        public string Author_Name { get; set; }
        [Required]
        public int Book_Price { get; set; }
    }
}