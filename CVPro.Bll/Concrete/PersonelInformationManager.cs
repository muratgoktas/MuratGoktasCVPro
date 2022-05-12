using CVPro.Dal.Abstract;
using CVPro.Entities;
using CVPro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVPro.Bll.Concrete
{
    public class PersonelInformationManager : IPersonalInformationService
    {
        private IPersonelInformationDal _personelInformationDal;
        public PersonelInformationManager(IPersonelInformationDal personelInformationDal)
        {
            _personelInformationDal = personelInformationDal;
        }
        public void Add(PersonInformation person)
        {
            _personelInformationDal.Add(person);
        }

        public void Delete(int id)
        {
            _personelInformationDal.Delete(id);
        }

        public PersonInformation Get(int id)
        {
            return _personelInformationDal.Get(id);
        }

        public List<PersonInformation> GetAll()
        {
            return _personelInformationDal.GetAll();
        }

        public void Update(PersonInformation person)
        {
            _personelInformationDal.Update(person);
        }
    }
}
