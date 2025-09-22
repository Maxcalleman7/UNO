using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO
{
    public class Card
    {
        public string color { get; private set; }
        public string name { get; private set; }
        public Card(string color, string name)
        {
            this.color = color;
            this.name = name;
        }

        public void ShowCard()  //konverterar kortets färg och värde till sträng, skriver ut det, men ej på ny rad så att korten visas som (kort1 kort2) och inte (kort1
                                                                                                                                                                 //kort2)
        {
            string shown_card="|";
            
            shown_card=shown_card+ color.ToString();
            shown_card=shown_card+" "+ name.ToString()+"| ";
            Console.Write(shown_card);
        }





    }
}
