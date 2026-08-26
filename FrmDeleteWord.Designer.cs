namespace Aura_dectionary
{
    partial class FrmDeleteWord
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
            this.lblDictonary = new System.Windows.Forms.Label();
            this.txtdeleteword = new System.Windows.Forms.TextBox();
            this.lblword = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDictonary
            // 
            this.lblDictonary.AutoSize = true;
            this.lblDictonary.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDictonary.Location = new System.Drawing.Point(278, 41);
            this.lblDictonary.Name = "lblDictonary";
            this.lblDictonary.Size = new System.Drawing.Size(179, 33);
            this.lblDictonary.TabIndex = 27;
            this.lblDictonary.Text = "Delete Word :";
            // 
            // txtdeleteword
            // 
            this.txtdeleteword.Location = new System.Drawing.Point(204, 192);
            this.txtdeleteword.Name = "txtdeleteword";
            this.txtdeleteword.Size = new System.Drawing.Size(562, 22);
            this.txtdeleteword.TabIndex = 29;
            // 
            // lblword
            // 
            this.lblword.AutoSize = true;
            this.lblword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblword.Location = new System.Drawing.Point(63, 192);
            this.lblword.Name = "lblword";
            this.lblword.Size = new System.Drawing.Size(123, 23);
            this.lblword.TabIndex = 28;
            this.lblword.Text = "Delete word :";
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(460, 324);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(127, 44);
            this.btnback.TabIndex = 40;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(227, 324);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(141, 44);
            this.btndelete.TabIndex = 39;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 96);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDeleteWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aura_dectionary.Properties.Resources.Gemini_Generated_Image_q5win7q5win7q5wi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtdeleteword);
            this.Controls.Add(this.lblword);
            this.Controls.Add(this.lblDictonary);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmDeleteWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDeleteWord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDictonary;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtdeleteword;
        private System.Windows.Forms.Label lblword;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btndelete;
    }
}