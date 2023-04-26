namespace text_search_app
{
    public partial class Form1 : Form
    {
        class words {
            int wordLeanght;
            List<string> word=new List<string>();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}