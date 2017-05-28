using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backend.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Año { get; set; }
    }
}