using CVPro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVPro.Dal.Abstract
{
    public interface IPersonelInformationDal
    {
        List<PersonInformation> GetAll();

        PersonInformation Get(int id);

        void Add(PersonInformation person);
        void Delete(int id);
        void Update(PersonInformation person);
    }
}
