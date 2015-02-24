using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace FundamentosMVC.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public int AlbumID { get; set; }

        public Album Album { get; set; }

        public string Contents { get; set; }

        [Required()]
        [DataType(DataType.EmailAddress)]
        public string ReviewerEmail { get; set; }
    }
}
