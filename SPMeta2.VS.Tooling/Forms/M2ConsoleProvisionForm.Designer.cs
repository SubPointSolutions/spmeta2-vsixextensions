namespace SPMeta2.VS.Tooling.Forms
{
    partial class M2ConsoleProvisionForm
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
            this.bOk = new System.Windows.Forms.Button();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.pRuntimeOptions = new System.Windows.Forms.Panel();
            this.gbProvisionRuntime = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbPlatformSP2013SSOM = new System.Windows.Forms.RadioButton();
            this.rbPlatformSP2013CSOM = new System.Windows.Forms.RadioButton();
            this.rbPlatformO365CSOM = new System.Windows.Forms.RadioButton();
            this.gbTargetPlatform = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.rbFoundation = new System.Windows.Forms.RadioButton();
            this.gbActions.SuspendLayout();
            this.pRuntimeOptions.SuspendLayout();
            this.gbProvisionRuntime.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbTargetPlatform.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bOk
            // 
            this.bOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bOk.Location = new System.Drawing.Point(277, 16);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 1;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.bOk);
            this.gbActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbActions.Location = new System.Drawing.Point(0, 124);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(364, 47);
            this.gbActions.TabIndex = 8;
            this.gbActions.TabStop = false;
            // 
            // pRuntimeOptions
            // 
            this.pRuntimeOptions.Controls.Add(this.gbProvisionRuntime);
            this.pRuntimeOptions.Controls.Add(this.gbTargetPlatform);
            this.pRuntimeOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pRuntimeOptions.Location = new System.Drawing.Point(0, 0);
            this.pRuntimeOptions.Name = "pRuntimeOptions";
            this.pRuntimeOptions.Size = new System.Drawing.Size(364, 124);
            this.pRuntimeOptions.TabIndex = 9;
            // 
            // gbProvisionRuntime
            // 
            this.gbProvisionRuntime.Controls.Add(this.panel1);
            this.gbProvisionRuntime.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbProvisionRuntime.Location = new System.Drawing.Point(170, 0);
            this.gbProvisionRuntime.Name = "gbProvisionRuntime";
            this.gbProvisionRuntime.Size = new System.Drawing.Size(186, 124);
            this.gbProvisionRuntime.TabIndex = 6;
            this.gbProvisionRuntime.TabStop = false;
            this.gbProvisionRuntime.Text = "Target provision runtime";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbPlatformSP2013SSOM);
            this.panel1.Controls.Add(this.rbPlatformSP2013CSOM);
            this.panel1.Controls.Add(this.rbPlatformO365CSOM);
            this.panel1.Location = new System.Drawing.Point(21, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 76);
            this.panel1.TabIndex = 5;
            // 
            // rbPlatformSP2013SSOM
            // 
            this.rbPlatformSP2013SSOM.AutoSize = true;
            this.rbPlatformSP2013SSOM.Location = new System.Drawing.Point(3, 49);
            this.rbPlatformSP2013SSOM.Name = "rbPlatformSP2013SSOM";
            this.rbPlatformSP2013SSOM.Size = new System.Drawing.Size(97, 17);
            this.rbPlatformSP2013SSOM.TabIndex = 5;
            this.rbPlatformSP2013SSOM.Text = "SP2013 SSOM";
            this.rbPlatformSP2013SSOM.UseVisualStyleBackColor = true;
            // 
            // rbPlatformSP2013CSOM
            // 
            this.rbPlatformSP2013CSOM.AutoSize = true;
            this.rbPlatformSP2013CSOM.Checked = true;
            this.rbPlatformSP2013CSOM.Location = new System.Drawing.Point(3, 26);
            this.rbPlatformSP2013CSOM.Name = "rbPlatformSP2013CSOM";
            this.rbPlatformSP2013CSOM.Size = new System.Drawing.Size(97, 17);
            this.rbPlatformSP2013CSOM.TabIndex = 6;
            this.rbPlatformSP2013CSOM.TabStop = true;
            this.rbPlatformSP2013CSOM.Text = "SP2013 CSOM";
            this.rbPlatformSP2013CSOM.UseVisualStyleBackColor = true;
            // 
            // rbPlatformO365CSOM
            // 
            this.rbPlatformO365CSOM.AutoSize = true;
            this.rbPlatformO365CSOM.Location = new System.Drawing.Point(3, 3);
            this.rbPlatformO365CSOM.Name = "rbPlatformO365CSOM";
            this.rbPlatformO365CSOM.Size = new System.Drawing.Size(85, 17);
            this.rbPlatformO365CSOM.TabIndex = 7;
            this.rbPlatformO365CSOM.Text = "O365 CSOM";
            this.rbPlatformO365CSOM.UseVisualStyleBackColor = true;
            // 
            // gbTargetPlatform
            // 
            this.gbTargetPlatform.Controls.Add(this.panel2);
            this.gbTargetPlatform.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbTargetPlatform.Location = new System.Drawing.Point(0, 0);
            this.gbTargetPlatform.Name = "gbTargetPlatform";
            this.gbTargetPlatform.Size = new System.Drawing.Size(170, 124);
            this.gbTargetPlatform.TabIndex = 5;
            this.gbTargetPlatform.TabStop = false;
            this.gbTargetPlatform.Text = "Target platrofm edition";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbStandard);
            this.panel2.Controls.Add(this.rbFoundation);
            this.panel2.Location = new System.Drawing.Point(17, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 54);
            this.panel2.TabIndex = 6;
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Checked = true;
            this.rbStandard.Location = new System.Drawing.Point(5, 26);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(123, 17);
            this.rbStandard.TabIndex = 6;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "SharePoint Standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            // 
            // rbFoundation
            // 
            this.rbFoundation.AutoSize = true;
            this.rbFoundation.Location = new System.Drawing.Point(5, 3);
            this.rbFoundation.Name = "rbFoundation";
            this.rbFoundation.Size = new System.Drawing.Size(133, 17);
            this.rbFoundation.TabIndex = 7;
            this.rbFoundation.Text = "SharePoint Foundation";
            this.rbFoundation.UseVisualStyleBackColor = true;
            // 
            // M2ConsoleProvisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 171);
            this.Controls.Add(this.gbActions);
            this.Controls.Add(this.pRuntimeOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "M2ConsoleProvisionForm";
            this.Text = "M2 Console Provision Project Settings";
            this.gbActions.ResumeLayout(false);
            this.pRuntimeOptions.ResumeLayout(false);
            this.gbProvisionRuntime.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbTargetPlatform.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Panel pRuntimeOptions;
        private System.Windows.Forms.GroupBox gbProvisionRuntime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbPlatformSP2013SSOM;
        private System.Windows.Forms.RadioButton rbPlatformSP2013CSOM;
        private System.Windows.Forms.RadioButton rbPlatformO365CSOM;
        private System.Windows.Forms.GroupBox gbTargetPlatform;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.RadioButton rbFoundation;
    }
}