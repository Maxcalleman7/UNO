using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO
{
    public class Card
    {
        private string color;
        private string value;
        public Card(string color, string value)
        {
            this.color = color;
            this.value = value;
        }

        public void ShowCard()  //konverterar kortets färg och värde till sträng, skriver ut det, men ej på ny rad så att korten visas som (kort1 kort2) och inte (kort1
                                                                                                                                                                 //kort2)
        {
            string shown_card="[";
            
            shown_card=shown_card+ color.ToString();
            shown_card=shown_card+" "+ value.ToString()+"] ";
            Console.Write(shown_card);
        }





    }
}
