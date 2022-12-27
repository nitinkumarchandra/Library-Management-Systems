using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NitinChandraMVC.Models
{
    public class IssueBooks
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Your Id is Required:-")]
        public int StdId { get; set; }
        [Required(ErrorMessage = "Enter Your Name is Required:-")]
        public string StdName { get; set; }
        [Required(ErrorMessage = "Issue Date is Required:-")]
        public DateTime IssueDate{ get; set; }
        [Required(ErrorMessage = "Return Date is Required:-")]
        public DateTime ReturnDate { get; set; }
    }
}