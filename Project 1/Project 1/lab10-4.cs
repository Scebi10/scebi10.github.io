 public Form1()
        {
            InitializeComponent();
        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter userInfo = new StreamWriter("Contact.txt",true);
                userInfo.WriteLine(txbName.Text);
                userInfo.WriteLine(txbAddress.Text);
                userInfo.WriteLine(txbPhone.Text);
                txbAddress.Text = "";
                txbName.Text = "";
                txbPhone.Text = "";
             
                userInfo.Close();
            }
            catch (IOException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
           // string input;
            try
            {
                StreamReader readFile = new StreamReader("Contact.txt");
               tbDisplay.Text = readFile.ReadToEnd();

                readFile.Close();
            }
            catch (IOException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
		
		
		
		 class User
    {
        string name, address;
        string phone;

        public User()
        {

        }
        public User(string nam, string addr, string fone)
        {
            name = nam;
            address = addr;
            phone = fone;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Phone
        {
            set 
            {
                if(value.Length == 10)
                {
                    phone = value;
                }
                else
                {
                    phone = "0000000000";
                }
            }
            get { return address; }
        }
        public string Address
        {
            set { address = value; }
            get { return address; }
        }
        public override string ToString()
        {
            string output = "";
            output += string.Format("{0}, {1} ", name, address);
            output += string.Format("({0}), {1}-{2} ", phone.Substring(0,2), phone.Substring(3, 5), phone.Substring(6, 9));
            return output;
        }
    }
	