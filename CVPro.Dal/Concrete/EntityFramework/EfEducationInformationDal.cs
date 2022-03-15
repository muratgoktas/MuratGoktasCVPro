using CVPro.Dal.Abstract;
using CVPro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVPro.Dal.Concrete.EntityFramework
{
    class EfEducationInformationDal : IEducationInformationDal
    {
        CVProContext _context = new CVProContext();
        public void Add(EducationInformation education)
        {
            _context.EducationInformations.Add(education);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            _context.EducationInformations.Remove(_context.EducationInformations.FirstOrDefault(p => p.Id == Id));
            _context.SaveChanges();
        }

        public EducationInformation Get(int Id)
        {
            // return _context.EducationInformations.Where(p => p.Id == Id).FirstOrDefault(); yerine yazdık
            return _context.EducationInformations.FirstOrDefault(p => p.Id == Id);
        }

        public List<EducationInformation> GetAll()
        {
           return _context.EducationInformations.ToList(); 
        }

        public void Update(EducationInformation education)
        {
            EducationInformation educationInformation = _context.EducationInformations.FirstOrDefault(p => p.Id == education.Id);
            educationInformation.EducationName = education.EducationName;
            educationInformation.EducationType = education.EducationType;
            educationInformation.EndDate = education.EndDate;
            educationInformation.Degree = education.Degree;
            educationInformation.Graduate = education.Graduate;
            educationInformation.PersonId = education.PersonId;
            educationInformation.StartDate = education.StartDate;
            _context.SaveChanges();

        }
    }
}

