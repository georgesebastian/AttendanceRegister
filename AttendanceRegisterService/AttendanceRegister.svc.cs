using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AttendanceRegisterService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class AttendanceRegister : IAttendanceRegister
    {
        public List<Ward> GetWards()
        {
            DataAccess ds = new DataAccess();
            return ds.GetWards();
        }

        public void InsertWard(Ward ward)
        {
            DataAccess ds = new DataAccess();
            ds.InsertWard(ward);
        }

        public void InsertParishioner(Parishioner parishioner)
        {
            DataAccess ds = new DataAccess();
            ds.InsertParishioner(parishioner);
        }
    }
}