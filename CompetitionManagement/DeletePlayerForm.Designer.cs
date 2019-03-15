namespace CompetitionManagement
{
    partial class DeletePlayerForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lab_PlayerName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lab_tshirtNumber = new System.Windows.Forms.Label();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.cmb_IdPlayer = new System.Windows.Forms.ComboBox();
            this.cmb_Team = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player Name";
            // 
            // Lab_PlayerName
            // 
            this.Lab_PlayerName.AutoSize = true;
            this.Lab_PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_PlayerName.Location = new System.Drawing.Point(160, 32);
            this.Lab_PlayerName.Name = "Lab_PlayerName";
            this.Lab_PlayerName.Size = new System.Drawing.Size(52, 18);
            this.Lab_PlayerName.TabIndex = 3;
            this.Lab_PlayerName.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "T-shirt Number";
            // 
            // Lab_tshirtNumber
            // 
            this.Lab_tshirtNumber.AutoSize = true;
            this.Lab_tshirtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_tshirtNumber.Location = new System.Drawing.Point(160, 86);
            this.Lab_tshirtNumber.Name = "Lab_tshirtNumber";
            this.Lab_tshirtNumber.Size = new System.Drawing.Size(52, 18);
            this.Lab_tshirtNumber.TabIndex = 5;
            this.Lab_tshirtNumber.Text = "label6";
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.Location = new System.Drawing.Point(415, 296);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(75, 35);
            this.bt_Cancel.TabIndex = 3;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(164, 296);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 35);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // cmb_IdPlayer
            // 
            this.cmb_IdPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_IdPlayer.FormattingEnabled = true;
            this.cmb_IdPlayer.Location = new System.Drawing.Point(225, 83);
            this.cmb_IdPlayer.Name = "cmb_IdPlayer";
            this.cmb_IdPlayer.Size = new System.Drawing.Size(145, 26);
            this.cmb_IdPlayer.TabIndex = 1;
            this.cmb_IdPlayer.SelectedIndexChanged += new System.EventHandler(this.cmb_IdPlayer_SelectedIndexChanged);
            // 
            // cmb_Team
            // 
            this.cmb_Team.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Team.FormattingEnabled = true;
            this.cmb_Team.Location = new System.Drawing.Point(225, 32);
            this.cmb_Team.Name = "cmb_Team";
            this.cmb_Team.Size = new System.Drawing.Size(145, 26);
            this.cmb_Team.TabIndex = 0;
            this.cmb_Team.SelectedIndexChanged += new System.EventHandler(this.cmb_Team_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Lab_PlayerName);
            this.groupBox1.Controls.Add(this.Lab_tshirtNumber);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(104, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 132);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player\'s Informations";
            // 
            // DeletePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_Team);
            this.Controls.Add(this.cmb_IdPlayer);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeletePlayerForm";
            this.Text = "DeletePlayerForm";
            this.Load += new System.EventHandler(this.DeletePlayerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lab_PlayerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lab_tshirtNumber;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ComboBox cmb_IdPlayer;
        private System.Windows.Forms.ComboBox cmb_Team;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}