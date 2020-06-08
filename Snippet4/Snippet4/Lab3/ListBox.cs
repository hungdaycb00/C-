﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class ListBox : Window
    {
        private string listBoxContents;
        public ListBox(int top, int left, string contents) : base(top, left)
        {
            listBoxContents = contents;
        }

        public override void DrawWindow()
        {
            {
                base.DrawWindow();
                Console.WriteLine("Writing string to the listbox: {0}", listBoxContents);
            }
        }
    }
}
