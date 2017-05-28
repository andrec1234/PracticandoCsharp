using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FronEnd.Controllers
{
    public class Book
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string nombre { get; set; }
    }
}