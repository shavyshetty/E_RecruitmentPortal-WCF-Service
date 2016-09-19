using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CandidateProfileBO1;

namespace WcfService_E_Recruitment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void service_create_candidate_profile(CandidateProfileBOClass can_pro);

        [OperationContract]
        void service_delete_candidate_profile(int can_id);

      
    }


  
   
}
