namespace ClientREST_form
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAlbumID = new System.Windows.Forms.Label();
            this.textBoxAlbumID = new System.Windows.Forms.TextBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.textBoxThumbnailUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(16, 30);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(62, 20);
            this.textBoxID.TabIndex = 0;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(16, 109);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(203, 20);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(13, 15);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID";
            this.labelID.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(13, 94);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Title";
            this.labelTitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelAlbumID
            // 
            this.labelAlbumID.AutoSize = true;
            this.labelAlbumID.Location = new System.Drawing.Point(13, 54);
            this.labelAlbumID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlbumID.Name = "labelAlbumID";
            this.labelAlbumID.Size = new System.Drawing.Size(47, 13);
            this.labelAlbumID.TabIndex = 5;
            this.labelAlbumID.Text = "AlbumID";
            this.labelAlbumID.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // textBoxAlbumID
            // 
            this.textBoxAlbumID.Location = new System.Drawing.Point(16, 69);
            this.textBoxAlbumID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAlbumID.Name = "textBoxAlbumID";
            this.textBoxAlbumID.Size = new System.Drawing.Size(203, 20);
            this.textBoxAlbumID.TabIndex = 4;
            this.textBoxAlbumID.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(126, 214);
            this.buttonRead.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(113, 21);
            this.buttonRead.TabIndex = 6;
            this.buttonRead.Text = "READ";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(16, 146);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(203, 20);
            this.textBoxUrl.TabIndex = 7;
            // 
            // textBoxThumbnailUrl
            // 
            this.textBoxThumbnailUrl.Location = new System.Drawing.Point(16, 183);
            this.textBoxThumbnailUrl.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxThumbnailUrl.Name = "textBoxThumbnailUrl";
            this.textBoxThumbnailUrl.Size = new System.Drawing.Size(203, 20);
            this.textBoxThumbnailUrl.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Url";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ThumbnailUrl";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 214);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 21);
            this.button1.TabIndex = 11;
            this.button1.Text = "CREATE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 214);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 21);
            this.button2.TabIndex = 12;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(360, 214);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 21);
            this.button3.TabIndex = 13;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 246);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxThumbnailUrl);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.labelAlbumID);
            this.Controls.Add(this.textBoxAlbumID);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Sample Client REST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAlbumID;
        private System.Windows.Forms.TextBox textBoxAlbumID;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.TextBox textBoxThumbnailUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

