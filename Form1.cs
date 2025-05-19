namespace Chap13Test3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.MouseDown += label1_MouseDown;
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.BackColor = (e.Button == MouseButtons.Left) ? Color.Green : 
                (e.Button == MouseButtons.Right) ? Color.YelloW :label1.BackColor;
        }
    }
}
