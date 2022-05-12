using CVPro.Entities;
using System.Data.Entity;

namespace CVPro.Dal.Concrete.EntityFramework
{
    public class CVProContext:DbContext
    {
        
        public DbSet<EducationInformation> EducationInformations { get; set; }
        public DbSet<PersonInformation> PersonalInformations { get; set; }

    }
}
