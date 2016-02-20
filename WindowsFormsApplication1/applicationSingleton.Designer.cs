namespace WindowsFormsApplication1
{
    partial class applicationSingleton
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
<<<<<<< HEAD
            this.appnamebtn.Click += new System.EventHandler(this.appnamebtn_Click);
=======
>>>>>>> 23aafe51aca8c9e2bf4d6a27514311d2fcdc0d4c
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
            this.lastchecktime.Size = new System.Drawing.Size(56, 39);
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
            // applicationSingleton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.appnamebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastchecktime);
            this.Controls.Add(this.levelnum);
            this.Name = "applicationSingleton";
            this.Size = new System.Drawing.Size(409, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button appnamebtn;
        public System.Windows.Forms.Label lastchecktime;
        public System.Windows.Forms.Label levelnum;
    }
}
