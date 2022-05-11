using CVPro.Bll.Concrete;
using CVPro.Entities;
using CVPro.Interfaces;
using CVPro.Dal.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CVPro.Dal.Abstract;

namespace CVPro.WpfLibrary.Concrete
{
    public class EducationInformationService : IEducationInformationService
    {
        //Instance Provider ile ezilecek
        
        EducationInformationManager _educationManager =
            new EducationInformationManager(new EfEducationDal());

        public void Add(EducationInformation education)
        {
            _educationManager.Add(education);
        }

        public void Delete(int Id)
        {
            _educationManager.Delete(Id);
        }

        public EducationInformation Get(int Id)
        {
            return _educationManager.Get(Id);
        }

        public List<EducationInformation> GetAll()
        {
            return _educationManager.GetAll();
        }

        public void Update(EducationInformation education)
        {
            _educationManager.Update(education);
        }
    }
}
