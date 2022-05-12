using CVPro.Bll.Concrete;
using CVPro.Dal.Concrete.EntityFramework;
using CVPro.Entities;
using CVPro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVPro.WpfLibrary.Concrete
{
    public class PersonalInformationService : IPersonalInformationService
    {
        PersonelInformationManager _personalManager =
            new PersonelInformationManager(new EfPersonalDal());
        public void Add(PersonInformation person)
        {
            _personalManager.Add(person);
        }

        public void Delete(int id)
        {
            _personalManager.Delete(id);
        }

        public PersonInformation Get(int id)
        {
           return  _personalManager.Get(id);
        }

        public List<PersonInformation> GetAll()
        {
            return _personalManager.GetAll();
        }

        public void Update(PersonInformation person)
        {
            _personalManager.Update(person);
        }
    }
}
