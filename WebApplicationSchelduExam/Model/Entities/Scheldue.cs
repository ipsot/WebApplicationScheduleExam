using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationSchelduExam.Model.Entities
{
    public class Scheldue
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Date { get; set; }
        public int Mark { get; set; }

       
    }
}