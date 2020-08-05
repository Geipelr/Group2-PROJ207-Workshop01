namespace Invigulus_ExamMaintenance
{
    partial class AddUpdateExamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateExamForm));
            this.ctrl_tb_duration = new System.Windows.Forms.TextBox();
            this.ctrl_tb_url = new System.Windows.Forms.TextBox();
            this.ctrl_tb_permattempt = new System.Windows.Forms.TextBox();
            this.ctrl_btn_ok = new System.Windows.Forms.Button();
            this.ctrl_btn_cancel = new System.Windows.Forms.Button();
            this.ind_lbl_examName = new System.Windows.Forms.Label();
            this.ind_lbl_Duration = new System.Windows.Forms.Label();
            this.ind_lbl_ExamURL = new System.Windows.Forms.Label();
            this.ind_lbl_PerAttemps = new System.Windows.Forms.Label();
            this.ind_lbl_formtitle = new System.Windows.Forms.Label();
            this.ctrl_tb_examname = new System.Windows.Forms.TextBox();
            this.horz_line_1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrl_tb_duration
            // 
            this.ctrl_tb_duration.Location = new System.Drawing.Point(213, 172);
            this.ctrl_tb_duration.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ctrl_tb_duration.Name = "ctrl_tb_duration";
            this.ctrl_tb_duration.Size = new System.Drawing.Size(246, 36);
            this.ctrl_tb_duration.TabIndex = 3;
            // 
            // ctrl_tb_url
            // 
            this.ctrl_tb_url.Location = new System.Drawing.Point(213, 254);
            this.ctrl_tb_url.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ctrl_tb_url.Name = "ctrl_tb_url";
            this.ctrl_tb_url.Size = new System.Drawing.Size(246, 36);
            this.ctrl_tb_url.TabIndex = 5;
            // 
            // ctrl_tb_permattempt
            // 
            this.ctrl_tb_permattempt.Location = new System.Drawing.Point(213, 213);
            this.ctrl_tb_permattempt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ctrl_tb_permattempt.Name = "ctrl_tb_permattempt";
            this.ctrl_tb_permattempt.Size = new System.Drawing.Size(246, 36);
            this.ctrl_tb_permattempt.TabIndex = 4;
            // 
            // ctrl_btn_ok
            // 
            this.ctrl_btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(182)))), ((int)(((byte)(80)))));
            this.ctrl_btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrl_btn_ok.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.ctrl_btn_ok.ForeColor = System.Drawing.Color.White;
            this.ctrl_btn_ok.Location = new System.Drawing.Point(125, 312);
            this.ctrl_btn_ok.Name = "ctrl_btn_ok";
            this.ctrl_btn_ok.Size = new System.Drawing.Size(162, 36);
            this.ctrl_btn_ok.TabIndex = 6;
            this.ctrl_btn_ok.Text = "OK";
            this.ctrl_btn_ok.UseVisualStyleBackColor = false;
            this.ctrl_btn_ok.Click += new System.EventHandler(this.ctrl_btn_ok_Click);
            // 
            // ctrl_btn_cancel
            // 
            this.ctrl_btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(182)))), ((int)(((byte)(80)))));
            this.ctrl_btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrl_btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctrl_btn_cancel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.ctrl_btn_cancel.ForeColor = System.Drawing.Color.White;
            this.ctrl_btn_cancel.Location = new System.Drawing.Point(299, 312);
            this.ctrl_btn_cancel.Name = "ctrl_btn_cancel";
            this.ctrl_btn_cancel.Size = new System.Drawing.Size(162, 36);
            this.ctrl_btn_cancel.TabIndex = 7;
            this.ctrl_btn_cancel.Text = "Cancel";
            this.ctrl_btn_cancel.UseVisualStyleBackColor = false;
            this.ctrl_btn_cancel.Click += new System.EventHandler(this.ctrl_btn_cancel_Click);
            // 
            // ind_lbl_examName
            // 
            this.ind_lbl_examName.AutoSize = true;
            this.ind_lbl_examName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ind_lbl_examName.Location = new System.Drawing.Point(24, 136);
            this.ind_lbl_examName.Name = "ind_lbl_examName";
            this.ind_lbl_examName.Size = new System.Drawing.Size(130, 29);
            this.ind_lbl_examName.TabIndex = 0;
            this.ind_lbl_examName.Text = "Exam Name";
            // 
            // ind_lbl_Duration
            // 
            this.ind_lbl_Duration.AutoSize = true;
            this.ind_lbl_Duration.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ind_lbl_Duration.Location = new System.Drawing.Point(24, 175);
            this.ind_lbl_Duration.Name = "ind_lbl_Duration";
            this.ind_lbl_Duration.Size = new System.Drawing.Size(100, 29);
            this.ind_lbl_Duration.TabIndex = 0;
            this.ind_lbl_Duration.Text = "Duration";
            // 
            // ind_lbl_ExamURL
            // 
            this.ind_lbl_ExamURL.AutoSize = true;
            this.ind_lbl_ExamURL.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ind_lbl_ExamURL.Location = new System.Drawing.Point(24, 258);
            this.ind_lbl_ExamURL.Name = "ind_lbl_ExamURL";
            this.ind_lbl_ExamURL.Size = new System.Drawing.Size(109, 29);
            this.ind_lbl_ExamURL.TabIndex = 0;
            this.ind_lbl_ExamURL.Text = "Exam URL";
            // 
            // ind_lbl_PerAttemps
            // 
            this.ind_lbl_PerAttemps.AutoSize = true;
            this.ind_lbl_PerAttemps.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ind_lbl_PerAttemps.Location = new System.Drawing.Point(24, 216);
            this.ind_lbl_PerAttemps.Name = "ind_lbl_PerAttemps";
            this.ind_lbl_PerAttemps.Size = new System.Drawing.Size(204, 29);
            this.ind_lbl_PerAttemps.TabIndex = 0;
            this.ind_lbl_PerAttemps.Text = "Permitted Attempts";
            // 
            // ind_lbl_formtitle
            // 
            this.ind_lbl_formtitle.AutoSize = true;
            this.ind_lbl_formtitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.ind_lbl_formtitle.Location = new System.Drawing.Point(2, 72);
            this.ind_lbl_formtitle.Name = "ind_lbl_formtitle";
            this.ind_lbl_formtitle.Size = new System.Drawing.Size(303, 33);
            this.ind_lbl_formtitle.TabIndex = 0;
            this.ind_lbl_formtitle.Text = "ADD/UPDATE EXAM PAGE";
            this.ind_lbl_formtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrl_tb_examname
            // 
            this.ctrl_tb_examname.Location = new System.Drawing.Point(213, 133);
            this.ctrl_tb_examname.Name = "ctrl_tb_examname";
            this.ctrl_tb_examname.Size = new System.Drawing.Size(246, 36);
            this.ctrl_tb_examname.TabIndex = 2;
            // 
            // horz_line_1
            // 
            this.horz_line_1.BackColor = System.Drawing.Color.Transparent;
            this.horz_line_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horz_line_1.Location = new System.Drawing.Point(8, 102);
            this.horz_line_1.Name = "horz_line_1";
            this.horz_line_1.Size = new System.Drawing.Size(456, 2);
            this.horz_line_1.TabIndex = 0;
            // 
            // AddUpdateExamForm
            // 
            this.AcceptButton = this.ctrl_btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Invigulus_ExamMaintenance.Properties.Resources.LOGO_Invigulus_logo_250;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.ctrl_btn_cancel;
            this.ClientSize = new System.Drawing.Size(477, 375);
            this.Controls.Add(this.horz_line_1);
            this.Controls.Add(this.ctrl_tb_examname);
            this.Controls.Add(this.ind_lbl_formtitle);
            this.Controls.Add(this.ind_lbl_PerAttemps);
            this.Controls.Add(this.ind_lbl_ExamURL);
            this.Controls.Add(this.ind_lbl_Duration);
            this.Controls.Add(this.ind_lbl_examName);
            this.Controls.Add(this.ctrl_btn_cancel);
            this.Controls.Add(this.ctrl_btn_ok);
            this.Controls.Add(this.ctrl_tb_permattempt);
            this.Controls.Add(this.ctrl_tb_url);
            this.Controls.Add(this.ctrl_tb_duration);
            this.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(495, 422);
            this.MinimumSize = new System.Drawing.Size(495, 422);
            this.Name = "AddUpdateExamForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUpdateExamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctrl_tb_duration;
        private System.Windows.Forms.TextBox ctrl_tb_url;
        private System.Windows.Forms.TextBox ctrl_tb_permattempt;
        private System.Windows.Forms.Button ctrl_btn_ok;
        private System.Windows.Forms.Button ctrl_btn_cancel;
        private System.Windows.Forms.Label ind_lbl_examName;
        private System.Windows.Forms.Label ind_lbl_Duration;
        private System.Windows.Forms.Label ind_lbl_ExamURL;
        private System.Windows.Forms.Label ind_lbl_PerAttemps;
        private System.Windows.Forms.TextBox ctrl_tb_examname;
        private System.Windows.Forms.Label horz_line_1;
        private System.Windows.Forms.Label ind_lbl_formtitle;
    }
}