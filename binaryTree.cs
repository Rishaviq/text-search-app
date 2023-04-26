using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_search_app
{
    internal class BinaryTree
    {
        Node root;
        public BinaryTree()
        {
            this.root = null;
        }



        public void Add(Words value) {
            Node newNode = new Node(value);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node currentNode = root;
                while (true)
                {
                    if (value.CompareTo(currentNode.data) == -1)
                    {
                        if (currentNode.left == null)
                        {
                            currentNode.left = newNode;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.left;
                        }
                    }
                    else if (value.CompareTo(currentNode.data) == 1)
                    {
                        if (currentNode.right == null)
                        {
                            currentNode.right = newNode;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.right;
                        }
                    }
                    else {
                        for (int i = 0; i < currentNode.data.word.Count; i++) {
                            if (currentNode.data.word[i] != newNode.data.word[0]) {
                                currentNode.data.word.Add(newNode.data.word[0]);
                                break;
                            }
                           break;
                        }
                        break;
                    
                    }
                }
            }
        }






        public List<string> Max() {
            
            Node currentNode=root;
            while (true) {
                if (currentNode.right == null)
                {
                    return currentNode.data.word;
                }
                else { currentNode = currentNode.right; }
            
            }
        }





        public List<string> SearchByNumber(int charactersNumber) {
            Node currentNode=root;
            while (true)
            {
                if (currentNode.data.wordLeanght > charactersNumber)
                {
                    if (currentNode.left != null)
                    {
                        currentNode = currentNode.left;
                    }
                    else
                    {
                        List<string> temp = new List<string> { "няма дума с толкова брой символи" };
                        return temp;

                    }
                }
                else if (currentNode.data.wordLeanght < charactersNumber)
                {
                    if (currentNode.right != null)
                    {
                        currentNode = currentNode.right;
                    }
                    else
                    {
                        List<string> temp = new List<string> { "няма дума с толкова брой символи" };
                        return temp;

                    }


                }

                else {
                    return currentNode.data.word;
                
                
                }
            }
        }






        public string SearchByWord(string keyWord) {
            
           List<string> closeWords = SearchByNumber(keyWord.Length);
            for (int i=0; i < closeWords.Count; i++) {
                if (closeWords[i] == keyWord)
                {
                    return "текстът съдържа тази дума";
                }
                else return "въведената дума не се намира в текста";
            }

            return "въведената дума не се намира в текста";
        }
    }
}
