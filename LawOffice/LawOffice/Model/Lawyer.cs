using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace LawOffice
{
    public class Lawyer
    {
        public int LawyerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
