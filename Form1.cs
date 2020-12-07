using System;
using System.Windows.Forms;

namespace SmthRender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(Convert.ToDouble(SphereRTB.Text) * 10) > 1000)
                {
                    SphereRS.Value = 1000;
                }
                else if (Convert.ToInt32(Convert.ToDouble(SphereRTB.Text) * 10) < 0)
                {
                    SphereRS.Value = 0;
                }
                else
                {
                    SphereRS.Value = Convert.ToInt32(Convert.ToDouble(SphereRTB.Text) * 10);
                }

                Render.SphereR = Convert.ToDouble(SphereRTB.Text);
            }
            catch
            {

            }
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            SphereRTB.Text = Convert.ToString(Convert.ToDouble(SphereRS.Value) / 10);
            Render.SphereR = Convert.ToDouble(SphereRS.Value) / 10;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void trackBar19_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar17_Scroll(object sender, EventArgs e)
        {

        }

        private void SphereXS_Scroll(object sender, EventArgs e)
        {
            SphereXTB.Text = Convert.ToString(Convert.ToDouble(SphereXS.Value) / 10);
            Render.SphereX = -1 * Convert.ToDouble(SphereXS.Value) / 10;
        }

        private void SphereXTB_TextChanged(object sender, EventArgs e)
        {
            if (SphereXTB.Text != "")
            {
                try
                {
                    if (Convert.ToInt32(Convert.ToDouble(SphereXTB.Text) * 10) > 100)
                    {
                        SphereXS.Value = 100;
                    }
                    else if (Convert.ToInt32(Convert.ToDouble(SphereXTB.Text) * 10) < -100)
                    {
                        SphereXS.Value = -100;
                    }
                    else
                    {
                        SphereXS.Value = Convert.ToInt32(Convert.ToDouble(SphereXTB.Text) * 10);
                    }

                    Render.SphereX = -1 * Convert.ToDouble(SphereXTB.Text);
                }
                catch
                {

                }


            }
        }

        private void SphereYS_Scroll(object sender, EventArgs e)
        {
            SphereYTB.Text = Convert.ToString(Convert.ToDouble(SphereYS.Value) / 10);
            Render.SphereY = Convert.ToDouble(SphereYS.Value) / 10;
        }

        private void SphereYTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(Convert.ToDouble(SphereYTB.Text) * 10) > 100)
                {
                    SphereYS.Value = 100;
                }
                else if (Convert.ToInt32(Convert.ToDouble(SphereYTB.Text) * 10) < -100)
                {
                    SphereYS.Value = -100;
                }
                else
                {
                    SphereYS.Value = Convert.ToInt32(Convert.ToDouble(SphereYTB.Text) * 10);
                }

                Render.SphereY = Convert.ToDouble(SphereYTB.Text);
            }
            catch
            {

            }
        }

        private void SphereZTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(Convert.ToDouble(SphereZTB.Text) * 10) > 1000)
                {
                    SphereZS.Value = 1000;
                }
                else if (Convert.ToInt32(Convert.ToDouble(SphereZTB.Text) * 10) < -100)
                {
                    SphereZS.Value = -100;
                }
                else
                {
                    SphereZS.Value = Convert.ToInt32(Convert.ToDouble(SphereZTB.Text) * 10);
                }

                Render.SphereZ = Convert.ToDouble(SphereZTB.Text);
            }
            catch
            {

            }
        }

        private void SphereZS_Scroll(object sender, EventArgs e)
        {
            SphereZTB.Text = Convert.ToString(Convert.ToDouble(SphereZS.Value) / 10);
            Render.SphereZ = Convert.ToDouble(SphereZS.Value) / 10;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Render.invertRender = !Render.invertRender;
        }

        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            LightXTB.Text = Convert.ToString(Convert.ToDouble(LightXS.Value) / 10);
            Render.LightX = -1 * Convert.ToDouble(LightXS.Value) / 10;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(Convert.ToDouble(LightXTB.Text) * 10) > 1000)
                {
                    LightXS.Value = 1000;
                }
                else if (Convert.ToInt32(Convert.ToDouble(LightXTB.Text) * 10) < -1000)
                {
                    LightXS.Value = -1000;
                }
                else
                {
                    LightXS.Value = Convert.ToInt32(Convert.ToDouble(LightXTB.Text) * 10);
                }

                Render.LightZ = Convert.ToDouble(LightXTB.Text);
            }
            catch
            {

            }
        }

        private void LightYS_Scroll(object sender, EventArgs e)
        {
            LightYTB.Text = Convert.ToString(Convert.ToDouble(LightYS.Value) / 10);
            Render.LightY = Convert.ToDouble(LightYS.Value) / 10;
        }

        private void LightYTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(Convert.ToDouble(LightYTB.Text) * 10) > 1000)
                {
                    LightYS.Value = 1000;
                }
                else if (Convert.ToInt32(Convert.ToDouble(LightYTB.Text) * 10) < -100)
                {
                    LightYS.Value = -100;
                }
                else
                {
                    LightYS.Value = Convert.ToInt32(Convert.ToDouble(LightYTB.Text) * 10);
                }

                Render.LightZ = Convert.ToDouble(LightYTB.Text);
            }
            catch
            {

            }
        }

        private void LightZS_Scroll(object sender, EventArgs e)
        {
            LightZTB.Text = Convert.ToString(Convert.ToDouble(LightZS.Value) / 10);
            Render.LightZ = Convert.ToDouble(LightZS.Value) / 10;
        }

        private void LightZTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(Convert.ToDouble(LightZTB.Text) * 10) > 1000)
                {
                    LightZS.Value = 1000;
                }
                else if (Convert.ToInt32(Convert.ToDouble(LightZTB.Text) * 10) < -1000)
                {
                    LightZS.Value = -1000;
                }
                else
                {
                    LightZS.Value = Convert.ToInt32(Convert.ToDouble(LightZTB.Text) * 10);
                }

                Render.LightZ = Convert.ToDouble(LightZTB.Text);
            }
            catch
            {

            }
        }

        private void LightDS_Scroll(object sender, EventArgs e)
        {
            LightDTB.Text = Convert.ToString(Convert.ToDouble(LightDS.Value) / 10);
            Render.LightD = Convert.ToDouble(LightDS.Value) / 10;
        }

        private void LightDTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(Convert.ToDouble(LightDTB.Text) * 10) > 5000)
                {
                    LightDS.Value = 5000;
                }
                else if (Convert.ToInt32(Convert.ToDouble(LightDTB.Text) * 10) < -5000)
                {
                    LightDS.Value = -5000;
                }
                else
                {
                    LightDS.Value = Convert.ToInt32(Convert.ToDouble(LightDTB.Text) * 10);
                }

                Render.LightD = Convert.ToDouble(LightDTB.Text);
            }
            catch
            {

            }
        }

        private void SphereAXS_Scroll(object sender, EventArgs e)
        {
            SphereAXTB.Text = Convert.ToString(Convert.ToDouble(SphereAXS.Value) / 10);
            Render.SphereAnimX = Convert.ToDouble(SphereAXS.Value) / 10;
        }

        private void SphereAXTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(Convert.ToDouble(SphereAXTB.Text) * 10) > 100)
                {
                    SphereAXS.Value = 100;
                }
                else if (Convert.ToInt32(Convert.ToDouble(SphereAXTB.Text) * 10) < -100)
                {
                    SphereAXS.Value = -100;
                }
                else
                {
                    SphereAXS.Value = Convert.ToInt32(Convert.ToDouble(SphereAXTB.Text) * 10);
                }

                Render.SphereAnimX = Convert.ToDouble(SphereAXTB.Text);
            }
            catch
            {

            }
        }

        private void SphereAZS_Scroll(object sender, EventArgs e)
        {
            SphereAZTB.Text = Convert.ToString(Convert.ToDouble(SphereAZS.Value) / 10);
            Render.SphereAnimZ = Convert.ToDouble(SphereAZS.Value) / 10;
        }

        private void SphereAZTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(Convert.ToDouble(SphereAZTB.Text) * 10) > 100)
                {
                    SphereAZS.Value = 100;
                }
                else if (Convert.ToInt32(Convert.ToDouble(SphereAZTB.Text) * 10) < -100)
                {
                    SphereAZS.Value = -100;
                }
                else
                {
                    SphereAZS.Value = Convert.ToInt32(Convert.ToDouble(SphereAZTB.Text) * 10);
                }

                Render.SphereAnimZ = Convert.ToDouble(SphereAZTB.Text);
            }
            catch
            {

            }
        }

        private void SphereAYS_Scroll(object sender, EventArgs e)
        {
            SphereAYTB.Text = Convert.ToString(Convert.ToDouble(SphereAYS.Value) / 10);
            Render.SphereAnimY = Convert.ToDouble(SphereAYS.Value) / 10;
        }

        private void SphereAYTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(Convert.ToDouble(SphereAYTB.Text) * 10) > 100)
                {
                    SphereAYS.Value = 100;
                }
                else if (Convert.ToInt32(Convert.ToDouble(SphereAYTB.Text) * 10) < -100)
                {
                    SphereAYS.Value = -100;
                }
                else
                {
                    SphereAYS.Value = Convert.ToInt32(Convert.ToDouble(SphereAYTB.Text) * 10);
                }

                Render.SphereAnimY = Convert.ToDouble(SphereAYTB.Text);
            }
            catch
            {

            }
        }
    }
}

