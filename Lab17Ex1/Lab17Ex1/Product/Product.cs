using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Un produs este caracterizat de
• Id (unic)
• Nume : string
• Stoc: int
• Producator
• Categorie
• Eticheta*/

namespace Lab17Ex1.Product
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int ProducerId { get; set; }
        public Producer Produce { get; set; }
        public int LabelId { get; set; }
        public Label Labels { get; set; }
        public int CategoryId { get; set; }
        public Category Categories { get; set; }
    }
}
 