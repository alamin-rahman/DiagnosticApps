using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiagnosticApps.GeneralControl;

namespace DiagnosticApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public void ShowInfo(string heading, UserControl uc, bool isFullScreen)//method

        {
            ContainerUI aContainerUi=new ContainerUI(heading,uc,true);
            aContainerUi.ShowDialog();

        }

        private void btn_GotoTest_Click(object sender, EventArgs e)
        {
            ShowInfo(" ", new ucTestInformation()  ,true);
        }
    }
}
