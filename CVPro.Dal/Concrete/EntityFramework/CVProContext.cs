using CVPro.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVPro.Dal.Concrete.EntityFramework
{
    public class CVProContext:DbContext
    {
        
        public DbSet<EducationInformation> EducationInformations { get; set; }

    }
}
