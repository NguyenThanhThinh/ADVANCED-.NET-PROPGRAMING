namespace ThucHanh2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBarServer1 = new System.Windows.Forms.ProgressBar();
            this.progressBarServer2 = new System.Windows.Forms.ProgressBar();
            this.lblServer1 = new System.Windows.Forms.Label();
            this.lblServer2 = new System.Windows.Forms.Label();
            this.btnStart1 = new System.Windows.Forms.Button();
            this.btnServer2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnServer2);
            this.groupBox1.Controls.Add(this.btnStart1);
            this.groupBox1.Controls.Add(this.lblServer2);
            this.groupBox1.Controls.Add(this.lblServer1);
            this.groupBox1.Controls.Add(this.progressBarServer2);
            this.groupBox1.Controls.Add(this.progressBarServer1);
            this.groupBox1.Location = new System.Drawing.Point(30, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup & Restore";
            // 
            // progressBarServer1
            // 
            this.progressBarServer1.Location = new System.Drawing.Point(88, 46);
            this.progressBarServer1.Name = "progressBarServer1";
            this.progressBarServer1.Size = new System.Drawing.Size(303, 23);
            this.progressBarServer1.TabIndex = 0;
            // 
            // progressBarServer2
            // 
            this.progressBarServer2.Location = new System.Drawing.Point(88, 108);
            this.progressBarServer2.Name = "progressBarServer2";
            this.progressBarServer2.Size = new System.Drawing.Size(303, 23);
            this.progressBarServer2.TabIndex = 1;
            // 
            // lblServer1
            // 
            this.lblServer1.AutoSize = true;
            this.lblServer1.Location = new System.Drawing.Point(18, 55);
            this.lblServer1.Name = "lblServer1";
            this.lblServer1.Size = new System.Drawing.Size(21, 13);
            this.lblServer1.TabIndex = 2;
            this.lblServer1.Text = "0%";
            this.lblServer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServer2
            // 
            this.lblServer2.AutoSize = true;
            this.lblServer2.Location = new System.Drawing.Point(18, 118);
            this.lblServer2.Name = "lblServer2";
            this.lblServer2.Size = new System.Drawing.Size(21, 13);
            this.lblServer2.TabIndex = 3;
            this.lblServer2.Text = "0%";
            this.lblServer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart1
            // 
            this.btnStart1.Location = new System.Drawing.Point(423, 45);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(75, 23);
            this.btnStart1.TabIndex = 4;
            this.btnStart1.Text = "Start";
            this.btnStart1.UseVisualStyleBackColor = true;
            this.btnStart1.Click += new System.EventHandler(this.btnStart1_Click);
            // 
            // btnServer2
            // 
            this.btnServer2.Location = new System.Drawing.Point(423, 108);
            this.btnServer2.Name = "btnServer2";
            this.btnServer2.Size = new System.Drawing.Size(75, 23);
            this.btnServer2.TabIndex = 5;
            this.btnServer2.Text = "Start";
            this.btnServer2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Backup all Servers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnServer2;
        private System.Windows.Forms.Button btnStart1;
        private System.Windows.Forms.Label lblServer2;
        private System.Windows.Forms.Label lblServer1;
        private System.Windows.Forms.ProgressBar progressBarServer2;
        private System.Windows.Forms.ProgressBar progressBarServer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

