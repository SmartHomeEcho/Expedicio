namespace radio_winform_ContRolix
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kilepestext = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.igengomb = new Bunifu.Framework.UI.BunifuTileButton();
            this.nemgomb = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // kilepestext
            // 
            this.kilepestext.BorderColorFocused = System.Drawing.Color.Blue;
            this.kilepestext.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kilepestext.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.kilepestext.BorderThickness = 3;
            this.kilepestext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kilepestext.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kilepestext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kilepestext.isPassword = false;
            this.kilepestext.Location = new System.Drawing.Point(115, 15);
            this.kilepestext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.kilepestext.Name = "kilepestext";
            this.kilepestext.Size = new System.Drawing.Size(432, 69);
            this.kilepestext.TabIndex = 5;
            this.kilepestext.Text = "Ki szeretnél lépni az alkalmazásból?";
            this.kilepestext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // igengomb
            // 
            this.igengomb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.igengomb.color = System.Drawing.Color.White;
            this.igengomb.colorActive = System.Drawing.Color.Red;
            this.igengomb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.igengomb.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.igengomb.ForeColor = System.Drawing.Color.White;
            this.igengomb.Image = ((System.Drawing.Image)(resources.GetObject("igengomb.Image")));
            this.igengomb.ImagePosition = 20;
            this.igengomb.ImageZoom = 50;
            this.igengomb.LabelPosition = 41;
            this.igengomb.LabelText = "IGEN";
            this.igengomb.Location = new System.Drawing.Point(67, 154);
            this.igengomb.Margin = new System.Windows.Forms.Padding(6);
            this.igengomb.Name = "igengomb";
            this.igengomb.Size = new System.Drawing.Size(106, 117);
            this.igengomb.TabIndex = 6;
            this.igengomb.Click += new System.EventHandler(this.igengomb_Click);
            // 
            // nemgomb
            // 
            this.nemgomb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.nemgomb.color = System.Drawing.Color.SeaGreen;
            this.nemgomb.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.nemgomb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nemgomb.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.nemgomb.ForeColor = System.Drawing.Color.White;
            this.nemgomb.Image = ((System.Drawing.Image)(resources.GetObject("nemgomb.Image")));
            this.nemgomb.ImagePosition = 20;
            this.nemgomb.ImageZoom = 50;
            this.nemgomb.LabelPosition = 41;
            this.nemgomb.LabelText = "NEM";
            this.nemgomb.Location = new System.Drawing.Point(485, 154);
            this.nemgomb.Margin = new System.Windows.Forms.Padding(6);
            this.nemgomb.Name = "nemgomb";
            this.nemgomb.Size = new System.Drawing.Size(106, 117);
            this.nemgomb.TabIndex = 7;
            this.nemgomb.Click += new System.EventHandler(this.nemgomb_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(641, 308);
            this.Controls.Add(this.nemgomb);
            this.Controls.Add(this.igengomb);
            this.Controls.Add(this.kilepestext);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private Bunifu.Framework.UI.BunifuMetroTextbox kilepestext;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Bunifu.Framework.UI.BunifuTileButton nemgomb;
        public Bunifu.Framework.UI.BunifuTileButton igengomb;
    }
}