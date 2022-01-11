using System;

namespace VinterProjekt
{
    public class Vegetables : Ingredients
    {
        public Vegetables(int _score, int _price, string _name)
        {
            score = _score;
            price = _price;
            name = _name;
        }
    }
}