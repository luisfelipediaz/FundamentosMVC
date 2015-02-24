using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosMVC.Models
{
    public class Artista
    {
        public int ArtistaID { get; set; }

        public string Nombre { get; set; }

        public List<Album> Albums { get; set; }
    }
}
