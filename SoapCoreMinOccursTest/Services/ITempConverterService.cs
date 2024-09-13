using System.ServiceModel;

namespace SoapCoreMinOccursTest.Services
{
    [ServiceContract]
    public interface ITempConverterService
    {
        [OperationContract]
        public string FahrenheitToCelsius(string fahrenheit);
    }
}
