  public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            string value;
            try
            {
                StreamReader fil = new StreamReader("values.txt");
                // value = fil.ReadLine();
                while ((value = fil.ReadLine())!= null)
                {
                    txtValues.Items.Add(value);
                }
                
                fil.Close();
               
            }
            catch (IOException)
            {

                MessageBox.Show("File not found");
            }
            

        }

        private void BtnAver_Click(object sender, EventArgs e)
        {
            int value;
            double total = 0;
            StreamReader fil = new StreamReader("values.txt");
            
            for (int i = 0; i < 10; i++)
            {
                value = int.Parse(fil.ReadLine());
                total += value;
            }
            double ave = total / 10;
            
            lblAver.Text = ave.ToString("F2");

            fil.Close();
        }

        private void BtnSmallest_Click(object sender, EventArgs e)
        {
            int value;
            int initial = 100;
            StreamReader fil = new StreamReader("values.txt");

            for (int i = 0; i < 10; i++)
            {
                value = int.Parse(fil.ReadLine());
                if (value < initial)
                {
                    initial = value;
                }
            }
         

            lblSmallest.Text = initial.ToString();

            fil.Close();

        }

        private void BtnLarge_Click(object sender, EventArgs e)
        {
            int value;
            int initial = 0;
            StreamReader fil = new StreamReader("values.txt");

            for (int i = 0; i < 10; i++)
            {
                value = int.Parse(fil.ReadLine());
                if (value > initial)
                {
                    initial = value;
                }
            }


            lblLargest.Text = initial.ToString();

            fil.Close();
        }
    }