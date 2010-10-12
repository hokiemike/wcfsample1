using System.Collections.Generic;
using com.devrockit.wcfsample1.Contract;
using com.devrockit.wcfsample1.Model;

namespace com.devrockit.wcfsample1.Service.Services
{
    public class PolicyService : IPolicyService
    {
        
        public List<Policy>  GetAllPolicies()
        {
 	        List<Policy> policies = new List<Policy>();
            policies.Add(new Policy("1234",     "Acme Co."));
            policies.Add(new Policy("54635",    "Hair Nation Group"));
            return policies;
        }
    }
}