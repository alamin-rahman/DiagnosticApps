using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiagnosticApps
{
    public partial class ContainerUI : Form
    {
        public ContainerUI(string heading, UserControl uc,bool isFullScreen)


        {
            this.Text = heading;
            this .Controls .Add(uc);
            if(isFullScreen)
            {
                this.WindowState =FormWindowState.Maximized;

            }

            else
            {
                
                this.Size=new Size(uc.Width,uc.Height+20 );

            }

            uc.Dock=DockStyle.Fill;


        


    
            InitializeComponent();
        }

        private void ContainerUI_Load(object sender, EventArgs e)
        {

        }
    }
}
