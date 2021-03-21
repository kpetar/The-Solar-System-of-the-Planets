using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace WindowsFormsApplication48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        Graphics g;
        bool stanjeMerkura = false;
        bool stanjeVenere = false;
        bool stanjeZemlje = false;
        bool stanjeMarsa = false;
        bool stanjeJupitera = false;
        bool stanjeSaturna = false;
        bool stanjeUrana = false;
        bool stanjeNeptuna = false;
        bool stanjePlutona = false;


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            g = panel1.CreateGraphics();
            Image slika = Properties.Resources.sun;
            g.PageUnit = GraphicsUnit.Pixel;
            g.PageScale = 1.0f;

            g.DrawImage(slika, new RectangleF(panel1.Width / 2 - 25, panel1.Height / 2 - 25, 50, 50));

            stanjaPlaneta();

            timer1.Start();
        }

        //Prikazavnje planeta
        private void stanjaPlaneta()
        {
            
            if (stanjeMerkura == false)
            {
                crtanjeMerkura();
            }
            else
            {
                stanjeMerkura = true;
            }

            if (stanjeVenere == false)
            {
                crtanjeVenere();
            }
            else
            {
                stanjeVenere = true;
            }

            if (stanjeZemlje == false)
            {
                crtanjeZemlje();
            }
            else
            {
                stanjeZemlje = true;
            }

            if (stanjeMarsa == false)
            {
                crtanjeMarsa();
            }
            else
            {
                stanjeMarsa = true;
            }

            if (stanjeJupitera == false)
            {
                crtanjeJupitera();
            }
            else
            {
                stanjeJupitera = true;
            }

            if (stanjeSaturna == false)
            {
                crtanjeSaturna();
            }
            else
            {
                stanjeSaturna = true;
            }

                if (stanjeUrana == false)
                {
                    crtanjeUrana();
                }
                else
                {
                    stanjeUrana = true;
                }

                if (stanjeNeptuna==false)
                {
                    crtanjeNeptuna();
                }
                else
                {
                    stanjeNeptuna = true;
                }

                if (stanjePlutona==false)
                {
                    crtanjePlutona();
                }
                else
                {
                    stanjePlutona = true;
                }
            
        }

        //Crtanje orbite, planeta i putanje po kojoj se planeta kreće
        float ugaoMerkur = 0.0f;
        private void crtanjeMerkura()
        {

            Pen olovka = new Pen(Color.Chocolate, 0.5f);
            RectangleF orbitaMerkura = new RectangleF(panel1.Width / 2 - 36.58f, panel1.Height / 2 - 36.58f, 73.16f, 73.16f);
            RectangleF planetMerkur = new RectangleF(0, 0, 4.87f, 4.87f);
            Image merkur = Properties.Resources.mercury;
           
            PointF polaznaTacka = new PointF(36.58f, 36.58f);
            float rad = 36.58f;
            PointF lokacija = PointF.Empty;

            g.DrawEllipse(olovka, orbitaMerkura);


            lokacija = CirclePoint(rad, ugaoMerkur, polaznaTacka);

            planetMerkur.X = (float)(lokacija.X - (planetMerkur.Width / 2) + orbitaMerkura.X);
            planetMerkur.Y = (float)(lokacija.Y - (planetMerkur.Height / 2) + orbitaMerkura.Y);

            g.DrawImage(merkur, planetMerkur);

            g.DrawString("Merkur", new Font("Arial", 6), new SolidBrush(Color.Chocolate), planetMerkur.X - 5, planetMerkur.Y + 5);

            if (ugaoMerkur > -360)
            {
                ugaoMerkur -= 4.74f;
            }
            else
            {
                ugaoMerkur =0;
            }

        }


        float ugaoVenere = 0.0f;
        private void crtanjeVenere()
        {
            Pen olovka = new Pen(Color.Orange, 0.5f);
            RectangleF orbitaVenere = new RectangleF(panel1.Width / 2 - 46.64f, panel1.Height / 2 - 46.64f, 93.28f, 93.28f);
            RectangleF planetVenere = new RectangleF(0, 0, 12.1f, 12.1f);
            Image venera = Properties.Resources.venus;

            g.DrawEllipse(olovka, orbitaVenere);


            PointF polaznaTacka = new PointF(46.64f, 46.64f);
            float rad = 46.64f;
            PointF lokacija = PointF.Empty;

            g.DrawEllipse(olovka, orbitaVenere);


            lokacija = CirclePoint(rad, ugaoVenere, polaznaTacka);

            planetVenere.X = (float)(lokacija.X - (planetVenere.Width / 2) + orbitaVenere.X);
            planetVenere.Y = (float)(lokacija.Y - (planetVenere.Height / 2) + orbitaVenere.Y);

            g.DrawImage(venera, planetVenere);

            g.DrawString("Venera", new Font("Arial", 6), new SolidBrush(Color.Orange), planetVenere.X-5, planetVenere.Y+10 );

            if (ugaoVenere > -360)
            {
                ugaoVenere -= 1.85f;
            }
            else
            {
                ugaoVenere =0;
            }
            
        }

        float ugaoZemlje = 0.0f;
        private void crtanjeZemlje()
        {
            Pen olovka = new Pen(Color.Blue, 0.5f);
            RectangleF orbitaZemlje = new RectangleF(panel1.Width / 2 - 54.92f, panel1.Height / 2 - 54.92f, 109.84f, 109.84f);
            RectangleF planetZemlje = new RectangleF(0, 0, 12.756f, 12.756f);
            Image zemlja = Properties.Resources.earth;
            PointF polaznaTacka = new PointF(54.92f, 54.92f);
            float rad = 54.92f;
            PointF lokacija = PointF.Empty;

            g.DrawEllipse(olovka, orbitaZemlje);

            
            

            lokacija = CirclePoint(rad, ugaoZemlje, polaznaTacka);

            planetZemlje.X = (float)(lokacija.X - (planetZemlje.Width / 2) + orbitaZemlje.X);
            planetZemlje.Y = (float)(lokacija.Y - (planetZemlje.Height / 2) + orbitaZemlje.Y);

            g.DrawImage(zemlja , planetZemlje);
            g.DrawString("Zemlja", new Font("Arial", 7), new SolidBrush(Color.Blue), planetZemlje.X-5, planetZemlje.Y+10);
            if (ugaoZemlje >- 360)
            {
                ugaoZemlje -= 1.15f;
            }
            else
            {
                ugaoZemlje =0;
            }
            
        }

        float ugaoMarsa = 0.0f;
        private void crtanjeMarsa()
        {
            Pen olovka = new Pen(Color.DarkRed, 0.5f);
            RectangleF orbitaMarsa = new RectangleF(panel1.Width / 2 - 70.58f, panel1.Height / 2 - 70.58f, 141.16f, 141.16f);
            RectangleF planetMars = new RectangleF(0, 0, 6.792f, 6.792f);
            Image mars = Properties.Resources.mars;
            PointF polaznaTacka = new PointF(70.58f, 70.58f);
            float rad = 70.58f;
            PointF lokacija = PointF.Empty;

            g.DrawEllipse(olovka, orbitaMarsa);




            lokacija = CirclePoint(rad, ugaoMarsa, polaznaTacka);

            planetMars.X = (float)(lokacija.X - (planetMars.Width / 2) + orbitaMarsa.X);
            planetMars.Y = (float)(lokacija.Y - (planetMars.Height / 2) + orbitaMarsa.Y);

            g.DrawImage(mars, planetMars);
            g.DrawString("Mars", new Font("Arial", 7), new SolidBrush(Color.DarkRed), planetMars.X-5, planetMars.Y + 5);
            if (ugaoMarsa >- 360)
            {
                ugaoMarsa -= 0.6f;
            }
            else
            {
                ugaoMarsa = 0;
            }
        }

        float ugaoJupitera = 0.0f;
        private void crtanjeJupitera()
        {
            Pen olovka = new Pen(Color.Orange, 0.5f);
            RectangleF orbitaJupitera = new RectangleF(panel1.Width / 2 - 180.72f, panel1.Height / 2 - 180.72f, 361.44f, 361.44f);
            RectangleF planetJupitera = new RectangleF(0, 0, 40f, 40f);
            Image jupiter = Properties.Resources.jupiter;
            PointF polaznaTacka = new PointF(180.72f, 180.72f);
            float rad = 180.72f;
            PointF lokacija = PointF.Empty;

            g.DrawEllipse(olovka, orbitaJupitera);




            lokacija = CirclePoint(rad, ugaoJupitera, polaznaTacka);

            planetJupitera.X = (float)(lokacija.X - (planetJupitera.Width / 2) + orbitaJupitera.X);
            planetJupitera.Y = (float)(lokacija.Y - (planetJupitera.Height / 2) + orbitaJupitera.Y);

            g.DrawImage(jupiter, planetJupitera);
            g.DrawString("Jupiter", new Font("Arial", 7), new SolidBrush(Color.Orange), planetJupitera.X-5, planetJupitera.Y + 40);
            if (ugaoJupitera > -360)
            {
                ugaoJupitera -= 0.4f;
            }
            else
            {
                ugaoJupitera = 0;
            }
        }

        float ugaoSaturna = 0.0f;
        private void crtanjeSaturna()
        {
            Pen olovka = new Pen(Color.DarkOrange, 0.2f);
            RectangleF orbitaSaturna = new RectangleF(panel1.Width / 2 - 311.7f, panel1.Height / 2 - 311.7f, 623.4f, 623.4f);
            RectangleF planetSaturn = new RectangleF(0, 0, 30f, 30f);
            Image saturn = Properties.Resources.saturn;
            PointF polaznaTacka = new PointF(311.7f, 311.7f);
            float rad = 311.7f;
            PointF lokacija = PointF.Empty;

            g.DrawEllipse(olovka, orbitaSaturna);




            lokacija = CirclePoint(rad, ugaoSaturna, polaznaTacka);

            planetSaturn.X = (float)(lokacija.X - (planetSaturn.Width / 2) + orbitaSaturna.X);
            planetSaturn.Y = (float)(lokacija.Y - (planetSaturn.Height / 2) + orbitaSaturna.Y);

            g.DrawImage(saturn, planetSaturn);
            g.DrawString("Saturn", new Font("Arial", 7), new SolidBrush(Color.DarkOrange), planetSaturn.X - 5, planetSaturn.Y + 30);
            if (ugaoSaturna > -360)
            {
                ugaoSaturna -= 0.3f;
            }
            else
            {
                ugaoSaturna = 0;
            }
        }

        float ugaoUrana = 50.0f;
        private void crtanjeUrana()
        {
            Pen olovka = new Pen(Color.LightBlue, 0.2f);
            RectangleF orbitaUrana = new RectangleF(panel1.Width / 2 - 599.5f, panel1.Height / 2 - 599.5f, 1199f, 1199f);
            RectangleF planetUran = new RectangleF(0, 0, 15f, 15f);
            Image uran = Properties.Resources.uranus;
            PointF polaznaTacka = new PointF(599.5f, 599.5f);
            float rad = 599.5f;
            PointF lokacija = PointF.Empty;

            g.DrawEllipse(olovka, orbitaUrana);




            lokacija = CirclePoint(rad, ugaoUrana, polaznaTacka);

            planetUran.X = (float)(lokacija.X - (planetUran.Width / 2) + orbitaUrana.X);
            planetUran.Y = (float)(lokacija.Y - (planetUran.Height / 2) + orbitaUrana.Y);

            g.DrawImage(uran, planetUran);
            g.DrawString("Uran", new Font("Arial", 7), new SolidBrush(Color.LightBlue), planetUran.X - 5, planetUran.Y + 15);
            if (ugaoUrana > -360)
            {
                ugaoUrana -= 0.2f;
            }
            else
            {
                ugaoUrana = 0;
            }
        }

        float ugaoNeptuna = 0.0f;
        private void crtanjeNeptuna()
        {
            Pen olovka = new Pen(Color.Blue, 0.2f);
            RectangleF orbitaNeptuna = new RectangleF(panel1.Width / 2 - 724.02f, panel1.Height / 2 - 724.02f, 1448.04f, 1448.04f);
            RectangleF planetNeptun = new RectangleF(0, 0, 12f, 12f);
            Image neptun = Properties.Resources.neptune;
            PointF polaznaTacka = new PointF(724.02f, 724.02f);
            float rad = 724.02f;
            PointF lokacija = PointF.Empty;

            g.DrawEllipse(olovka, orbitaNeptuna);




            lokacija = CirclePoint(rad, ugaoNeptuna, polaznaTacka);

            planetNeptun.X = (float)(lokacija.X - (planetNeptun.Width / 2) + orbitaNeptuna.X);
            planetNeptun.Y = (float)(lokacija.Y - (planetNeptun.Height / 2) + orbitaNeptuna.Y);

            g.DrawImage(neptun, planetNeptun);
            g.DrawString("Neptun", new Font("Arial", 7), new SolidBrush(Color.Teal), planetNeptun.X-5, planetNeptun.Y + 12);
            if (ugaoNeptuna > -360)
            {
                ugaoNeptuna -= 0.1f;
            }
            else
            {
                ugaoNeptuna = 0;
            }
        }

        float ugaoPluton = 30.0f;
        private void crtanjePlutona()
        {
            Pen olovka = new Pen(Color.Gray, 0.2f);
            RectangleF orbitaPlutona = new RectangleF(panel1.Width / 2 - 800f, panel1.Height / 2 - 800f, 1600f, 1600f);
            RectangleF planetPluton = new RectangleF(0, 0, 2.37f, 2.37f);
            Image pluton = Properties.Resources.planet;
            PointF polaznaTacka = new PointF(800f, 800f);
            float rad = 800f;
            PointF lokacija = PointF.Empty;

            g.DrawEllipse(olovka, orbitaPlutona);




            lokacija = CirclePoint(rad, ugaoPluton, polaznaTacka);

            planetPluton.X = (float)(lokacija.X - (planetPluton.Width / 2) + orbitaPlutona.X);
            planetPluton.Y = (float)(lokacija.Y - (planetPluton.Height / 2) + orbitaPlutona.Y);

            g.DrawImage(pluton, planetPluton);
            g.DrawString("Pluton", new Font("Arial", 7), new SolidBrush(Color.LightBlue), planetPluton.X - 5, planetPluton.Y + 20);
            if (ugaoPluton > -360)
            {
                ugaoPluton -= 0.09f;
            }
            else
            {
                ugaoPluton = 0;
            }
        }




        private void panel1_Resize(object sender, EventArgs e)
        {
            panel1.Refresh();
            
        }




        private void timer1_Tick(object sender, EventArgs e)
        {

            panel1.Invalidate();

            Invalidate();
        }

        




        //Skrivanje i prikazivanje planeta
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!stanjeMerkura)
            {
                stanjeMerkura = true;
            }
            else
            {
                stanjeMerkura = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!stanjeVenere)
            {
                stanjeVenere = true;
            }
            else
            {
                stanjeVenere = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!stanjeZemlje)
            {
                stanjeZemlje = true;
            }
            else
            {
                stanjeZemlje = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!stanjeMarsa)
            {
                stanjeMarsa = true;
            }
            else
            {
                stanjeMarsa = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!stanjeJupitera)
            {
                stanjeJupitera = true;
            }
            else
            {
                stanjeJupitera = false;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (!stanjeSaturna)
            {
                stanjeSaturna = true;
            }
            else
            {
                stanjeSaturna = false;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (!stanjeUrana)
            {
                stanjeUrana = true;
            }
            else
            {
                stanjeUrana = false;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (!stanjeNeptuna)
            {
                stanjeNeptuna = true;
            }
            else
            {
                stanjeNeptuna = false;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (!stanjePlutona)
            {
                stanjePlutona = true;
            }
            else
            {
                stanjePlutona = false;
            }
        }

        //Računanje tacke(koordinata) na krugu
        public PointF CirclePoint(float radijus, float ugaoUStepenima, PointF polazna_tacka)
        {
            float x = (float)(radijus * Math.Cos(ugaoUStepenima * Math.PI / 180f)) + polazna_tacka.X;
            float y = (float)(radijus * Math.Sin(ugaoUStepenima * Math.PI / 180f)) + polazna_tacka.Y;


            return new PointF(x, y);
        }

        //Screenshot aplikacije
        private void snapButton_Click(object sender, EventArgs e)
        {
            String  slika= "Slika" + " .png";
            var bounds = this.Bounds;
            using (var bmp = new Bitmap(bounds.Width - 10,
                                        bounds.Height - 5,
                                        PixelFormat.Format32bppArgb))
            using (var gfx = Graphics.FromImage(bmp))
            {
                gfx.CopyFromScreen(bounds.X, bounds.Y, 10, 6, bounds.Size, CopyPixelOperation.SourceCopy);
                bmp.Save(slika);
                
            }

        }

        

    }
}
