using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiagnosticApps.BaseControl
{
    public partial class ucSave : UserControl
    {
        public ucSave()
        {
            InitializeComponent();
        }

        public virtual void Save()//method

        {


        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Save();//calling 


        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        public virtual void Clear()//method
        {


        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
               Clear();//calling
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
