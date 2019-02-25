using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceRegister
{
    class Parishioner
    {
        string firstName;
        string lastName;
        Wards ward;

        public Parishioner(string _firstName, string _lastName, Wards _ward)
        {
            this.firstName = !string.IsNullOrEmpty(_firstName) ? _firstName : "FIRSTNAME";
            this.lastName = !string.IsNullOrEmpty(_lastName) ? _lastName : "LASTNAME";
            this.ward = _ward;
        }

        public string GetName()
        {
            return firstName + lastName;
        }

        public Wards GetWard()
        {
            return ward;
        }
    }

    enum Wards
    {
        SA,
        SM,
        SJ,
        ST,
        SC,
        SS,
        MT,
        UNREGISTERED
    }
}
