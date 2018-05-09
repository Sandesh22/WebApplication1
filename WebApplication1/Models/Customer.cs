using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string  Name { get; set; }
        public bool IsSubscribedToNewLetter { get; set; }
        public MemberShipType MemberShipType { get; set; }
        public byte MemberShipTypeId { get; set; }
    }
}   