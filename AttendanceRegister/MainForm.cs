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
    public partial class AttendanceRegister : Form
    {
        #region Constructor
        public AttendanceRegister()
        {
            InitializeComponent();
            Parishioner george = new Parishioner("George", "Sebastian", Wards.SA);
            Parishioner melvin = new Parishioner("Melvin", "Fernandes", Wards.SM);
            //PushToDB(george);
            //PushToDB(melvin);
        }
        #endregion        

        #region Methods
        private void NewParishioner()
        {
            using (AddParishioner newParishioner = new AddParishioner())
            {
                DialogResult result = newParishioner.ShowDialog();
                if (result == DialogResult.OK)
                {
                    AddParishionerToDatabase(newParishioner);
                }
            }
        }

        private void AddParishionerToDatabase(AddParishioner newParishioner)
        {
            //throw new NotImplementedException();
        }
        #endregion

        #region EventHandlers
        private void addParishionerButton_Click(object sender, EventArgs e)
        {
            NewParishioner();
        }
        #endregion

        private void AttendanceRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
