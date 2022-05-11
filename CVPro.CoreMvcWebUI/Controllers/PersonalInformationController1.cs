using CVPro.Bll.Concrete;
using CVPro.Dal.Concrete.EntityFramework;
using CVPro.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVPro.CoreMvcWebUI.Controllers
{

   
    public class PersonalInformationController1 : Controller
    {
        PersonelInformationManager _personelManager = new PersonelInformationManager(new EfPersonalDal());
        public ViewResult Index()
        {
            List<PersonInformation> person = _personelManager.GetAll();
            return View(person);
        }

    }
}
