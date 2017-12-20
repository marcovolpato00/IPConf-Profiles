namespace IP_Configuration_Profiles
{
    partial class FormEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdit));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxIp = new System.Windows.Forms.GroupBox();
            this.tbGateway = new IPAddressControlLib.IPAddressControl();
            this.tbNetmask = new IPAddressControlLib.IPAddressControl();
            this.tbIpAddress = new IPAddressControlLib.IPAddressControl();
            this.groupBoxDns = new System.Windows.Forms.GroupBox();
            this.tbDns2 = new IPAddressControlLib.IPAddressControl();
            this.tbDns1 = new IPAddressControlLib.IPAddressControl();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbIntefaces = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.rdbStatic = new System.Windows.Forms.RadioButton();
            this.rdbDhcp = new System.Windows.Forms.RadioButton();
            this.groupBoxIp.SuspendLayout();
            this.groupBoxDns.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "DNS 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "DNS 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gateway";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Netmask";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Indirizzo IP";
            // 
            // groupBoxIp
            // 
            this.groupBoxIp.Controls.Add(this.tbGateway);
            this.groupBoxIp.Controls.Add(this.tbNetmask);
            this.groupBoxIp.Controls.Add(this.tbIpAddress);
            this.groupBoxIp.Controls.Add(this.label1);
            this.groupBoxIp.Controls.Add(this.label2);
            this.groupBoxIp.Controls.Add(this.label3);
            this.groupBoxIp.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxIp.Location = new System.Drawing.Point(31, 110);
            this.groupBoxIp.Name = "groupBoxIp";
            this.groupBoxIp.Size = new System.Drawing.Size(166, 188);
            this.groupBoxIp.TabIndex = 10;
            this.groupBoxIp.TabStop = false;
            this.groupBoxIp.Text = "Configurazione IP";
            // 
            // tbGateway
            // 
            this.tbGateway.AllowInternalTab = false;
            this.tbGateway.AutoHeight = true;
            this.tbGateway.BackColor = System.Drawing.SystemColors.Window;
            this.tbGateway.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbGateway.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGateway.Location = new System.Drawing.Point(19, 154);
            this.tbGateway.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbGateway.MinimumSize = new System.Drawing.Size(99, 23);
            this.tbGateway.Name = "tbGateway";
            this.tbGateway.ReadOnly = false;
            this.tbGateway.Size = new System.Drawing.Size(138, 23);
            this.tbGateway.TabIndex = 8;
            this.tbGateway.Tag = "Gateway";
            this.tbGateway.Text = "...";
            // 
            // tbNetmask
            // 
            this.tbNetmask.AllowInternalTab = false;
            this.tbNetmask.AutoHeight = true;
            this.tbNetmask.BackColor = System.Drawing.SystemColors.Window;
            this.tbNetmask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbNetmask.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNetmask.Location = new System.Drawing.Point(19, 96);
            this.tbNetmask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNetmask.MinimumSize = new System.Drawing.Size(99, 23);
            this.tbNetmask.Name = "tbNetmask";
            this.tbNetmask.ReadOnly = false;
            this.tbNetmask.Size = new System.Drawing.Size(138, 23);
            this.tbNetmask.TabIndex = 7;
            this.tbNetmask.Tag = "Netmask";
            this.tbNetmask.Text = "...";
            // 
            // tbIpAddress
            // 
            this.tbIpAddress.AllowInternalTab = false;
            this.tbIpAddress.AutoHeight = true;
            this.tbIpAddress.BackColor = System.Drawing.SystemColors.Window;
            this.tbIpAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbIpAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIpAddress.Location = new System.Drawing.Point(19, 39);
            this.tbIpAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIpAddress.MinimumSize = new System.Drawing.Size(99, 23);
            this.tbIpAddress.Name = "tbIpAddress";
            this.tbIpAddress.ReadOnly = false;
            this.tbIpAddress.Size = new System.Drawing.Size(138, 23);
            this.tbIpAddress.TabIndex = 6;
            this.tbIpAddress.Tag = "IPAddress";
            this.tbIpAddress.Text = "...";
            // 
            // groupBoxDns
            // 
            this.groupBoxDns.Controls.Add(this.tbDns2);
            this.groupBoxDns.Controls.Add(this.tbDns1);
            this.groupBoxDns.Controls.Add(this.label5);
            this.groupBoxDns.Controls.Add(this.label4);
            this.groupBoxDns.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDns.Location = new System.Drawing.Point(241, 110);
            this.groupBoxDns.Name = "groupBoxDns";
            this.groupBoxDns.Size = new System.Drawing.Size(166, 134);
            this.groupBoxDns.TabIndex = 11;
            this.groupBoxDns.TabStop = false;
            this.groupBoxDns.Text = "DNS";
            // 
            // tbDns2
            // 
            this.tbDns2.AllowInternalTab = false;
            this.tbDns2.AutoHeight = true;
            this.tbDns2.BackColor = System.Drawing.SystemColors.Window;
            this.tbDns2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbDns2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDns2.Location = new System.Drawing.Point(19, 96);
            this.tbDns2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDns2.MinimumSize = new System.Drawing.Size(99, 23);
            this.tbDns2.Name = "tbDns2";
            this.tbDns2.ReadOnly = false;
            this.tbDns2.Size = new System.Drawing.Size(138, 23);
            this.tbDns2.TabIndex = 10;
            this.tbDns2.Tag = "DNS2";
            this.tbDns2.Text = "...";
            // 
            // tbDns1
            // 
            this.tbDns1.AllowInternalTab = false;
            this.tbDns1.AutoHeight = true;
            this.tbDns1.BackColor = System.Drawing.SystemColors.Window;
            this.tbDns1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbDns1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDns1.Location = new System.Drawing.Point(19, 39);
            this.tbDns1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDns1.MinimumSize = new System.Drawing.Size(99, 23);
            this.tbDns1.Name = "tbDns1";
            this.tbDns1.ReadOnly = false;
            this.tbDns1.Size = new System.Drawing.Size(138, 23);
            this.tbDns1.TabIndex = 9;
            this.tbDns1.Tag = "DNS1";
            this.tbDns1.Text = "...";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(50, 34);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(126, 23);
            this.tbName.TabIndex = 1;
            this.tbName.Tag = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nome Profilo";
            // 
            // cbIntefaces
            // 
            this.cbIntefaces.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIntefaces.FormattingEnabled = true;
            this.cbIntefaces.Location = new System.Drawing.Point(241, 34);
            this.cbIntefaces.Name = "cbIntefaces";
            this.cbIntefaces.Size = new System.Drawing.Size(166, 23);
            this.cbIntefaces.TabIndex = 2;
            this.cbIntefaces.SelectedIndexChanged += new System.EventHandler(this.InterfaceSelected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(238, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Scheda di Rete";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(222, 325);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(106, 28);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "Applica";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(112, 325);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(106, 28);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Annulla";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // rdbStatic
            // 
            this.rdbStatic.AutoSize = true;
            this.rdbStatic.Checked = true;
            this.rdbStatic.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbStatic.Location = new System.Drawing.Point(46, 68);
            this.rdbStatic.Margin = new System.Windows.Forms.Padding(2);
            this.rdbStatic.Name = "rdbStatic";
            this.rdbStatic.Size = new System.Drawing.Size(80, 19);
            this.rdbStatic.TabIndex = 18;
            this.rdbStatic.TabStop = true;
            this.rdbStatic.Text = "IP Statico";
            this.rdbStatic.UseVisualStyleBackColor = true;
            this.rdbStatic.CheckedChanged += new System.EventHandler(this.ConfigurationModeChanged);
            // 
            // rdbDhcp
            // 
            this.rdbDhcp.AutoSize = true;
            this.rdbDhcp.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDhcp.Location = new System.Drawing.Point(148, 68);
            this.rdbDhcp.Margin = new System.Windows.Forms.Padding(2);
            this.rdbDhcp.Name = "rdbDhcp";
            this.rdbDhcp.Size = new System.Drawing.Size(59, 19);
            this.rdbDhcp.TabIndex = 19;
            this.rdbDhcp.Text = "DHCP";
            this.rdbDhcp.UseVisualStyleBackColor = true;
            this.rdbDhcp.CheckedChanged += new System.EventHandler(this.ConfigurationModeChanged);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(437, 373);
            this.Controls.Add(this.rdbDhcp);
            this.Controls.Add(this.rdbStatic);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbIntefaces);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBoxDns);
            this.Controls.Add(this.groupBoxIp);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(453, 412);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(453, 412);
            this.Name = "FormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifica Profilo";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.groupBoxIp.ResumeLayout(false);
            this.groupBoxIp.PerformLayout();
            this.groupBoxDns.ResumeLayout(false);
            this.groupBoxDns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxIp;
        private System.Windows.Forms.GroupBox groupBoxDns;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbIntefaces;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonEdit;
        private IPAddressControlLib.IPAddressControl tbGateway;
        private IPAddressControlLib.IPAddressControl tbNetmask;
        private IPAddressControlLib.IPAddressControl tbIpAddress;
        private IPAddressControlLib.IPAddressControl tbDns2;
        private IPAddressControlLib.IPAddressControl tbDns1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RadioButton rdbStatic;
        private System.Windows.Forms.RadioButton rdbDhcp;
    }
}