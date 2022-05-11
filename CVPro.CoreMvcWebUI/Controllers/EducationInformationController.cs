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
    public class EducationInformationController : Controller
    {
        EducationInformationManager _educationManager = new EducationInformationManager(new EfEducationDal());
        public ViewResult Index()
        {
            List<EducationInformation> education= _educationManager.GetAll();
            return View(education);
        }
    }
}
