using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Student este caracterizat de
urmatoarele
• Nume
• Prenume
• Varsta
• Adresa
*/

namespace Lab17Ex2.Student
{
    internal class Student
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string AdressId { get; set; }
        public Adress Adresses { get; set; }
    }
}
