namespace FormularioGFI
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
            cmbColor.SelectedIndex = 0;
        }

        

        private void jugar(object sender, EventArgs e)
        {
            
            Form3 form = new Form3(cmbColor.SelectedItem.ToString());
            form.Show();
            this.Hide();

        }

    }
}
