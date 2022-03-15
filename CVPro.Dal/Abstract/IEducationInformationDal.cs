
using CVPro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVPro.Dal.Abstract
{
    public interface IEducationInformationDal
    {
       
        List<EducationInformation> GetAll();
        EducationInformation Get(int Id);
        void Add(EducationInformation education);
        void Delete(int Id);
        void Update(EducationInformation education);

    }
}
