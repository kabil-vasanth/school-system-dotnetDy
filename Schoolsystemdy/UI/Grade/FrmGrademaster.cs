using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schoolsystemdy.UI.Grade
{
    public partial class FrmGrademaster : Form
    {

        Boolean is_addnew = false;
        public FrmGrademaster()
        {
            InitializeComponent();
        }

        private void gmbtnadd_Click(object sender, EventArgs e)
        {
            buttonEnable(true);

        }

        private void buttonEnable(bool is_true)
        {
            is_addnew = is_true;
            gmbtnadd.Enabled = !is_true;
            gmbtnedit.Enabled = !is_true;
            gmbtndelete.Enabled = !is_true;
            gmbtnrefresh.Enabled = !is_true;
            gmbtnexit.Enabled = !is_true;
            gmbtnsave.Enabled = is_true;
            gmbtncancel.Enabled = is_true;
        }

        private void gmbtncancel_Click(object sender, EventArgs e)
        {

          buttonEnable(false);

        }
    }
}
