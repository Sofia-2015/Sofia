namespace WindowsFormsApplication1
{
    partial class applicationSingletonchk
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.appnamebtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lastchecktime = new System.Windows.Forms.Label();
            this.levelnum = new System.Windows.Forms.Label();
            this.frequnc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appnamebtn
            // 
            this.appnamebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appnamebtn.ForeColor = System.Drawing.Color.Green;
            this.appnamebtn.Location = new System.Drawing.Point(56, 9);
            this.appnamebtn.Name = "appnamebtn";
            this.appnamebtn.Size = new System.Drawing.Size(288, 21);
            this.appnamebtn.TabIndex = 200;
            this.appnamebtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(47, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(305, 39);
            this.label3.TabIndex = 199;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastchecktime
            // 
            this.lastchecktime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastchecktime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lastchecktime.Location = new System.Drawing.Point(351, 0);
            this.lastchecktime.Name = "lastchecktime";
            this.lastchecktime.Size = new System.Drawing.Size(63, 39);
            this.lastchecktime.TabIndex = 198;
            this.lastchecktime.Text = "--:--";
            this.lastchecktime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // levelnum
            // 
            this.levelnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.levelnum.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelnum.Location = new System.Drawing.Point(0, 0);
            this.levelnum.Name = "levelnum";
            this.levelnum.Size = new System.Drawing.Size(48, 39);
            this.levelnum.TabIndex = 197;
            this.levelnum.Text = "-";
            this.levelnum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frequnc
            // 
            this.frequnc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frequnc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.frequnc.Location = new System.Drawing.Point(413, 0);
            this.frequnc.Name = "frequnc";
            this.frequnc.Size = new System.Drawing.Size(63, 39);
            this.frequnc.TabIndex = 201;
            this.frequnc.Text = "--:--";
            this.frequnc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 202;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(475, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 39);
            this.label1.TabIndex = 203;
            this.label1.Text = "--:--";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // applicationSingletonchk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.frequnc);
            this.Controls.Add(this.appnamebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastchecktime);
            this.Controls.Add(this.levelnum);
            this.Controls.Add(this.label1);
            this.Name = "applicationSingletonchk";
            this.Size = new System.Drawing.Size(594, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button appnamebtn;
        public System.Windows.Forms.Label lastchecktime;
        public System.Windows.Forms.Label levelnum;
        public System.Windows.Forms.Label frequnc;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
    }
}
