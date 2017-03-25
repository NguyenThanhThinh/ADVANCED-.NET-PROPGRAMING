namespace ThucHanh3.UI
{
    partial class FrmMain
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
            this.btnAirportMgt = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripstatusUserLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAirportMgt
            // 
            this.btnAirportMgt.Location = new System.Drawing.Point(30, 24);
            this.btnAirportMgt.Margin = new System.Windows.Forms.Padding(1);
            this.btnAirportMgt.Name = "btnAirportMgt";
            this.btnAirportMgt.Size = new System.Drawing.Size(111, 68);
            this.btnAirportMgt.TabIndex = 0;
            this.btnAirportMgt.Text = "Airport Management";
            this.btnAirportMgt.UseVisualStyleBackColor = true;
            this.btnAirportMgt.Click += new System.EventHandler(this.btnAirportMgt_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripstatusUserLogin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 272);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(746, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripstatusUserLogin
            // 
            this.stripstatusUserLogin.Name = "stripstatusUserLogin";
            this.stripstatusUserLogin.Size = new System.Drawing.Size(35, 17);
            this.stripstatusUserLogin.Text = "Hello";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 294);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAirportMgt);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FrmMain";
            this.Text = "AirPlane Ticket Management System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAirportMgt;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripstatusUserLogin;
    }
}

