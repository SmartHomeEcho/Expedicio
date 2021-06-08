namespace radio_winform_ContRolix
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.iconform3 = new System.Windows.Forms.PictureBox();
            this.icon_kesleltetes = new System.Windows.Forms.Timer(this.components);
            this.OK = new Bunifu.Framework.UI.BunifuThinButton2();
            this.form3label1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.iconform3)).BeginInit();
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
            this.bunifuFormFadeTransition1.TransitionEnd += new System.EventHandler(this.bunifuFormFadeTransition1_TransitionEnd);
            // 
            // iconform3
            // 
            this.iconform3.Image = ((System.Drawing.Image)(resources.GetObject("iconform3.Image")));
            this.iconform3.Location = new System.Drawing.Point(98, 12);
            this.iconform3.Name = "iconform3";
            this.iconform3.Size = new System.Drawing.Size(400, 340);
            this.iconform3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconform3.TabIndex = 0;
            this.iconform3.TabStop = false;
            // 
            // icon_kesleltetes
            // 
            this.icon_kesleltetes.Enabled = true;
            this.icon_kesleltetes.Interval = 4000;
            this.icon_kesleltetes.Tick += new System.EventHandler(this.icon_kesleltetes_Tick);
            // 
            // OK
            // 
            this.OK.ActiveBorderThickness = 1;
            this.OK.ActiveCornerRadius = 30;
            this.OK.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.OK.ActiveForecolor = System.Drawing.Color.White;
            this.OK.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.OK.BackColor = System.Drawing.Color.White;
            this.OK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OK.BackgroundImage")));
            this.OK.ButtonText = "OK";
            this.OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.ForeColor = System.Drawing.Color.SeaGreen;
            this.OK.IdleBorderThickness = 1;
            this.OK.IdleCornerRadius = 30;
            this.OK.IdleFillColor = System.Drawing.Color.White;
            this.OK.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.OK.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.OK.Location = new System.Drawing.Point(187, 390);
            this.OK.Margin = new System.Windows.Forms.Padding(5);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(218, 66);
            this.OK.TabIndex = 1;
            this.OK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // form3label1
            // 
            this.form3label1.AutoSize = true;
            this.form3label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.form3label1.Location = new System.Drawing.Point(97, 355);
            this.form3label1.Name = "form3label1";
            this.form3label1.Size = new System.Drawing.Size(401, 30);
            this.form3label1.TabIndex = 2;
            this.form3label1.Text = "Az aadas.txt fájl írása megtörtént";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.form3label1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.iconform3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconform3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.PictureBox iconform3;
        private System.Windows.Forms.Timer icon_kesleltetes;
        private Bunifu.Framework.UI.BunifuThinButton2 OK;
        public Bunifu.Framework.UI.BunifuCustomLabel form3label1;
    }
}