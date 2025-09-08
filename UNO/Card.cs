using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO
{
    internal class Card
    {
        private string color;
        private string value;
        public Card(string color, string value)
        {
            this.color = color;
            this.value = value;
        }

        public string ShowCard()
        {
            string shown_card="";
            ;
            shown_card=color.ToString();
            shown_card=shown_card+ value.ToString();
            return null;
        }





    }
}
