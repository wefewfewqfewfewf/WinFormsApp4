namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int licznik = 0;
        private int licznik2 = 0;   
        private int czas = 60;
        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "mocarny klikacz";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "szeFITO";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            if (czas > 0)
                czas = czas - 1;
            { label2.Text = czas + ""; }
         if(czas==0)
            { button1.Enabled = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            licznik++;
            licznik2++; 
            label3.Text = licznik.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            czas = 60;
            button1.Enabled = true;
            licznik=0;
            label3.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            

            label5.Text = licznik.ToString();
            
         
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = "asdf";   
        }
    }
}

        
    
