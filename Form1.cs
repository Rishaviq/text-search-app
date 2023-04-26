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
           
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            treeWords = new BinaryTree();
            tbWords =textBox1.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < tbWords.Count; i++) {
               // MessageBox.Show(i.ToString());
                //MessageBox.Show(Convert.ToString(tbWords.Count-1));
                Words tempWord= new Words();
                tempWord.word = new List<string> { tbWords[i] };
               // MessageBox.Show(tempWord.word[0]);

                tempWord.wordLeanght = tbWords[i].Length;
                treeWords.Add(tempWord);
            
            }
            
        }

        private void btn_longest_word_Click(object sender, EventArgs e)
        {
           string combinedWords = new string("най-голямата дума е ");
            List<string> maxWord = new List<string>(treeWords.Max());
            for (int i = 0; i < maxWord.Count; i++)
            {
                if (i > 0)
                {
                   
                    combinedWords = combinedWords + " и " + maxWord[i]; ;
                }
                else
                {
                    combinedWords = combinedWords + maxWord[i];
                    
                }
            }
            MessageBox.Show(combinedWords);
        }
    }
}