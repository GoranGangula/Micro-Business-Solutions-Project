using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawOffice
{
    public class Case
    {
        public int CaseId { get; set; }
        public string Name { get; set; }
        public string CaseCode { get; set; }

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        public string ClientNameSurname { get {return Client.Name + " " + Client.Surname; } }

        public virtual ICollection<UnderCase> UnderCases { get; set; }
    }
}
