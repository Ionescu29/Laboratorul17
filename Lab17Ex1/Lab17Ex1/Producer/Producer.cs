﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Producatorii vor fi caracterizati de
• Id(unic)
• Nume
• Adresa : string
• CUI : string
• NavigationProperty- ce lipseste?*/

namespace Lab17Ex1.Producer
{
    internal class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string CUI { get; set; }
        public List<Product> Products { get; set; }

    }
}
