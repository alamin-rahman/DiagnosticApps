using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiagnosticApps.BaseControl;

namespace DiagnosticApps.GeneralControl
{
    public partial class ucTestInformation : ucSave
    {

     private     DiagnosticDataContext aDiagnosticDataContext = new DiagnosticDataContext();

    private      tbl_Category aTblCategory = new tbl_Category();

   private       tbl_Test    aTblTest = new tbl_Test();






        public ucTestInformation()
        {
            InitializeComponent();
        }

        #region override method    


        public override void Save()
        {


        }

        

        public override void Clear()
        {
           // base.Clear();
        }


        #endregion

        private void btn_CategoryAdd_Click(object sender, EventArgs e)
        {
            aTblCategory = new tbl_Category();



            try
            {
                aTblCategory =
                    (from c in aDiagnosticDataContext.tbl_Categories where  c.Category==txt_CategoryAdd.Text select c).
                        Single();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Failed to Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (aTblCategory.CategoryID==0)
            {
                try
                {

                    aTblCategory.Category = txt_CategoryAdd.Text;
                    aDiagnosticDataContext.tbl_Categories.InsertOnSubmit(aTblCategory);
                    aDiagnosticDataContext.SubmitChanges();

                }

                catch (Exception)
                {

                    MessageBox.Show(" Saved");
                }


            }


            else
            {
                MessageBox.Show("Data already Saved");
            }






        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


