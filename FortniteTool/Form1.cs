﻿using FortniteTool.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortniteTool
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int userWidth => int.Parse(WidthTxtBox.Text);
        int userHeight => int.Parse(HeightTxtBox.Text);
        int userM_FPS => int.Parse(mFPSTxtBox.Text);

        public Form1()
        {
            InitializeComponent();
        }

        private void Init()
        {
            WidthTxtBox.Text = TextTool.GetNumbers("ResolutionSizeX=").ToString();
            HeightTxtBox.Text = TextTool.GetNumbers("ResolutionSizeY=").ToString();
            mFPSTxtBox.Text = TextTool.GetNumbers("FrameRateLimit=").ToString();
         
            Global.fsMode = (Global.FullScreenMode)TextTool.GetNumbers("FullscreenMode=");

            if (Global.fsMode == 0)
            {
                FullscreenchckBox.Checked = true;
            }

            int.TryParse(WidthTxtBox.Text, out Global.ResX);
            int.TryParse(HeightTxtBox.Text, out Global.ResY);
            int.TryParse(mFPSTxtBox.Text, out Global.M_FPS);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if (WidthTxtBox.Text != "" && HeightTxtBox.Text != "" && mFPSTxtBox.Text != "" && userWidth > 0 && userHeight > 0 && userM_FPS >= 30)
            {
                if (FullscreenchckBox.Checked == true)
                {
                    TextTool.ApplySettings(WidthTxtBox.Text, HeightTxtBox.Text, (Global.FullScreenMode)0, mFPSTxtBox.Text);
                }
                else
                { TextTool.ApplySettings(WidthTxtBox.Text, HeightTxtBox.Text, (Global.FullScreenMode)1, mFPSTxtBox.Text); }

                MessageBox.Show("Les paramètres on été appliqués avec succès", "Fortnite Config Tool", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Resources.ErrorText, "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Init();
        }

        private void Txt_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Box_txtchanged(object sender, EventArgs e)
        {
            TextBox txtbox = sender as TextBox;

            if (txtbox.Tag.ToString() == "width" && txtbox.Text == "")
            {
                transparentwidthlabel.Text = Global.ResX.ToString();
                transparentwidthlabel.Show();
                Sumlbl.Text = "Résolution choisie : ";
            }
            else if(txtbox.Tag.ToString() == "width" && txtbox.Text != "")
            {
                transparentwidthlabel.Hide();
                Sumlbl.Text = "Résolution choisie : " + WidthTxtBox.Text + "x" + HeightTxtBox.Text + "@" + mFPSTxtBox.Text + " FPS";
            }

            if (txtbox.Tag.ToString() == "height" && txtbox.Text == "")
            {
                transparentheightlabel.Text = Global.ResY.ToString();
                transparentheightlabel.Show();
                Sumlbl.Text = "Résolution choisie : ";
            }
            else if (txtbox.Tag.ToString() == "height" && txtbox.Text != "")
            {
                transparentheightlabel.Hide();
                Sumlbl.Text = "Résolution choisie : " + WidthTxtBox.Text + "x" + HeightTxtBox.Text + "@" + mFPSTxtBox.Text + " FPS";
            }

            if (txtbox.Tag.ToString() == "m_fps" && txtbox.Text == "")
            {
                transparentmfpslbl.Text = Global.M_FPS.ToString();
                transparentmfpslbl.Show();
                Sumlbl.Text = "Résolution choisie : ";
            }
            else if (txtbox.Tag.ToString() == "m_fps" && txtbox.Text != "")
            {
                transparentmfpslbl.Hide();
                Sumlbl.Text = "Résolution choisie : " + WidthTxtBox.Text + "x" + HeightTxtBox.Text + "@" + mFPSTxtBox.Text + " FPS";
            }
        }
    }
}
