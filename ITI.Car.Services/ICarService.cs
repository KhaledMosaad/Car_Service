using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Car.Services
{
    [ServiceContract]
    public interface ICarService
    {
        [OperationContract]
        [WebGet(UriTemplate="Car/Id/{id}")]
        Car GetbyId(string id);
        [OperationContract]
        [WebGet(UriTemplate="Car/Model/{model}")]
        List<Car> GetbyModel(string model);
        [OperationContract]
        [WebInvoke(Method ="PUT",UriTemplate ="Car")]
        Car Add(Car car);
        [OperationContract]
        [WebInvoke(Method ="POST",UriTemplate ="Car")]
        Car Modify(Car car);
        [OperationContract]
        [WebGet(UriTemplate="Cars")]
        List<Car> GetAll();
        [OperationContract]
        [WebInvoke(Method ="DELETE",UriTemplate ="Car/{id}")]
        void Remove(string id);
    }
}
