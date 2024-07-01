using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*• O categorie va fi caracterizata de:
• Id (unic)
• Nume : string
• Pictograma – sub forma unui sir de
caractere reprezentand url-ul imaginii
corespunzatoare
• NavigationProperty / FK- ce lipseste?*/

namespace Lab17Ex1.Category
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public List<Product> Products { get; set; }
    }
}
