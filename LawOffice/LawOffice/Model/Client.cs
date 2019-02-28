using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LawOffice
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public int LawyerId { get; set; }
        public virtual Lawyer Lawyer { get; set; }
        
        public string LawyerNameSurname { get { return Lawyer.Name + " " + Lawyer.Surname; } }

        public virtual ICollection<Case> Cases { get; set; }
    }
}
