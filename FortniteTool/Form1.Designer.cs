namespace FortniteTool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Largeurlbl = new System.Windows.Forms.Label();
            this.WidthTxtBox = new System.Windows.Forms.TextBox();
            this.HeightTxtBox = new System.Windows.Forms.TextBox();
            this.Hauteurlbl = new System.Windows.Forms.Label();
            this.FullscreenchckBox = new System.Windows.Forms.CheckBox();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.Sumlbl = new System.Windows.Forms.Label();
            this.mFPSTxtBox = new System.Windows.Forms.TextBox();
            this.mFPSlbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.transparentwidthlabel = new System.Windows.Forms.Label();
            this.transparentheightlabel = new System.Windows.Forms.Label();
            this.transparentmfpslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Largeurlbl
            // 
            this.Largeurlbl.AutoSize = true;
            this.Largeurlbl.ForeColor = System.Drawing.Color.White;
            this.Largeurlbl.Location = new System.Drawing.Point(32, 100);
            this.Largeurlbl.Name = "Largeurlbl";
            this.Largeurlbl.Size = new System.Drawing.Size(49, 13);
            this.Largeurlbl.TabIndex = 0;
            this.Largeurlbl.Text = "Largeur :";
            // 
            // WidthTxtBox
            // 
            this.WidthTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WidthTxtBox.Location = new System.Drawing.Point(32, 118);
            this.WidthTxtBox.MaxLength = 4;
            this.WidthTxtBox.Name = "WidthTxtBox";
            this.WidthTxtBox.Size = new System.Drawing.Size(265, 20);
            this.WidthTxtBox.TabIndex = 1;
            this.WidthTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WidthTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WidthTxtBox_KeyPress);
            // 
            // HeightTxtBox
            // 
            this.HeightTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightTxtBox.Location = new System.Drawing.Point(32, 202);
            this.HeightTxtBox.MaxLength = 4;
            this.HeightTxtBox.Name = "HeightTxtBox";
            this.HeightTxtBox.Size = new System.Drawing.Size(265, 20);
            this.HeightTxtBox.TabIndex = 2;
            this.HeightTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HeightTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightTxtBox_KeyPress);
            // 
            // Hauteurlbl
            // 
            this.Hauteurlbl.AutoSize = true;
            this.Hauteurlbl.ForeColor = System.Drawing.Color.White;
            this.Hauteurlbl.Location = new System.Drawing.Point(30, 185);
            this.Hauteurlbl.Name = "Hauteurlbl";
            this.Hauteurlbl.Size = new System.Drawing.Size(51, 13);
            this.Hauteurlbl.TabIndex = 3;
            this.Hauteurlbl.Text = "Hauteur :";
            // 
            // FullscreenchckBox
            // 
            this.FullscreenchckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FullscreenchckBox.AutoSize = true;
            this.FullscreenchckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FullscreenchckBox.ForeColor = System.Drawing.Color.White;
            this.FullscreenchckBox.Location = new System.Drawing.Point(28, 372);
            this.FullscreenchckBox.Name = "FullscreenchckBox";
            this.FullscreenchckBox.Size = new System.Drawing.Size(79, 17);
            this.FullscreenchckBox.TabIndex = 4;
            this.FullscreenchckBox.Text = "Plein écran";
            this.FullscreenchckBox.UseVisualStyleBackColor = true;
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyBtn.ForeColor = System.Drawing.Color.Black;
            this.ApplyBtn.Location = new System.Drawing.Point(230, 368);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(75, 23);
            this.ApplyBtn.TabIndex = 5;
            this.ApplyBtn.Text = "Appliquer";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // Sumlbl
            // 
            this.Sumlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Sumlbl.AutoSize = true;
            this.Sumlbl.ForeColor = System.Drawing.Color.White;
            this.Sumlbl.Location = new System.Drawing.Point(29, 331);
            this.Sumlbl.Name = "Sumlbl";
            this.Sumlbl.Size = new System.Drawing.Size(155, 13);
            this.Sumlbl.TabIndex = 6;
            this.Sumlbl.Text = "Resolution choisie : 1080x1080";
            // 
            // mFPSTxtBox
            // 
            this.mFPSTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mFPSTxtBox.Location = new System.Drawing.Point(30, 286);
            this.mFPSTxtBox.MaxLength = 3;
            this.mFPSTxtBox.Name = "mFPSTxtBox";
            this.mFPSTxtBox.Size = new System.Drawing.Size(265, 20);
            this.mFPSTxtBox.TabIndex = 7;
            this.mFPSTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mFPSTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mFPSTxtBox_KeyPress);
            // 
            // mFPSlbl
            // 
            this.mFPSlbl.AutoSize = true;
            this.mFPSlbl.ForeColor = System.Drawing.Color.White;
            this.mFPSlbl.Location = new System.Drawing.Point(31, 268);
            this.mFPSlbl.Name = "mFPSlbl";
            this.mFPSlbl.Size = new System.Drawing.Size(78, 13);
            this.mFPSlbl.TabIndex = 8;
            this.mFPSlbl.Text = "FPS/IPS Max :";
            // 
            // transparentwidthlabel
            // 
            this.transparentwidthlabel.AutoSize = true;
            this.transparentwidthlabel.BackColor = System.Drawing.Color.White;
            this.transparentwidthlabel.ForeColor = System.Drawing.Color.Gray;
            this.transparentwidthlabel.Location = new System.Drawing.Point(147, 121);
            this.transparentwidthlabel.Name = "transparentwidthlabel";
            this.transparentwidthlabel.Size = new System.Drawing.Size(31, 13);
            this.transparentwidthlabel.TabIndex = 9;
            this.transparentwidthlabel.Text = "1080";
            // 
            // transparentheightlabel
            // 
            this.transparentheightlabel.AutoSize = true;
            this.transparentheightlabel.BackColor = System.Drawing.Color.White;
            this.transparentheightlabel.ForeColor = System.Drawing.Color.Gray;
            this.transparentheightlabel.Location = new System.Drawing.Point(147, 206);
            this.transparentheightlabel.Name = "transparentheightlabel";
            this.transparentheightlabel.Size = new System.Drawing.Size(31, 13);
            this.transparentheightlabel.TabIndex = 10;
            this.transparentheightlabel.Text = "1080";
            // 
            // transparentmfpslbl
            // 
            this.transparentmfpslbl.AutoSize = true;
            this.transparentmfpslbl.BackColor = System.Drawing.Color.White;
            this.transparentmfpslbl.ForeColor = System.Drawing.Color.Gray;
            this.transparentmfpslbl.Location = new System.Drawing.Point(147, 290);
            this.transparentmfpslbl.Name = "transparentmfpslbl";
            this.transparentmfpslbl.Size = new System.Drawing.Size(25, 13);
            this.transparentmfpslbl.TabIndex = 11;
            this.transparentmfpslbl.Text = "240";
            this.transparentmfpslbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 418);
            this.Controls.Add(this.transparentmfpslbl);
            this.Controls.Add(this.transparentheightlabel);
            this.Controls.Add(this.transparentwidthlabel);
            this.Controls.Add(this.mFPSlbl);
            this.Controls.Add(this.mFPSTxtBox);
            this.Controls.Add(this.Sumlbl);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.FullscreenchckBox);
            this.Controls.Add(this.Hauteurlbl);
            this.Controls.Add(this.HeightTxtBox);
            this.Controls.Add(this.WidthTxtBox);
            this.Controls.Add(this.Largeurlbl);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Fortnite Config Tool";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Largeurlbl;
        private System.Windows.Forms.TextBox WidthTxtBox;
        private System.Windows.Forms.TextBox HeightTxtBox;
        private System.Windows.Forms.Label Hauteurlbl;
        private System.Windows.Forms.CheckBox FullscreenchckBox;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.Label Sumlbl;
        private System.Windows.Forms.TextBox mFPSTxtBox;
        private System.Windows.Forms.Label mFPSlbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label transparentwidthlabel;
        private System.Windows.Forms.Label transparentheightlabel;
        private System.Windows.Forms.Label transparentmfpslbl;
    }
}