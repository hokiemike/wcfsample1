using System.Collections.Generic;
using System.ServiceModel;
using com.devrockit.wcfsample1.Model;

//test comment
namespace com.devrockit.wcfsample1.Contract
{
    [ServiceContract(Namespace = "http://com/devrockit/wcfsample1")]
    public interface IPolicyService
    {
        [OperationContract]
        List<Policy> GetAllPolicies();
    }
}
