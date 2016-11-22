namespace EncryptPdf2Email
{
    partial class DirectorForm
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
            this.gv_directors = new System.Windows.Forms.DataGridView();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_directors)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_directors
            // 
            this.gv_directors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_directors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_directors.Location = new System.Drawing.Point(0, 2);
            this.gv_directors.Name = "gv_directors";
            this.gv_directors.Size = new System.Drawing.Size(447, 466);
            this.gv_directors.TabIndex = 0;
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(0, 468);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(80, 24);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "Continue";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(355, 468);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(92, 24);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // DirectorForm
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 492);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.gv_directors);
            this.Name = "DirectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Site Code and Email Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DirectorForm_FormClosed);
            this.Load += new System.EventHandler(this.DirectorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_directors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_directors;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}