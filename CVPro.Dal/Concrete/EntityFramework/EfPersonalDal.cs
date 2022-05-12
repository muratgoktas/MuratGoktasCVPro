using CVPro.Dal.Abstract;
using CVPro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVPro.Dal.Concrete.EntityFramework
{
    public class EfPersonalDal : IPersonelInformationDal
    {
        CVProContext _context = new CVProContext();
        
        public void Add(PersonInformation person)
        {
            _context.PersonalInformations.Add(person);
            _context.SaveChanges();
        }


        public void Delete(int id)
        {
            _context.PersonalInformations.Remove(_context.PersonalInformations.FirstOrDefault(p => p.Id == id));
            _context.SaveChanges();
        }

        public PersonInformation Get(int id)
        {
            return _context.PersonalInformations.FirstOrDefault(p => p.Id == id);
        }

        public List<PersonInformation> GetAll()
        {
            return _context.PersonalInformations.ToList();
        }

        public void Update(PersonInformation person)
        {
            PersonInformation personInformation = _context.PersonalInformations.FirstOrDefault(p => p.Id == person.Id);
            personInformation.Name = person.Name;
            personInformation.LastName = person.LastName;
            personInformation.MiddleName = person.MiddleName;
            personInformation.MaritalStatus = person.MaritalStatus;
            personInformation.MilitaryEndDate = person.MilitaryEndDate;
            personInformation.MilitaryStatus = person.MilitaryStatus;
            personInformation.PhotoLink = person.PhotoLink;
            personInformation.BirthCity = person.BirthCity;
            personInformation.BirthDate = person.BirthDate;
            _context.SaveChanges();

        }
    }
}
