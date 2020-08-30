using System;
using System.Collections.Generic;
using System.Text;

namespace AssociacaoProjeto2.Entities
{
    class Comment
    {
        public String text { get; set; }

        public Comment(string text)
        {
            this.text = text;
        }
    }
}
