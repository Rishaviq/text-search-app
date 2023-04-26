namespace text_search_app
{
    public partial class Form1 : Form
    {
        List<string> tbWords = new List<string>();
        int a = 0;
        BinaryTree treeWords;

        public Form1()
        {
            InitializeComponent();
            treeWords = new BinaryTree();
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            tbWords=textBox1.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < tbWords.Count; i++) {
                MessageBox.Show(i.ToString());
                //MessageBox.Show(Convert.ToString(tbWords.Count-1));
                Words tempWord= new Words();
               // tempWord.word[1]=tbWords[1];
                
               // tempWord.wordLeanght = tbWords[i].Length;
               // treeWords.Add(tempWord);
            
            }
            
        }

       
    }
}