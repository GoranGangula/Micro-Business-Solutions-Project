using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawOffice
{
    public class UnderCase
    {
        public int UnderCaseId { get; set; }
        public string Name { get; set; }
        public string UnderCaseCode { get; set; }

        public int CaseId { get; set; }
        public virtual Case Case { get; set; }

        public string CaseName { get { return Case.Name; } }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
