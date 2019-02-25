using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceRegister
{
    public partial class AddParishioner : Form
    {
        //private Parishioner parishioner;

        public AddParishioner()
        {
            InitializeComponent();
          //  this.parishioner = new Parishioner("", "", Wards.UNREGISTERED);
        }

        public bool EditParishioner(string familyId)
        {
            return false;
        }
    }
}
