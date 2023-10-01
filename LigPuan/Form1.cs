namespace LigPuan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        int lkpoint = 0;
        int stpoint = 0;
        int bmpoint = 0;
        int bdpoint = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            int a = random.Next(0, 5);
            int b = random.Next(0, 5);
            int c = random.Next(0, 5);
            int d = random.Next(0, 5);

            label09.Text = a.ToString();
            label10.Text = b.ToString();
            label11.Text = c.ToString();
            label12.Text = d.ToString();

            if (Convert.ToInt32(label09.Text) > Convert.ToInt32(label10.Text))
            {
                lkpoint = lkpoint + 3;
                lbLkPoint.Text = lkpoint.ToString();
            }
            if (Convert.ToInt32(label10.Text) > Convert.ToInt32(label09.Text))
            {
                stpoint = stpoint + 3;
                lbStPoint.Text = stpoint.ToString();
            }
            if (Convert.ToInt32(label09.Text) == Convert.ToInt32(label10.Text))
            {
                lkpoint = lkpoint + 1;
                stpoint = stpoint + 1;
                lbLkPoint.Text = lkpoint.ToString();
                lbStPoint.Text = stpoint.ToString();
            }


            if (Convert.ToInt32(label11.Text) > Convert.ToInt32(label12.Text))
            {
                bmpoint = bmpoint + 3;
                lbBmPoint.Text = bmpoint.ToString();
            }
            if (Convert.ToInt32(label12.Text) > Convert.ToInt32(label11.Text))
            {
                bdpoint = bdpoint + 3;
                lbBdPoint.Text = bdpoint.ToString();
            }
            if (Convert.ToInt32(label11.Text) == Convert.ToInt32(label12.Text))
            {
                bmpoint = bmpoint + 1;
                bdpoint = bdpoint + 1;
                lbBmPoint.Text = bmpoint.ToString();
                lbBdPoint.Text = bdpoint.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;

            int a = random.Next(0, 5);
            int b = random.Next(0, 5);
            int c = random.Next(0, 5);
            int d = random.Next(0, 5);

            label15.Text = a.ToString();
            label14.Text = b.ToString();
            label9.Text = c.ToString();
            label13.Text = d.ToString();

            if (Convert.ToInt32(label15.Text) > Convert.ToInt32(label14.Text))
            {
                lkpoint = lkpoint + 3;
                lbLkPoint.Text = lkpoint.ToString();
            }
            if (Convert.ToInt32(label14.Text) > Convert.ToInt32(label15.Text))
            {
                bmpoint = bmpoint + 3;
                lbBmPoint.Text = bmpoint.ToString();
            }
            if (Convert.ToInt32(label15.Text) == Convert.ToInt32(label14.Text))
            {
                lkpoint = lkpoint + 1;
                bmpoint = bmpoint + 1;
                lbLkPoint.Text = lkpoint.ToString();
                lbBmPoint.Text = bmpoint.ToString();
            }


            if (Convert.ToInt32(label9.Text) > Convert.ToInt32(label13.Text))
            {
                stpoint = stpoint + 3;
                lbStPoint.Text = stpoint.ToString();
            }
            if (Convert.ToInt32(label13.Text) > Convert.ToInt32(label9.Text))
            {
                bdpoint = bdpoint + 3;
                lbBdPoint.Text = bdpoint.ToString();
            }
            if (Convert.ToInt32(label9.Text) == Convert.ToInt32(label13.Text))
            {
                stpoint = stpoint + 1;
                bdpoint = bdpoint + 1;
                lbStPoint.Text = stpoint.ToString();
                lbBdPoint.Text = bdpoint.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;

            int a = random.Next(0, 5);
            int b = random.Next(0, 5);
            int c = random.Next(0, 5);
            int d = random.Next(0, 5);

            label23.Text = a.ToString();
            label22.Text = b.ToString();
            label20.Text = c.ToString();
            label21.Text = d.ToString();

            if (Convert.ToInt32(label23.Text) > Convert.ToInt32(label22.Text))
            {
                lkpoint = lkpoint + 3;
                lbLkPoint.Text = lkpoint.ToString();
            }
            if (Convert.ToInt32(label22.Text) > Convert.ToInt32(label23.Text))
            {
                bdpoint = bdpoint + 3;
                lbBdPoint.Text = bdpoint.ToString();
            }
            if (Convert.ToInt32(label23.Text) == Convert.ToInt32(label22.Text))
            {
                lkpoint = lkpoint + 1;
                bdpoint = bdpoint + 1;
                lbLkPoint.Text = lkpoint.ToString();
                lbBdPoint.Text = bdpoint.ToString();
            }


            if (Convert.ToInt32(label20.Text) > Convert.ToInt32(label21.Text))
            {
                stpoint = stpoint + 3;
                lbStPoint.Text = stpoint.ToString();
            }
            if (Convert.ToInt32(label21.Text) > Convert.ToInt32(label20.Text))
            {
                bmpoint = bmpoint + 3;
                lbBmPoint.Text = bmpoint.ToString();
            }
            if (Convert.ToInt32(label20.Text) == Convert.ToInt32(label21.Text))
            {
                stpoint = stpoint + 1;
                bmpoint = bmpoint + 1;
                lbStPoint.Text = stpoint.ToString();
                lbBmPoint.Text = bmpoint.ToString();
            }
        }
    }
}