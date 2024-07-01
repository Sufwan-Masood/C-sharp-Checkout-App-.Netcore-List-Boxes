using System.ComponentModel.Design;

namespace List_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Available_Items.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Available_Items.Items.Remove(Available_Items.SelectedItem);
            //or 
            //Available_Items.Items.RemoveAt(Available_Items.SelectedIndex);
            Available_Items.ClearSelected();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckOut.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Available_Items_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckOut.Visible = true;
            CheckOut.Items.Add(Available_Items.SelectedItem);
            Available_Items.ClearSelected();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            double bill = 0;
            int ind = 0;
            foreach (var v in CheckOut.Items)
            {
                foreach (var c in Available_Items.Items)
                {
                    if (v == c)
                    {
                        ind = Available_Items.Items.IndexOf(c);
                        bill += double.Parse((string)Price_listBox.Items[ind]);
                    }
                }

            }
            label5.Visible = true;
            label5.Text = $"Your Bill is: ${bill}";
            label6.Visible = true;
            label6.Text = $"Pay ${bill} Now";
        }

    }
}
