using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HelloWordService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]

        [WebGet(ResponseFormat =WebMessageFormat.Json, UriTemplate="SayHello/")]

        string SayHello();

        [OperationContract]

        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetData/{value}")]

        string GetData(string value);

        [OperationContract]

        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetModelObject/{id}")]

        HelloObject GetModelObject(string id);

        [OperationContract]

        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetCustomers")]
        List<Customer> GetCustomers();

        [OperationContract]

        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetCustomer/{id}")]
        Customer GetCustomer(string id);

        [OperationContract]

        [WebInvoke(ResponseFormat = WebMessageFormat.Json, UriTemplate = "AddCustomer", Method = "POST", BodyStyle = WebMessageBodyStyle.Bare)]
        Customer AddCustomer(Customer info);

        [OperationContract]

        [WebInvoke(ResponseFormat = WebMessageFormat.Json, UriTemplate = "UpdateCustomer", Method = "PUT", BodyStyle = WebMessageBodyStyle.Bare)]
        string UpdateCustomer(Customer info);

        [OperationContract]

        [WebInvoke(ResponseFormat = WebMessageFormat.Json, UriTemplate = "DeleteCustomer", Method = "DELETE", BodyStyle = WebMessageBodyStyle.Bare)]
        string DeleteCustomer(Customer info);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
       
    }
}
