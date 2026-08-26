namespace Aura_dectionary
{
    partial class FrmAddWord
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtword = new System.Windows.Forms.TextBox();
            this.lblword = new System.Windows.Forms.Label();
            this.txtmeaning = new System.Windows.Forms.TextBox();
            this.lblmeaning = new System.Windows.Forms.Label();
            this.txtSynonym = new System.Windows.Forms.TextBox();
            this.lblsynonym = new System.Windows.Forms.Label();
            this.txtantonym = new System.Windows.Forms.TextBox();
            this.lblantonym = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDictonary
            // 
            this.lblDictonary.AutoSize = true;
            this.lblDictonary.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDictonary.Location = new System.Drawing.Point(261, 65);
            this.lblDictonary.Name = "lblDictonary";
            this.lblDictonary.Size = new System.Drawing.Size(211, 33);
            this.lblDictonary.TabIndex = 25;
            this.lblDictonary.Text = "Add New Word :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox1.Location = new System.Drawing.Point(58, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 96);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // txtword
            // 
            this.txtword.Location = new System.Drawing.Point(175, 173);
            this.txtword.Name = "txtword";
            this.txtword.Size = new System.Drawing.Size(562, 22);
            this.txtword.TabIndex = 27;
            // 
            // lblword
            // 
            this.lblword.AutoSize = true;
            this.lblword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblword.Location = new System.Drawing.Point(33, 173);
            this.lblword.Name = "lblword";
            this.lblword.Size = new System.Drawing.Size(64, 23);
            this.lblword.TabIndex = 26;
            this.lblword.Text = "word :";
            // 
            // txtmeaning
            // 
            this.txtmeaning.Location = new System.Drawing.Point(175, 237);
            this.txtmeaning.Name = "txtmeaning";
            this.txtmeaning.Size = new System.Drawing.Size(562, 22);
            this.txtmeaning.TabIndex = 29;
            // 
            // lblmeaning
            // 
            this.lblmeaning.AutoSize = true;
            this.lblmeaning.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmeaning.Location = new System.Drawing.Point(33, 237);
            this.lblmeaning.Name = "lblmeaning";
            this.lblmeaning.Size = new System.Drawing.Size(93, 23);
            this.lblmeaning.TabIndex = 28;
            this.lblmeaning.Text = "Meaning :";
            // 
            // txtSynonym
            // 
            this.txtSynonym.Location = new System.Drawing.Point(175, 298);
            this.txtSynonym.Name = "txtSynonym";
            this.txtSynonym.Size = new System.Drawing.Size(562, 22);
            this.txtSynonym.TabIndex = 31;
            // 
            // lblsynonym
            // 
            this.lblsynonym.AutoSize = true;
            this.lblsynonym.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsynonym.Location = new System.Drawing.Point(33, 298);
            this.lblsynonym.Name = "lblsynonym";
            this.lblsynonym.Size = new System.Drawing.Size(99, 23);
            this.lblsynonym.TabIndex = 30;
            this.lblsynonym.Text = "Synonym :";
            // 
            // txtantonym
            // 
            this.txtantonym.Location = new System.Drawing.Point(175, 356);
            this.txtantonym.Name = "txtantonym";
            this.txtantonym.Size = new System.Drawing.Size(562, 22);
            this.txtantonym.TabIndex = 33;
            // 
            // lblantonym
            // 
            this.lblantonym.AutoSize = true;
            this.lblantonym.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblantonym.Location = new System.Drawing.Point(33, 356);
            this.lblantonym.Name = "lblantonym";
            this.lblantonym.Size = new System.Drawing.Size(98, 23);
            this.lblantonym.TabIndex = 32;
            this.lblantonym.Text = "Antonym :";
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(369, 465);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(127, 44);
            this.btnclear.TabIndex = 35;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(153, 465);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(141, 44);
            this.btnadd.TabIndex = 34;
            this.btnadd.Text = "Add Word";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(566, 465);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(127, 44);
            this.btnback.TabIndex = 36;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // FrmAddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aura_dectionary.Properties.Resources.Gemini_Generated_Image_mabe4cmabe4cmabe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtantonym);
            this.Controls.Add(this.lblantonym);
            this.Controls.Add(this.txtSynonym);
            this.Controls.Add(this.lblsynonym);
            this.Controls.Add(this.txtmeaning);
            this.Controls.Add(this.lblmeaning);
            this.Controls.Add(this.txtword);
            this.Controls.Add(this.lblword);
            this.Controls.Add(this.lblDictonary);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "FrmAddWord";
            this.Text = "FrmAddWord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDictonary;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtword;
        private System.Windows.Forms.Label lblword;
        private System.Windows.Forms.TextBox txtmeaning;
        private System.Windows.Forms.Label lblmeaning;
        private System.Windows.Forms.TextBox txtSynonym;
        private System.Windows.Forms.Label lblsynonym;
        private System.Windows.Forms.TextBox txtantonym;
        private System.Windows.Forms.Label lblantonym;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnback;
    }
}