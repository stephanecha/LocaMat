using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMat.Classes
{
    class Location
    {
        public int Id { get; set; }
        [ForeignKey("IdProduit")]
        public int IdProduit { get; set; }
        [ForeignKey("IdAgence")]
        public int IdAgence { get; set; }
        public int IdClient { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int Quantite { get; set; }
        public decimal TotalFacture { get; set; }

    }
}
