using CVPro.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVPro.Entities
{
    public class EducationInformation:IEntity
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string EducationName { get; set; }
        public string EducationType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Graduate { get; set; }
        public double Degree { get; set; }

    }
}
