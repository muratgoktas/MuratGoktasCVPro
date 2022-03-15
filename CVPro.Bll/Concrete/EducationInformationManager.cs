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
    public class EducationInformationManager : IEducationInformationService
    {
        // eklenecekler
        // Validation
        // Expresion Handling
        // Security
        private IEducationInformationDal _educattionDal;
        public  EducationInformationManager(IEducationInformationDal educationDal)
        {
            _educattionDal = educationDal;
        }
        public void Add(EducationInformation education)
        {
            _educattionDal.Add(education);
        }

        public void Delete(int Id)
        {
            _educattionDal.Delete(Id);
        }

        public EducationInformation Get(int Id)
        {
           return  _educattionDal.Get(Id);
        }

        public List<EducationInformation> GetAll()
        {
            return _educattionDal.GetAll();
        }

        public void Update(EducationInformation education)
        {
            _educattionDal.Update(education);
        }
    }
}
