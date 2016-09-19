using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CandidateProfileBO1;
using CandidateProfileBAL1;

namespace WcfService_E_Recruitment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
       public void service_create_candidate_profile(CandidateProfileBOClass can_pro)
    {
    CandidateProfileBALClass bal_obj=new CandidateProfileBALClass();
        bal_obj.createCandidateProfile(can_pro);
    }

       public void service_delete_candidate_profile(int can_id)
    {
       CandidateProfileBALClass balobj = new CandidateProfileBALClass();
            balobj.deleteCandidateProifle(can_id);
    }
    }
}
