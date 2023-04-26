using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_search_app
{
    internal class Words : IComparable<Words>
    {
        int wordLeanght;
        List<string> word = new List<string>();

        public int CompareTo(Words that) {
            if (this.wordLeanght < that.wordLeanght) { return -1; }
            if (this.wordLeanght == that.wordLeanght) { return 0; }
            return 1;
        }
    }
}
