namespace EncryptPdf2Email
{
    partial class EmailForm
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
            this.rtxt_BodyEmail = new System.Windows.Forms.RichTextBox();
            this.txt_SubjectEmail = new System.Windows.Forms.TextBox();
            this.lbl_Body = new System.Windows.Forms.Label();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.btn_EmailFormFinished = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxt_BodyEmail
            // 
            this.rtxt_BodyEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_BodyEmail.Location = new System.Drawing.Point(12, 96);
            this.rtxt_BodyEmail.Name = "rtxt_BodyEmail";
            this.rtxt_BodyEmail.Size = new System.Drawing.Size(577, 96);
            this.rtxt_BodyEmail.TabIndex = 1;
            this.rtxt_BodyEmail.Text = "";
            // 
            // txt_SubjectEmail
            // 
            this.txt_SubjectEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SubjectEmail.Location = new System.Drawing.Point(13, 37);
            this.txt_SubjectEmail.Name = "txt_SubjectEmail";
            this.txt_SubjectEmail.Size = new System.Drawing.Size(576, 26);
            this.txt_SubjectEmail.TabIndex = 0;
            // 
            // lbl_Body
            // 
            this.lbl_Body.AutoSize = true;
            this.lbl_Body.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Body.Location = new System.Drawing.Point(13, 75);
            this.lbl_Body.Name = "lbl_Body";
            this.lbl_Body.Size = new System.Drawing.Size(46, 18);
            this.lbl_Body.TabIndex = 2;
            this.lbl_Body.Text = "Body:";
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subject.Location = new System.Drawing.Point(13, 16);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(61, 18);
            this.lbl_Subject.TabIndex = 3;
            this.lbl_Subject.Text = "Subject:";
            // 
            // btn_EmailFormFinished
            // 
            this.btn_EmailFormFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EmailFormFinished.Location = new System.Drawing.Point(514, 6);
            this.btn_EmailFormFinished.Name = "btn_EmailFormFinished";
            this.btn_EmailFormFinished.Size = new System.Drawing.Size(75, 23);
            this.btn_EmailFormFinished.TabIndex = 2;
            this.btn_EmailFormFinished.Text = "Finish";
            this.btn_EmailFormFinished.UseVisualStyleBackColor = true;
            this.btn_EmailFormFinished.Click += new System.EventHandler(this.btn_EmailFormFinished_Click);
            // 
            // EmailForm
            // 
            this.AcceptButton = this.btn_EmailFormFinished;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 204);
            this.Controls.Add(this.btn_EmailFormFinished);
            this.Controls.Add(this.lbl_Subject);
            this.Controls.Add(this.lbl_Body);
            this.Controls.Add(this.txt_SubjectEmail);
            this.Controls.Add(this.rtxt_BodyEmail);
            this.Name = "EmailForm";
            this.Text = "Email Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_BodyEmail;
        private System.Windows.Forms.TextBox txt_SubjectEmail;
        private System.Windows.Forms.Label lbl_Body;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.Button btn_EmailFormFinished;
    }
}