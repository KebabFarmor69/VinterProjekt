using System;

namespace VinterProjekt
{
    public class Protein : Ingredients
    {
        public Protein(int _score, int _price, string _name)
        {
            score = _score;
            price = _price;
            name = _name;

        }
    }
}