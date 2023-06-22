namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            await esperar();
            MessageBox.Show("listo!");
            pictureBox1.Visible = false;
        }

        private async Task esperar()
        {
            await Task.Delay(5000);
        }
            
    }
}