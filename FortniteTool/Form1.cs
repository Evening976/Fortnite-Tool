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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //this.Icon = new Icon(Environment.CurrentDirectory + "\\fntool.ico");
            FullscreenchckBox.Focus();
            WidthTxtBox.Text = TextTool.GetNumbers("ResolutionSizeX=").ToString();
            HeightTxtBox.Text = TextTool.GetNumbers("ResolutionSizeY=").ToString();
            mFPSTxtBox.Text = TextTool.GetNumbers("FrameRateLimit=").ToString();

            if(TextTool.GetNumbers("FullscreenMode=") == 0)
            {
                FullscreenchckBox.Checked = true;
            }


            Global.fsMode = (Global.FullScreenMode)TextTool.GetNumbers("FullscreenMode=");

            int.TryParse(WidthTxtBox.Text, out Global.ResX);
            int.TryParse(HeightTxtBox.Text, out Global.ResY);
            int.TryParse(mFPSTxtBox.Text, out Global.M_FPS);
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
                MessageBox.Show("J'crois que tu t'es trompé sur ta résolution, à moins que tu essaies de me pranker ? allez change moi ça avant que ça parte en tête à tête à Tilted", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Form3_Load(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void WidthTxtBox_TextChanged(object sender, EventArgs e)
        {

            if (WidthTxtBox.Text == "")
            {
                transparentwidthlabel.Text = Global.ResX.ToString();
                transparentwidthlabel.Show();
                Sumlbl.Text = "Résolution choisie : ";
            }
            else
            {
                transparentwidthlabel.Hide();
                Sumlbl.Text = "Résolution choisie : " + WidthTxtBox.Text + "x" + HeightTxtBox.Text + "@" + mFPSTxtBox.Text + " FPS";
            }
        }

        private void HeightTxtBox_TextChanged(object sender, EventArgs e)
        {

            if (HeightTxtBox.Text == "")
            {
                transparentheightlabel.Text = Global.ResY.ToString();
                transparentheightlabel.Show();
                Sumlbl.Text = "Résolution choisie : ";
            }
            else
            {
                transparentheightlabel.Hide();
                Sumlbl.Text = "Résolution choisie : " + WidthTxtBox.Text + "x" + HeightTxtBox.Text + "@" + mFPSTxtBox.Text + " FPS";
            }
        }

        private void mFPSTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (mFPSTxtBox.Text == "")
            {
                transparentmfpslbl.Text = Global.M_FPS.ToString();
                transparentmfpslbl.Show();
                Sumlbl.Text = "Résolution choisie : ";
            }
            else
            {
                transparentmfpslbl.Hide();
                Sumlbl.Text = "Résolution choisie : " + WidthTxtBox.Text + "x" + HeightTxtBox.Text + "@" + mFPSTxtBox.Text + " FPS";
            }
        }

        private void WidthTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void HeightTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            
        }

        private void mFPSTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            
        }
    }
}
