﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_search_app
{
    internal class Words : IComparable<Words>
    {
       public int wordLeanght;
      public  List<string> word = new List<string>();

        public int CompareTo(Words that) {
            if (this.wordLeanght < that.wordLeanght) { return -1; }
            if (this.wordLeanght == that.wordLeanght) { return 0; }
            return 1;
        }

       public Words() {
       this.word = new List<string>();
        }
    }
}
