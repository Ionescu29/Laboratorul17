using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Eticheta este caracterizata de :
• Id(unic)
• Cod de bare (sub forma unui Guid)
• Pret : double
• NavigationProperty / FK- ce lipseste?*/

namespace Lab17Ex1.Label
{
    internal class Label
    {
        public int Id { get; set; }
        public Guid Barcode { get; set; }
        public double Price { get; set; }
        public List<Product> Products { get; set; }
    }
}
