namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {

        int aa = 2;
        int bb = 2;
        int cc = 2;
        int dd = 2;
        int ee = 2;
        int ff = 2;
        int gg = 2;
        int hh = 2;
        int ii = 2;
        int jj = 2;
        int kk = 2;


        string url_1;
        string url_2;


        int p1 = 2;
        int p2 = 2;




        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            url_1 = "C:\\Users\\hp\\Desktop\\Tic_Tac_Toe\\Tic_Tac_Toe\\Photo\\tickk.ico";
            p1 = 1;
            p2 = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            url_2 = "C:\\Users\\hp\\Desktop\\Tic_Tac_Toe\\Tic_Tac_Toe\\Photo\\crosse.ico";
            p2 = 1;
            p1 = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                aa = 1;
                pictureBox1.Image = new Bitmap(url_1);
                p2 = 0;
            }
            if (p2 == 1)
            {

                aa = 0;
                pictureBox1.Image = new Bitmap(url_2);
                p1 = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                hh = 1;
                pictureBox8.Image = new Bitmap(url_1);
                p2 = 0;
            }
            if (p2 == 1)
            {

                hh = 0;
                pictureBox8.Image = new Bitmap(url_2);
                p1 = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                bb = 1;
                pictureBox2.Image = new Bitmap(url_1);
                p2 = 0;
            }
            if (p2 == 1)
            {

                bb = 0;
                pictureBox2.Image = new Bitmap(url_2);
                p1 = 0;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                cc = 1;
                pictureBox3.Image = new Bitmap(url_1);
                p2 = 0;
            }
            if (p2 == 1)
            {

                cc = 0;
                pictureBox3.Image = new Bitmap(url_2);
                p1 = 0;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                dd = 1;
                pictureBox4.Image = new Bitmap(url_1);
                p2 = 0;
            }
            if (p2 == 1)
            {

                dd = 0;
                pictureBox4.Image = new Bitmap(url_2);
                p1 = 0;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ee = 1;
                pictureBox5.Image = new Bitmap(url_1);
                p2 = 0;
            }
            if (p2 == 1)
            {

                ee = 0;
                pictureBox5.Image = new Bitmap(url_2);
                p1 = 0;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ff = 1;
                pictureBox6.Image = new Bitmap(url_1);
                p2 = 0;
            }
            if (p2 == 1)
            {

                ff = 0;
                pictureBox6.Image = new Bitmap(url_2);
                p1 = 0;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                gg = 1;
                pictureBox7.Image = new Bitmap(url_1);
                p2 = 0;
            }
            if (p2 == 1)
            {

                gg = 0;
                pictureBox7.Image = new Bitmap(url_2);
                p1 = 0;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (p1 == 1)
            {
                ii = 1;
                pictureBox9.Image = new Bitmap(url_1);
                p2 = 0;
            }
            if (p2 == 1)
            {

                ii = 0;
                pictureBox9.Image = new Bitmap(url_2);
                p1 = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (aa == 1 && bb == 1 && cc == 1)
            {
                MessageBox.Show("player1 wins");
            }
            if (aa == 0 && bb == 0 && cc == 0)
            {
                MessageBox.Show("player2 wins");
            }
            if (aa == 1 && dd == 1 && gg == 1)
            {
                MessageBox.Show("player1 wins");
            }
            if (aa == 0 && dd == 0 && gg == 0)
            {
                MessageBox.Show("player2 wins");
            }
            if (bb == 1 && ee == 1 && hh == 1)
            {
                MessageBox.Show("player1 wins");
            }
            if (bb == 0 && ee == 0 && hh == 0)
            {
                MessageBox.Show("player2 wins");
            }
            if (dd == 1 && ee == 1 && ff == 1)
            {
                MessageBox.Show("player1 wins");
            }
            if (dd == 0 && ee == 0 && ff == 0)
            {
                MessageBox.Show("player2 wins");
            }
            if (gg == 1 && hh == 1 && ii == 1)
            {
                MessageBox.Show("player1 wins");
            }
            if (gg == 0 && hh == 0 && ii == 0)
            {
                MessageBox.Show("player2 wins");
            }
            if (aa == 1 && ee == 1 && ii == 1)
            {
                MessageBox.Show("player1 wins");
            }
            if (aa == 0 && ee == 0 && ii == 0)
            {
                MessageBox.Show("player2 wins");
            }
            if (cc == 1 && ee == 1 && gg == 1)
            {
                MessageBox.Show("player1 wins");
            }
            if (cc == 0 && ee == 0 && gg == 0)
            {
                MessageBox.Show("player2 wins");
            }
            if (cc == 1 && ff == 1 && ii == 1)
            {
                MessageBox.Show("player1 wins");
            }
            if (cc == 0 && ff == 0 && ii == 0)
            {
                MessageBox.Show("player2 wins");
            }
        }
    }
}