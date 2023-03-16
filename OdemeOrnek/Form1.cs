namespace OdemeOrnek
{
    public partial class Form1 : Form
    {
        string secilenOdemeTipi = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tutar = Convert.ToDouble(textBox1.Text);
            IOdemeTipi iOdemeTipi;
            OdemeIslemiFactory factory = new OdemeIslemiFactory();
            iOdemeTipi = factory.NesnesiniOlustur(secilenOdemeTipi);
            OdemeIslemi odemeIslemi = new OdemeIslemi(iOdemeTipi);
            string gelenMesaj = odemeIslemi.Ode(tutar);
            MessageBox.Show(gelenMesaj);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenOdemeTipi = comboBox1.SelectedItem.ToString();
        }
    }
}