using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocaMat.Classes
{
    public class OffresProduit
    {
        public int Id { get; set; }
        public int IdProduit { get; set; }
        [ForeignKey("IdProduit")]
        public virtual Produit Produit { get; set; }
        public int IdAgence { get; set; }
        [ForeignKey("IdAgence")]
        public virtual Agence Agence { get; set; }
        public int Quantite { get; set; }

    }
}
