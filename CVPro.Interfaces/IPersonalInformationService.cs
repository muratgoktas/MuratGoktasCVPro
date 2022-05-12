using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CVPro.Entities;

namespace CVPro.Interfaces
{
    [ServiceContract]
    public interface IPersonalInformationService
    {
        [OperationContract]
        List<PersonInformation> GetAll();
        [OperationContract]
        PersonInformation Get(int id);
        [OperationContract]
        void Add(PersonInformation person);
        [OperationContract]
        void Delete(int id);
        [OperationContract]
        void Update(PersonInformation person);
    }
}
