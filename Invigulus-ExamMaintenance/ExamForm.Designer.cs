namespace Invigulus_ExamMaintenance
{
    partial class ExamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamForm));
            this.ind_lbl_ExamAdmin = new System.Windows.Forms.Label();
            this.ctrl_cb_examAdmin = new System.Windows.Forms.ComboBox();
            this.ind_lbl_Institution = new System.Windows.Forms.Label();
            this.ctrl_cb_institution = new System.Windows.Forms.ComboBox();
            this.ind_lbl_examName = new System.Windows.Forms.Label();
            this.ctrl_cb_examName = new System.Windows.Forms.ComboBox();
            this.ctrl_tb_duration = new System.Windows.Forms.TextBox();
            this.ind_lbl_duration = new System.Windows.Forms.Label();
            this.ctrl_btn_addExam = new System.Windows.Forms.Button();
            this.ctrl_btn_updateExam = new System.Windows.Forms.Button();
            this.ctrl_btn_delete = new System.Windows.Forms.Button();
            this.ctrl_btn_exit = new System.Windows.Forms.Button();
            this.ctrl_btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.horz_line_1 = new System.Windows.Forms.Label();
            this.uxReg = new System.Windows.Forms.DataGridView();
            this.examRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uxReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examRegistrationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ind_lbl_ExamAdmin
            // 
            this.ind_lbl_ExamAdmin.AutoSize = true;
            this.ind_lbl_ExamAdmin.Location = new System.Drawing.Point(12, 137);
            this.ind_lbl_ExamAdmin.Name = "ind_lbl_ExamAdmin";
            this.ind_lbl_ExamAdmin.Size = new System.Drawing.Size(208, 29);
            this.ind_lbl_ExamAdmin.TabIndex = 0;
            this.ind_lbl_ExamAdmin.Text = "Exam Administrator";
            // 
            // ctrl_cb_examAdmin
            // 
            this.ctrl_cb_examAdmin.FormattingEnabled = true;
            this.ctrl_cb_examAdmin.Location = new System.Drawing.Point(180, 134);
            this.ctrl_cb_examAdmin.Name = "ctrl_cb_examAdmin";
            this.ctrl_cb_examAdmin.Size = new System.Drawing.Size(222, 37);
            this.ctrl_cb_examAdmin.TabIndex = 2;
            this.ctrl_cb_examAdmin.SelectionChangeCommitted += new System.EventHandler(this.ctrl_cb_examAdmin_SelectionChangeCommitted);
            // 
            // ind_lbl_Institution
            // 
            this.ind_lbl_Institution.AutoSize = true;
            this.ind_lbl_Institution.Location = new System.Drawing.Point(12, 100);
            this.ind_lbl_Institution.Name = "ind_lbl_Institution";
            this.ind_lbl_Institution.Size = new System.Drawing.Size(114, 29);
            this.ind_lbl_Institution.TabIndex = 0;
            this.ind_lbl_Institution.Text = "Institution";
            // 
            // ctrl_cb_institution
            // 
            this.ctrl_cb_institution.FormattingEnabled = true;
            this.ctrl_cb_institution.Location = new System.Drawing.Point(180, 97);
            this.ctrl_cb_institution.Name = "ctrl_cb_institution";
            this.ctrl_cb_institution.Size = new System.Drawing.Size(222, 37);
            this.ctrl_cb_institution.TabIndex = 1;
            this.ctrl_cb_institution.SelectionChangeCommitted += new System.EventHandler(this.ctrl_cb_institution_SelectionChangeCommitted);
            // 
            // ind_lbl_examName
            // 
            this.ind_lbl_examName.AutoSize = true;
            this.ind_lbl_examName.Location = new System.Drawing.Point(12, 174);
            this.ind_lbl_examName.Name = "ind_lbl_examName";
            this.ind_lbl_examName.Size = new System.Drawing.Size(130, 29);
            this.ind_lbl_examName.TabIndex = 0;
            this.ind_lbl_examName.Text = "Exam Name";
            // 
            // ctrl_cb_examName
            // 
            this.ctrl_cb_examName.FormattingEnabled = true;
            this.ctrl_cb_examName.Location = new System.Drawing.Point(180, 171);
            this.ctrl_cb_examName.Name = "ctrl_cb_examName";
            this.ctrl_cb_examName.Size = new System.Drawing.Size(222, 37);
            this.ctrl_cb_examName.TabIndex = 3;
            this.ctrl_cb_examName.SelectionChangeCommitted += new System.EventHandler(this.ctrl_cb_examName_SelectionChangeCommitted);
            // 
            // ctrl_tb_duration
            // 
            this.ctrl_tb_duration.Location = new System.Drawing.Point(180, 209);
            this.ctrl_tb_duration.Name = "ctrl_tb_duration";
            this.ctrl_tb_duration.Size = new System.Drawing.Size(222, 36);
            this.ctrl_tb_duration.TabIndex = 4;
            // 
            // ind_lbl_duration
            // 
            this.ind_lbl_duration.AutoSize = true;
            this.ind_lbl_duration.Location = new System.Drawing.Point(12, 212);
            this.ind_lbl_duration.Name = "ind_lbl_duration";
            this.ind_lbl_duration.Size = new System.Drawing.Size(100, 29);
            this.ind_lbl_duration.TabIndex = 0;
            this.ind_lbl_duration.Text = "Duration";
            // 
            // ctrl_btn_addExam
            // 
            this.ctrl_btn_addExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(182)))), ((int)(((byte)(80)))));
            this.ctrl_btn_addExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrl_btn_addExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrl_btn_addExam.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrl_btn_addExam.ForeColor = System.Drawing.Color.White;
            this.ctrl_btn_addExam.Location = new System.Drawing.Point(436, 97);
            this.ctrl_btn_addExam.Name = "ctrl_btn_addExam";
            this.ctrl_btn_addExam.Size = new System.Drawing.Size(146, 31);
            this.ctrl_btn_addExam.TabIndex = 5;
            this.ctrl_btn_addExam.Text = "&Add Exam";
            this.ctrl_btn_addExam.UseVisualStyleBackColor = false;
            this.ctrl_btn_addExam.Click += new System.EventHandler(this.ctrl_btn_addExam_Click);
            // 
            // ctrl_btn_updateExam
            // 
            this.ctrl_btn_updateExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(182)))), ((int)(((byte)(80)))));
            this.ctrl_btn_updateExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrl_btn_updateExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrl_btn_updateExam.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrl_btn_updateExam.ForeColor = System.Drawing.Color.White;
            this.ctrl_btn_updateExam.Location = new System.Drawing.Point(436, 134);
            this.ctrl_btn_updateExam.Name = "ctrl_btn_updateExam";
            this.ctrl_btn_updateExam.Size = new System.Drawing.Size(146, 31);
            this.ctrl_btn_updateExam.TabIndex = 6;
            this.ctrl_btn_updateExam.Text = "&Update Exam";
            this.ctrl_btn_updateExam.UseVisualStyleBackColor = false;
            this.ctrl_btn_updateExam.Click += new System.EventHandler(this.ctrl_btn_updateExam_Click);
            // 
            // ctrl_btn_delete
            // 
            this.ctrl_btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(182)))), ((int)(((byte)(80)))));
            this.ctrl_btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrl_btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrl_btn_delete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrl_btn_delete.ForeColor = System.Drawing.Color.White;
            this.ctrl_btn_delete.Location = new System.Drawing.Point(436, 171);
            this.ctrl_btn_delete.Name = "ctrl_btn_delete";
            this.ctrl_btn_delete.Size = new System.Drawing.Size(146, 31);
            this.ctrl_btn_delete.TabIndex = 7;
            this.ctrl_btn_delete.Text = "&Delete Exam";
            this.ctrl_btn_delete.UseVisualStyleBackColor = false;
            this.ctrl_btn_delete.Click += new System.EventHandler(this.ctrl_btn_delete_Click);
            // 
            // ctrl_btn_exit
            // 
            this.ctrl_btn_exit.BackColor = System.Drawing.Color.IndianRed;
            this.ctrl_btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrl_btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrl_btn_exit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrl_btn_exit.ForeColor = System.Drawing.Color.White;
            this.ctrl_btn_exit.Location = new System.Drawing.Point(551, 209);
            this.ctrl_btn_exit.Name = "ctrl_btn_exit";
            this.ctrl_btn_exit.Size = new System.Drawing.Size(31, 31);
            this.ctrl_btn_exit.TabIndex = 9;
            this.ctrl_btn_exit.Text = "X";
            this.ctrl_btn_exit.UseVisualStyleBackColor = false;
            this.ctrl_btn_exit.Click += new System.EventHandler(this.ctrl_btn_exit_Click);
            // 
            // ctrl_btn_clear
            // 
            this.ctrl_btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(182)))), ((int)(((byte)(80)))));
            this.ctrl_btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctrl_btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrl_btn_clear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrl_btn_clear.ForeColor = System.Drawing.Color.White;
            this.ctrl_btn_clear.Location = new System.Drawing.Point(436, 209);
            this.ctrl_btn_clear.Name = "ctrl_btn_clear";
            this.ctrl_btn_clear.Size = new System.Drawing.Size(109, 31);
            this.ctrl_btn_clear.TabIndex = 8;
            this.ctrl_btn_clear.Text = "&Clear";
            this.ctrl_btn_clear.UseVisualStyleBackColor = false;
            this.ctrl_btn_clear.Click += new System.EventHandler(this.ctrl_btn_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXAM EDITOR";
            // 
            // horz_line_1
            // 
            this.horz_line_1.BackColor = System.Drawing.Color.Transparent;
            this.horz_line_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horz_line_1.Location = new System.Drawing.Point(12, 83);
            this.horz_line_1.Name = "horz_line_1";
            this.horz_line_1.Size = new System.Drawing.Size(571, 2);
            this.horz_line_1.TabIndex = 0;
            // 
            // uxReg
            // 
            this.uxReg.AutoGenerateColumns = false;
            this.uxReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxReg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.examNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.PhoneNum});
            this.uxReg.DataSource = this.examRegistrationBindingSource;
            this.uxReg.Location = new System.Drawing.Point(12, 277);
            this.uxReg.Name = "uxReg";
            this.uxReg.RowHeadersWidth = 51;
            this.uxReg.RowTemplate.Height = 24;
            this.uxReg.Size = new System.Drawing.Size(626, 150);
            this.uxReg.TabIndex = 10;
            // 
            // examRegistrationBindingSource
            // 
            this.examRegistrationBindingSource.DataSource = typeof(InvigulusData.ExamRegistration);
            // 
            // examNameDataGridViewTextBoxColumn
            // 
            this.examNameDataGridViewTextBoxColumn.DataPropertyName = "ExamName";
            this.examNameDataGridViewTextBoxColumn.HeaderText = "Exam Name";
            this.examNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.examNameDataGridViewTextBoxColumn.Name = "examNameDataGridViewTextBoxColumn";
            this.examNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // PhoneNum
            // 
            this.PhoneNum.DataPropertyName = "PhoneNum";
            this.PhoneNum.HeaderText = "PhoneNum";
            this.PhoneNum.MinimumWidth = 6;
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Width = 125;
            // 
            // ExamForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Invigulus_ExamMaintenance.Properties.Resources.LOGO_Invigulus_logo_250;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(670, 510);
            this.Controls.Add(this.uxReg);
            this.Controls.Add(this.horz_line_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrl_btn_exit);
            this.Controls.Add(this.ctrl_btn_clear);
            this.Controls.Add(this.ctrl_btn_delete);
            this.Controls.Add(this.ctrl_btn_updateExam);
            this.Controls.Add(this.ctrl_btn_addExam);
            this.Controls.Add(this.ctrl_tb_duration);
            this.Controls.Add(this.ctrl_cb_institution);
            this.Controls.Add(this.ind_lbl_Institution);
            this.Controls.Add(this.ctrl_cb_examName);
            this.Controls.Add(this.ind_lbl_duration);
            this.Controls.Add(this.ind_lbl_examName);
            this.Controls.Add(this.ctrl_cb_examAdmin);
            this.Controls.Add(this.ind_lbl_ExamAdmin);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(688, 557);
            this.MinimumSize = new System.Drawing.Size(688, 557);
            this.Name = "ExamForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVIGULUS - Exams";
            this.Load += new System.EventHandler(this.ExamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examRegistrationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ind_lbl_ExamAdmin;
        private System.Windows.Forms.ComboBox ctrl_cb_examAdmin;
        private System.Windows.Forms.Label ind_lbl_Institution;
        private System.Windows.Forms.ComboBox ctrl_cb_institution;
        private System.Windows.Forms.Label ind_lbl_examName;
        private System.Windows.Forms.ComboBox ctrl_cb_examName;
        private System.Windows.Forms.TextBox ctrl_tb_duration;
        private System.Windows.Forms.Label ind_lbl_duration;
        private System.Windows.Forms.Button ctrl_btn_addExam;
        private System.Windows.Forms.Button ctrl_btn_updateExam;
        private System.Windows.Forms.Button ctrl_btn_delete;
        private System.Windows.Forms.Button ctrl_btn_exit;
        private System.Windows.Forms.Button ctrl_btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label horz_line_1;
        private System.Windows.Forms.DataGridView uxReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource examRegistrationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn examNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
    }
}
