using CMouss.Polyscan;

namespace CMouss.PolyScanTester
{
    public partial class Form1 : Form
    {
        Polyscan.PolyClient poly = new("");

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBalance.Text = poly.GetBalance(textBox1.Text).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            poly = new(txtApiKey.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBalances.Text = poly.GetBalances(new List<string>() { "0x5C12BAc5ff8E6BadC0a807fbe8aa11EDDe8b663e" })[0].Balance.ToString();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            List<NormalTransaction> normalTransactions = await poly.GetNormalTransactionsAsync(textBox3.Text, 0, 99999999, 1, 25, SortingMode.Ascending);
            dataGridView1.DataSource = normalTransactions;
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            List<InternalTransaction> InternalTransactions = await poly.GetInternalTransactionsAsync(textBox2.Text, 0, 99999999, 1, 25, SortingMode.Ascending);
            dataGridView2.DataSource = InternalTransactions;
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            List<ERC721Transaction> eRC721Transactions = await poly.GetERC721TokenTransactionsAsync(textBox4.Text, null, 0, 9999999999, 1, 25, SortingMode.Ascending);
            dataGridView3.DataSource = eRC721Transactions;
        }
    }
}