using System;

namespace VinterProjekt
{
    public class Spices : Ingredients
    {
        public Spices(int _score, int _price, string _name)
        {
            score = _score;
            price = _price;
            name = _name;
        }
    }
}