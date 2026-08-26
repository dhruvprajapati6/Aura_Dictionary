namespace Aura_dectionary
{
    partial class v
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
            this.txtword = new System.Windows.Forms.TextBox();
            this.lblword = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.lblmeaningtitel = new System.Windows.Forms.Label();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.lblSynonymTitle = new System.Windows.Forms.Label();
            this.lblSynonym = new System.Windows.Forms.Label();
            this.lblAntonymTitle = new System.Windows.Forms.Label();
            this.lblAntonym = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDictonary = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.lstSuggestions = new System.Windows.Forms.ListBox();
            this.btnclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtword
            // 
            this.txtword.Location = new System.Drawing.Point(187, 157);
            this.txtword.Name = "txtword";
            this.txtword.Size = new System.Drawing.Size(562, 22);
            this.txtword.TabIndex = 7;
            this.txtword.TextChanged += new System.EventHandler(this.txtword_TextChanged);
            // 
            // lblword
            // 
            this.lblword.AutoSize = true;
            this.lblword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblword.Location = new System.Drawing.Point(24, 154);
            this.lblword.Name = "lblword";
            this.lblword.Size = new System.Drawing.Size(144, 23);
            this.lblword.TabIndex = 6;
            this.lblword.Text = "Find The word :";
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(338, 210);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(141, 44);
            this.btnsearch.TabIndex = 15;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblmeaningtitel
            // 
            this.lblmeaningtitel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmeaningtitel.Location = new System.Drawing.Point(25, 285);
            this.lblmeaningtitel.Name = "lblmeaningtitel";
            this.lblmeaningtitel.Size = new System.Drawing.Size(144, 23);
            this.lblmeaningtitel.TabIndex = 16;
            this.lblmeaningtitel.Text = "Meaning :";
            // 
            // lblMeaning
            // 
            this.lblMeaning.AutoSize = true;
            this.lblMeaning.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeaning.Location = new System.Drawing.Point(25, 321);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(0, 23);
            this.lblMeaning.TabIndex = 17;
            // 
            // lblSynonymTitle
            // 
            this.lblSynonymTitle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSynonymTitle.Location = new System.Drawing.Point(24, 372);
            this.lblSynonymTitle.Name = "lblSynonymTitle";
            this.lblSynonymTitle.Size = new System.Drawing.Size(93, 23);
            this.lblSynonymTitle.TabIndex = 18;
            this.lblSynonymTitle.Text = "Synonym :";
            // 
            // lblSynonym
            // 
            this.lblSynonym.AutoSize = true;
            this.lblSynonym.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSynonym.Location = new System.Drawing.Point(24, 395);
            this.lblSynonym.Name = "lblSynonym";
            this.lblSynonym.Size = new System.Drawing.Size(0, 23);
            this.lblSynonym.TabIndex = 19;
            // 
            // lblAntonymTitle
            // 
            this.lblAntonymTitle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntonymTitle.Location = new System.Drawing.Point(25, 460);
            this.lblAntonymTitle.Name = "lblAntonymTitle";
            this.lblAntonymTitle.Size = new System.Drawing.Size(99, 23);
            this.lblAntonymTitle.TabIndex = 20;
            this.lblAntonymTitle.Text = "Antonym :";
            // 
            // lblAntonym
            // 
            this.lblAntonym.AutoSize = true;
            this.lblAntonym.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntonym.Location = new System.Drawing.Point(26, 483);
            this.lblAntonym.Name = "lblAntonym";
            this.lblAntonym.Size = new System.Drawing.Size(0, 23);
            this.lblAntonym.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox1.Location = new System.Drawing.Point(49, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 96);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lblDictonary
            // 
            this.lblDictonary.AutoSize = true;
            this.lblDictonary.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDictonary.Location = new System.Drawing.Point(231, 44);
            this.lblDictonary.Name = "lblDictonary";
            this.lblDictonary.Size = new System.Drawing.Size(233, 33);
            this.lblDictonary.TabIndex = 23;
            this.lblDictonary.Text = "Search The items :";
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(661, 210);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(127, 44);
            this.btnback.TabIndex = 38;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lstSuggestions
            // 
            this.lstSuggestions.FormattingEnabled = true;
            this.lstSuggestions.ItemHeight = 16;
            this.lstSuggestions.Location = new System.Drawing.Point(187, 185);
            this.lstSuggestions.Name = "lstSuggestions";
            this.lstSuggestions.Size = new System.Drawing.Size(120, 260);
            this.lstSuggestions.TabIndex = 39;
            this.lstSuggestions.Visible = false;
            this.lstSuggestions.SelectedIndexChanged += new System.EventHandler(this.lstSuggestions_SelectedIndexChanged);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(504, 210);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(127, 44);
            this.btnclear.TabIndex = 40;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // v
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aura_dectionary.Properties.Resources.Gemini_Generated_Image_89duom89duom89du;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lstSuggestions);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblDictonary);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAntonym);
            this.Controls.Add(this.lblAntonymTitle);
            this.Controls.Add(this.lblSynonym);
            this.Controls.Add(this.lblSynonymTitle);
            this.Controls.Add(this.lblMeaning);
            this.Controls.Add(this.lblmeaningtitel);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtword);
            this.Controls.Add(this.lblword);
            this.DoubleBuffered = true;
            this.Name = "v";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Word";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDictionary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtword;
        private System.Windows.Forms.Label lblword;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label lblmeaningtitel;
        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.Label lblSynonymTitle;
        private System.Windows.Forms.Label lblSynonym;
        private System.Windows.Forms.Label lblAntonymTitle;
        private System.Windows.Forms.Label lblAntonym;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDictonary;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ListBox lstSuggestions;
        private System.Windows.Forms.Button btnclear;
    }
}