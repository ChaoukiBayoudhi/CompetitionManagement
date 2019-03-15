namespace CompetitionManagement
{
    partial class AddPlayerForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_Team = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_TshirtNumber = new System.Windows.Forms.ComboBox();
            this.cmb_Team = new System.Windows.Forms.ComboBox();
            this.dtp_BirthDay = new System.Windows.Forms.DateTimePicker();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.bt_Close = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "BirthDay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "T-shirt Number";
            // 
            // lab_Team
            // 
            this.lab_Team.AutoSize = true;
            this.lab_Team.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Team.Location = new System.Drawing.Point(24, 230);
            this.lab_Team.Name = "lab_Team";
            this.lab_Team.Size = new System.Drawing.Size(50, 18);
            this.lab_Team.TabIndex = 4;
            this.lab_Team.Text = "Team";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_TshirtNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lab_Team);
            this.groupBox1.Controls.Add(this.cmb_Team);
            this.groupBox1.Controls.Add(this.dtp_BirthDay);
            this.groupBox1.Controls.Add(this.txt_Id);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(68, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Informations";
            // 
            // cmb_TshirtNumber
            // 
            this.cmb_TshirtNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TshirtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TshirtNumber.FormattingEnabled = true;
            this.cmb_TshirtNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmb_TshirtNumber.Location = new System.Drawing.Point(161, 168);
            this.cmb_TshirtNumber.Name = "cmb_TshirtNumber";
            this.cmb_TshirtNumber.Size = new System.Drawing.Size(222, 26);
            this.cmb_TshirtNumber.TabIndex = 3;
            // 
            // cmb_Team
            // 
            this.cmb_Team.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Team.FormattingEnabled = true;
            this.cmb_Team.Location = new System.Drawing.Point(161, 227);
            this.cmb_Team.Name = "cmb_Team";
            this.cmb_Team.Size = new System.Drawing.Size(222, 26);
            this.cmb_Team.TabIndex = 4;
            // 
            // dtp_BirthDay
            // 
            this.dtp_BirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_BirthDay.Location = new System.Drawing.Point(161, 132);
            this.dtp_BirthDay.Name = "dtp_BirthDay";
            this.dtp_BirthDay.Size = new System.Drawing.Size(222, 24);
            this.dtp_BirthDay.TabIndex = 2;
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.Location = new System.Drawing.Point(161, 51);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(222, 24);
            this.txt_Id.TabIndex = 0;
            this.txt_Id.TextChanged += new System.EventHandler(this.txt_Id_TextChanged);
            this.txt_Id.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Id_Validating);
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(161, 91);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(222, 24);
            this.txt_Name.TabIndex = 1;
            // 
            // bt_Close
            // 
            this.bt_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Close.Location = new System.Drawing.Point(475, 328);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(75, 32);
            this.bt_Close.TabIndex = 2;
            this.bt_Close.Text = "Close";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add.Location = new System.Drawing.Point(268, 328);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(75, 32);
            this.bt_Add.TabIndex = 1;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            this.bt_Add.MouseHover += new System.EventHandler(this.bt_Add_MouseHover);
            this.bt_Add.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bt_Add_MouseMove);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 403);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_Add);
            this.Name = "AddPlayerForm";
            this.Text = "Add Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_Team;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_TshirtNumber;
        private System.Windows.Forms.ComboBox cmb_Team;
        private System.Windows.Forms.DateTimePicker dtp_BirthDay;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

