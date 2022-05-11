using CVPro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CVPro.Interfaces
{
    [ServiceContract]
    public interface IEducationInformationService
    {
        [OperationContract]
        List<EducationInformation> GetAll();
        [OperationContract]
        EducationInformation Get(int Id);

        [OperationContract]
        void Add(EducationInformation education);
        [OperationContract]
        void Delete(int Id);
        [OperationContract]
        void Update(EducationInformation education);
    }
}
