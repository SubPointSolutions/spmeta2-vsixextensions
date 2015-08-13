namespace SPMeta2.VS.Tooling.Forms
{
    partial class M2IntranetModelForm
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
            this.tbProjectPrefix = new System.Windows.Forms.TextBox();
            this.bOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbProjectSettings = new System.Windows.Forms.GroupBox();
            this.gbTargetPlatform = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.rbFoundation = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbPlatformSP2013SSOM = new System.Windows.Forms.RadioButton();
            this.rbPlatformSP2013CSOM = new System.Windows.Forms.RadioButton();
            this.rbPlatformO365CSOM = new System.Windows.Forms.RadioButton();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.gbProjectSettings.SuspendLayout();
            this.gbTargetPlatform.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbProjectPrefix
            // 
            this.tbProjectPrefix.Location = new System.Drawing.Point(92, 25);
            this.tbProjectPrefix.Name = "tbProjectPrefix";
            this.tbProjectPrefix.Size = new System.Drawing.Size(150, 20);
            this.tbProjectPrefix.TabIndex = 0;
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(412, 19);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 1;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project prefix:";
            // 
            // gbProjectSettings
            // 
            this.gbProjectSettings.Controls.Add(this.label1);
            this.gbProjectSettings.Controls.Add(this.tbProjectPrefix);
            this.gbProjectSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbProjectSettings.Location = new System.Drawing.Point(0, 0);
            this.gbProjectSettings.Name = "gbProjectSettings";
            this.gbProjectSettings.Size = new System.Drawing.Size(499, 61);
            this.gbProjectSettings.TabIndex = 4;
            this.gbProjectSettings.TabStop = false;
            this.gbProjectSettings.Text = "Project Settings";
            // 
            // gbTargetPlatform
            // 
            this.gbTargetPlatform.Controls.Add(this.panel2);
            this.gbTargetPlatform.Controls.Add(this.panel1);
            this.gbTargetPlatform.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTargetPlatform.Location = new System.Drawing.Point(0, 61);
            this.gbTargetPlatform.Name = "gbTargetPlatform";
            this.gbTargetPlatform.Size = new System.Drawing.Size(499, 106);
            this.gbTargetPlatform.TabIndex = 5;
            this.gbTargetPlatform.TabStop = false;
            this.gbTargetPlatform.Text = "Target platform";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbStandard);
            this.panel2.Controls.Add(this.rbFoundation);
            this.panel2.Location = new System.Drawing.Point(138, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 75);
            this.panel2.TabIndex = 6;
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Checked = true;
            this.rbStandard.Location = new System.Drawing.Point(5, 26);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(68, 17);
            this.rbStandard.TabIndex = 6;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "Standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            // 
            // rbFoundation
            // 
            this.rbFoundation.AutoSize = true;
            this.rbFoundation.Location = new System.Drawing.Point(5, 3);
            this.rbFoundation.Name = "rbFoundation";
            this.rbFoundation.Size = new System.Drawing.Size(78, 17);
            this.rbFoundation.TabIndex = 7;
            this.rbFoundation.Text = "Foundation";
            this.rbFoundation.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbPlatformSP2013SSOM);
            this.panel1.Controls.Add(this.rbPlatformSP2013CSOM);
            this.panel1.Controls.Add(this.rbPlatformO365CSOM);
            this.panel1.Location = new System.Drawing.Point(12, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 75);
            this.panel1.TabIndex = 5;
            // 
            // rbPlatformSP2013SSOM
            // 
            this.rbPlatformSP2013SSOM.AutoSize = true;
            this.rbPlatformSP2013SSOM.Location = new System.Drawing.Point(5, 49);
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
            this.rbPlatformSP2013CSOM.Location = new System.Drawing.Point(5, 26);
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
            this.rbPlatformO365CSOM.Location = new System.Drawing.Point(5, 3);
            this.rbPlatformO365CSOM.Name = "rbPlatformO365CSOM";
            this.rbPlatformO365CSOM.Size = new System.Drawing.Size(85, 17);
            this.rbPlatformO365CSOM.TabIndex = 7;
            this.rbPlatformO365CSOM.Text = "O365 CSOM";
            this.rbPlatformO365CSOM.UseVisualStyleBackColor = true;
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.bOk);
            this.gbActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbActions.Location = new System.Drawing.Point(0, 167);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(499, 52);
            this.gbActions.TabIndex = 6;
            this.gbActions.TabStop = false;
            // 
            // M2IntranetModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 219);
            this.Controls.Add(this.gbActions);
            this.Controls.Add(this.gbTargetPlatform);
            this.Controls.Add(this.gbProjectSettings);
            this.Name = "M2IntranetModelForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M2 Intranet Project Settings";
            this.gbProjectSettings.ResumeLayout(false);
            this.gbProjectSettings.PerformLayout();
            this.gbTargetPlatform.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbProjectPrefix;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbProjectSettings;
        private System.Windows.Forms.GroupBox gbTargetPlatform;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbPlatformSP2013SSOM;
        private System.Windows.Forms.RadioButton rbPlatformSP2013CSOM;
        private System.Windows.Forms.RadioButton rbPlatformO365CSOM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.RadioButton rbFoundation;
    }
}