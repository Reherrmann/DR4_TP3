using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Amigo
    {
        public int AmigoId { get; set; }
        public string FName { get; set;}   
        public string LName { get; set;}
        public string Email { get; set;}
        public int Phone { get; set;}
        public int Niver { get; set;}

    }
}