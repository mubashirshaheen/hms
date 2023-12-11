
namespace hms
{
    partial class frmpatients
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtloginid = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtpatientname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpatientaddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpatientcontact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.combodoctor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID";
            // 
            // txtloginid
            // 
            this.txtloginid.Location = new System.Drawing.Point(149, 165);
            this.txtloginid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtloginid.Name = "txtloginid";
            this.txtloginid.Size = new System.Drawing.Size(96, 22);
            this.txtloginid.TabIndex = 10;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(329, 589);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(119, 44);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "S&ave";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(65, 291);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(909, 248);
            this.dgv.TabIndex = 3;
            // 
            // txtpatientname
            // 
            this.txtpatientname.Location = new System.Drawing.Point(374, 162);
            this.txtpatientname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpatientname.Name = "txtpatientname";
            this.txtpatientname.Size = new System.Drawing.Size(180, 22);
            this.txtpatientname.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patient Name";
            // 
            // txtpatientaddress
            // 
            this.txtpatientaddress.Location = new System.Drawing.Point(692, 165);
            this.txtpatientaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpatientaddress.Multiline = true;
            this.txtpatientaddress.Name = "txtpatientaddress";
            this.txtpatientaddress.Size = new System.Drawing.Size(279, 22);
            this.txtpatientaddress.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Patient Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Doctor";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtpatientcontact
            // 
            this.txtpatientcontact.Location = new System.Drawing.Point(194, 203);
            this.txtpatientcontact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpatientcontact.Name = "txtpatientcontact";
            this.txtpatientcontact.Size = new System.Drawing.Size(180, 22);
            this.txtpatientcontact.TabIndex = 13;
            this.txtpatientcontact.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Patient Contact";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(652, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Appointment Time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(774, 204);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // combodoctor
            // 
            this.combodoctor.FormattingEnabled = true;
            this.combodoctor.Location = new System.Drawing.Point(466, 205);
            this.combodoctor.Name = "combodoctor";
            this.combodoctor.Size = new System.Drawing.Size(166, 24);
            this.combodoctor.TabIndex = 20;
            // 
            // frmpatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 673);
            this.ControlBox = false;
            this.Controls.Add(this.combodoctor);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpatientcontact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpatientaddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpatientname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtloginid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmpatients";
            this.Load += new System.EventHandler(this.frmpatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtloginid;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtpatientname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpatientaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpatientcontact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox combodoctor;
    }
}