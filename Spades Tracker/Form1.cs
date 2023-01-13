using System.Windows.Forms.VisualStyles;

namespace Spades_Tracker
{
    public partial class Form1 : Form
    {
        private ComboBox[] cards;
        private ComboBox[] suits;

        // IN PROGRESS
        public Form1()
        {
            InitializeComponent();

            cards = new List<ComboBox>()
            {
                cboCard1,
                cboCard2,
                cboCard3,
                cboCard4,
                cboCard5,
                cboCard6,
                cboCard7,
                cboCard8,
                cboCard9,
                cboCard10,
                cboCard11,
                cboCard12,
                cboCard13,
            }.ToArray();

            suits = new List<ComboBox>()
            {
                cboSuit1,
                cboSuit2,
                cboSuit3,
                cboSuit4,
                cboSuit5,
                cboSuit6,
                cboSuit7,
                cboSuit8,
                cboSuit9,
                cboSuit10,
                cboSuit11,
                cboSuit12,
                cboSuit13,
            }.ToArray();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Tomato;

            StreamReader sr = new StreamReader("YourHand.txt");

            List<string> lines = new List<string>();

            string currentLine;
            int i = 0;

            while ((currentLine = sr.ReadLine())!= null)
            {
                lines.Add(currentLine);
                cards[i].Text = currentLine.Split("\t")[0];
                suits[i].Text = currentLine.Split("\t")[1];
                i++;
            }

            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Navy;

            FileStream fs = new FileStream("YourHand.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            for(int i = 0; i < cards.Length; i++)
            {
                sw.WriteLine(string.Format("{0}\t{1}", cards[i].Text, suits[i].Text));
            }

            sw.Close();
            fs.Close();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}