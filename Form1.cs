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
            tbWords = SeparateWords(textBox1.Text);

            for (int i = 0; i < tbWords.Count; i++)
            {
                // MessageBox.Show(i.ToString());
                //MessageBox.Show(Convert.ToString(tbWords.Count-1));
                Words tempWord = new Words();
                tempWord.word = new List<string> { tbWords[i] };
                // MessageBox.Show(tempWord.word[0]);

                tempWord.wordLeanght = tbWords[i].Length;
                treeWords.Add(tempWord);

            }

        }

        private void btn_longest_word_Click(object sender, EventArgs e)
        {
            string firstMessage = new string("Думите/а с най-много символи е/са:");
            List<string> maxWord = new List<string>(treeWords.Max());
            maxWord.Insert(0, firstMessage);

            WordList forma = new WordList();
            forma.Show();

            for (int i = 0; i < maxWord.Count; i++)
            {

                forma.listView1.Items.Add(maxWord[i]);
            }


        }

        private void btn_number_search_Click(object sender, EventArgs e)
        {
            string firstMessage = new string("Думите/а с този брой символи е/са");
            List<string> searchedWords = new List<string>(treeWords.SearchByNumber(Convert.ToInt32(box_number_search.Value)));
            searchedWords.Insert(0, firstMessage);

            WordList forma = new WordList();
            forma.Show();

            for (int i = 0; i < searchedWords.Count; i++)
            {

                forma.listView1.Items.Add(searchedWords[i]);
            }

        }

        private void btn_specific_word_search_Click(object sender, EventArgs e)
        {

            MessageBox.Show(treeWords.SearchByWord(box_specific_word_search.Text));
       

        }

        public static List<string> SeparateWords(string text)
        {
            
            char[] delimiters = new char[] { ' ', '\t', '\n', '\r', ',', '.', ';', ':', '!', '?', '-', '_', '+', '=', '/', '\\', '[', ']', '{', '}', '(', ')', '<', '>', '\"', '\'' };
            List<string> wordList = new List<string>();
          wordList = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();  
           
            return wordList;
        }
    }
}