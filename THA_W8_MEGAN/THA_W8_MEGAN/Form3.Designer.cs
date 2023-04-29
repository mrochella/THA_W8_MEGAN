namespace THA_W8_MEGAN
{
    partial class Form3
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
            this.comboBox_teamLagi = new System.Windows.Forms.ComboBox();
            this.comboBox_mDate = new System.Windows.Forms.ComboBox();
            this.dataGridView_home = new System.Windows.Forms.DataGridView();
            this.dataGridView_away = new System.Windows.Forms.DataGridView();
            this.dataGridView_lainnya = new System.Windows.Forms.DataGridView();
            this.labelHome = new System.Windows.Forms.Label();
            this.labelAway = new System.Windows.Forms.Label();
            this.labelDet = new System.Windows.Forms.Label();
            this.label_team = new System.Windows.Forms.Label();
            this.label_matchid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_away)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lainnya)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_teamLagi
            // 
            this.comboBox_teamLagi.FormattingEnabled = true;
            this.comboBox_teamLagi.Location = new System.Drawing.Point(181, 12);
            this.comboBox_teamLagi.Name = "comboBox_teamLagi";
            this.comboBox_teamLagi.Size = new System.Drawing.Size(121, 21);
            this.comboBox_teamLagi.TabIndex = 0;
            this.comboBox_teamLagi.SelectedIndexChanged += new System.EventHandler(this.comboBox_teamLagi_SelectedIndexChanged);
            this.comboBox_teamLagi.SelectionChangeCommitted += new System.EventHandler(this.comboBox_teamLagi_SelectionChangeCommitted);
            // 
            // comboBox_mDate
            // 
            this.comboBox_mDate.FormattingEnabled = true;
            this.comboBox_mDate.Location = new System.Drawing.Point(507, 12);
            this.comboBox_mDate.Name = "comboBox_mDate";
            this.comboBox_mDate.Size = new System.Drawing.Size(121, 21);
            this.comboBox_mDate.TabIndex = 1;
            this.comboBox_mDate.SelectedIndexChanged += new System.EventHandler(this.comboBox_mDate_SelectedIndexChanged);
            this.comboBox_mDate.SelectionChangeCommitted += new System.EventHandler(this.comboBox_mDate_SelectionChangeCommitted);
            // 
            // dataGridView_home
            // 
            this.dataGridView_home.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_home.Location = new System.Drawing.Point(25, 51);
            this.dataGridView_home.Name = "dataGridView_home";
            this.dataGridView_home.Size = new System.Drawing.Size(371, 168);
            this.dataGridView_home.TabIndex = 3;
            // 
            // dataGridView_away
            // 
            this.dataGridView_away.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_away.Location = new System.Drawing.Point(402, 51);
            this.dataGridView_away.Name = "dataGridView_away";
            this.dataGridView_away.Size = new System.Drawing.Size(366, 168);
            this.dataGridView_away.TabIndex = 4;
            // 
            // dataGridView_lainnya
            // 
            this.dataGridView_lainnya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_lainnya.Location = new System.Drawing.Point(181, 225);
            this.dataGridView_lainnya.Name = "dataGridView_lainnya";
            this.dataGridView_lainnya.Size = new System.Drawing.Size(477, 168);
            this.dataGridView_lainnya.TabIndex = 5;
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.Location = new System.Drawing.Point(199, 72);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(0, 15);
            this.labelHome.TabIndex = 6;
            // 
            // labelAway
            // 
            this.labelAway.AutoSize = true;
            this.labelAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAway.Location = new System.Drawing.Point(601, 71);
            this.labelAway.Name = "labelAway";
            this.labelAway.Size = new System.Drawing.Size(0, 15);
            this.labelAway.TabIndex = 7;
            // 
            // labelDet
            // 
            this.labelDet.AutoSize = true;
            this.labelDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDet.Location = new System.Drawing.Point(375, 266);
            this.labelDet.Name = "labelDet";
            this.labelDet.Size = new System.Drawing.Size(0, 15);
            this.labelDet.TabIndex = 8;
            // 
            // label_team
            // 
            this.label_team.AutoSize = true;
            this.label_team.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_team.Location = new System.Drawing.Point(128, 13);
            this.label_team.Name = "label_team";
            this.label_team.Size = new System.Drawing.Size(0, 15);
            this.label_team.TabIndex = 9;
            // 
            // label_matchid
            // 
            this.label_matchid.AutoSize = true;
            this.label_matchid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_matchid.Location = new System.Drawing.Point(434, 13);
            this.label_matchid.Name = "label_matchid";
            this.label_matchid.Size = new System.Drawing.Size(0, 15);
            this.label_matchid.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.label_matchid);
            this.Controls.Add(this.label_team);
            this.Controls.Add(this.labelDet);
            this.Controls.Add(this.labelAway);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.dataGridView_lainnya);
            this.Controls.Add(this.dataGridView_away);
            this.Controls.Add(this.dataGridView_home);
            this.Controls.Add(this.comboBox_mDate);
            this.Controls.Add(this.comboBox_teamLagi);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_away)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lainnya)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_teamLagi;
        private System.Windows.Forms.ComboBox comboBox_mDate;
        private System.Windows.Forms.DataGridView dataGridView_home;
        private System.Windows.Forms.DataGridView dataGridView_away;
        private System.Windows.Forms.DataGridView dataGridView_lainnya;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Label labelAway;
        private System.Windows.Forms.Label labelDet;
        private System.Windows.Forms.Label label_team;
        private System.Windows.Forms.Label label_matchid;
    }
}