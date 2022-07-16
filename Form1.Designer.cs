namespace DiagnosticApps
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_GotoTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GotoTest
            // 
            this.btn_GotoTest.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_GotoTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GotoTest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_GotoTest.Location = new System.Drawing.Point(104, 66);
            this.btn_GotoTest.Name = "btn_GotoTest";
            this.btn_GotoTest.Size = new System.Drawing.Size(174, 77);
            this.btn_GotoTest.TabIndex = 0;
            this.btn_GotoTest.Text = "GoToTest";
            this.btn_GotoTest.UseVisualStyleBackColor = false;
            this.btn_GotoTest.Click += new System.EventHandler(this.btn_GotoTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 470);
            this.Controls.Add(this.btn_GotoTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GotoTest;
    }
}

