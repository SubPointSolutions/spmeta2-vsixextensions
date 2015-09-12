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
            this.tbContentTypesGroup = new System.Windows.Forms.TextBox();
            this.tbSiteFieldsGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbPlatformNoRefs = new System.Windows.Forms.RadioButton();
            this.rbPlatformSP2013SSOM = new System.Windows.Forms.RadioButton();
            this.rbPlatformSP2013CSOM = new System.Windows.Forms.RadioButton();
            this.rbPlatformO365CSOM = new System.Windows.Forms.RadioButton();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.rbFoundation = new System.Windows.Forms.RadioButton();
            this.gbTargetPlatform = new System.Windows.Forms.GroupBox();
            this.pRuntimeOptions = new System.Windows.Forms.Panel();
            this.gbProvisionRuntime = new System.Windows.Forms.GroupBox();
            this.gbProjectSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbActions.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbTargetPlatform.SuspendLayout();
            this.pRuntimeOptions.SuspendLayout();
            this.gbProvisionRuntime.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbProjectPrefix
            // 
            this.tbProjectPrefix.Location = new System.Drawing.Point(129, 25);
            this.tbProjectPrefix.Name = "tbProjectPrefix";
            this.tbProjectPrefix.Size = new System.Drawing.Size(219, 20);
            this.tbProjectPrefix.TabIndex = 0;
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
            this.gbProjectSettings.Controls.Add(this.tbContentTypesGroup);
            this.gbProjectSettings.Controls.Add(this.tbSiteFieldsGroup);
            this.gbProjectSettings.Controls.Add(this.label3);
            this.gbProjectSettings.Controls.Add(this.label2);
            this.gbProjectSettings.Controls.Add(this.label1);
            this.gbProjectSettings.Controls.Add(this.tbProjectPrefix);
            this.gbProjectSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbProjectSettings.Location = new System.Drawing.Point(0, 0);
            this.gbProjectSettings.Name = "gbProjectSettings";
            this.gbProjectSettings.Size = new System.Drawing.Size(364, 108);
            this.gbProjectSettings.TabIndex = 4;
            this.gbProjectSettings.TabStop = false;
            this.gbProjectSettings.Text = "Project Settings";
            // 
            // tbContentTypesGroup
            // 
            this.tbContentTypesGroup.Location = new System.Drawing.Point(129, 77);
            this.tbContentTypesGroup.Name = "tbContentTypesGroup";
            this.tbContentTypesGroup.Size = new System.Drawing.Size(219, 20);
            this.tbContentTypesGroup.TabIndex = 5;
            // 
            // tbSiteFieldsGroup
            // 
            this.tbSiteFieldsGroup.Location = new System.Drawing.Point(129, 51);
            this.tbSiteFieldsGroup.Name = "tbSiteFieldsGroup";
            this.tbSiteFieldsGroup.Size = new System.Drawing.Size(219, 20);
            this.tbSiteFieldsGroup.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Content types group:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Site fields group:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbPlatformNoRefs);
            this.panel1.Controls.Add(this.rbPlatformSP2013SSOM);
            this.panel1.Controls.Add(this.rbPlatformSP2013CSOM);
            this.panel1.Controls.Add(this.rbPlatformO365CSOM);
            this.panel1.Location = new System.Drawing.Point(21, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 97);
            this.panel1.TabIndex = 5;
            // 
            // rbPlatformNoRefs
            // 
            this.rbPlatformNoRefs.AutoSize = true;
            this.rbPlatformNoRefs.Checked = true;
            this.rbPlatformNoRefs.Location = new System.Drawing.Point(9, 3);
            this.rbPlatformNoRefs.Name = "rbPlatformNoRefs";
            this.rbPlatformNoRefs.Size = new System.Drawing.Size(145, 17);
            this.rbPlatformNoRefs.TabIndex = 8;
            this.rbPlatformNoRefs.TabStop = true;
            this.rbPlatformNoRefs.Text = "no provision, POCOs only";
            this.rbPlatformNoRefs.UseVisualStyleBackColor = true;
            // 
            // rbPlatformSP2013SSOM
            // 
            this.rbPlatformSP2013SSOM.AutoSize = true;
            this.rbPlatformSP2013SSOM.Location = new System.Drawing.Point(9, 72);
            this.rbPlatformSP2013SSOM.Name = "rbPlatformSP2013SSOM";
            this.rbPlatformSP2013SSOM.Size = new System.Drawing.Size(97, 17);
            this.rbPlatformSP2013SSOM.TabIndex = 5;
            this.rbPlatformSP2013SSOM.Text = "SP2013 SSOM";
            this.rbPlatformSP2013SSOM.UseVisualStyleBackColor = true;
            // 
            // rbPlatformSP2013CSOM
            // 
            this.rbPlatformSP2013CSOM.AutoSize = true;
            this.rbPlatformSP2013CSOM.Location = new System.Drawing.Point(9, 49);
            this.rbPlatformSP2013CSOM.Name = "rbPlatformSP2013CSOM";
            this.rbPlatformSP2013CSOM.Size = new System.Drawing.Size(97, 17);
            this.rbPlatformSP2013CSOM.TabIndex = 6;
            this.rbPlatformSP2013CSOM.Text = "SP2013 CSOM";
            this.rbPlatformSP2013CSOM.UseVisualStyleBackColor = true;
            // 
            // rbPlatformO365CSOM
            // 
            this.rbPlatformO365CSOM.AutoSize = true;
            this.rbPlatformO365CSOM.Location = new System.Drawing.Point(9, 26);
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
            this.gbActions.Location = new System.Drawing.Point(0, 238);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(364, 48);
            this.gbActions.TabIndex = 6;
            this.gbActions.TabStop = false;
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
            // gbTargetPlatform
            // 
            this.gbTargetPlatform.Controls.Add(this.panel2);
            this.gbTargetPlatform.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbTargetPlatform.Location = new System.Drawing.Point(0, 0);
            this.gbTargetPlatform.Name = "gbTargetPlatform";
            this.gbTargetPlatform.Size = new System.Drawing.Size(170, 130);
            this.gbTargetPlatform.TabIndex = 5;
            this.gbTargetPlatform.TabStop = false;
            this.gbTargetPlatform.Text = "Target platrofm edition";
            // 
            // pRuntimeOptions
            // 
            this.pRuntimeOptions.Controls.Add(this.gbProvisionRuntime);
            this.pRuntimeOptions.Controls.Add(this.gbTargetPlatform);
            this.pRuntimeOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pRuntimeOptions.Location = new System.Drawing.Point(0, 108);
            this.pRuntimeOptions.Name = "pRuntimeOptions";
            this.pRuntimeOptions.Size = new System.Drawing.Size(364, 130);
            this.pRuntimeOptions.TabIndex = 7;
            // 
            // gbProvisionRuntime
            // 
            this.gbProvisionRuntime.Controls.Add(this.panel1);
            this.gbProvisionRuntime.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbProvisionRuntime.Location = new System.Drawing.Point(170, 0);
            this.gbProvisionRuntime.Name = "gbProvisionRuntime";
            this.gbProvisionRuntime.Size = new System.Drawing.Size(186, 130);
            this.gbProvisionRuntime.TabIndex = 6;
            this.gbProvisionRuntime.TabStop = false;
            this.gbProvisionRuntime.Text = "Target provision runtime";
            // 
            // M2IntranetModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 286);
            this.Controls.Add(this.gbActions);
            this.Controls.Add(this.pRuntimeOptions);
            this.Controls.Add(this.gbProjectSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "M2IntranetModelForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M2 Intranet Model Project Settings";
            this.gbProjectSettings.ResumeLayout(false);
            this.gbProjectSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbActions.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbTargetPlatform.ResumeLayout(false);
            this.pRuntimeOptions.ResumeLayout(false);
            this.gbProvisionRuntime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbProjectPrefix;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbProjectSettings;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbPlatformSP2013SSOM;
        private System.Windows.Forms.RadioButton rbPlatformSP2013CSOM;
        private System.Windows.Forms.RadioButton rbPlatformO365CSOM;
        private System.Windows.Forms.TextBox tbContentTypesGroup;
        private System.Windows.Forms.TextBox tbSiteFieldsGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbPlatformNoRefs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.RadioButton rbFoundation;
        private System.Windows.Forms.GroupBox gbTargetPlatform;
        private System.Windows.Forms.Panel pRuntimeOptions;
        private System.Windows.Forms.GroupBox gbProvisionRuntime;
    }
}