using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FundamentosMVC.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        public string Titulo { get; set; }

        public Artista Artista { get; set; }

        public List<Review> Reviews { get; set; }

    }
}
