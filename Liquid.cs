using System;

namespace VinterProjekt
{
    public class Liquid : Ingredients
    {
        public Liquid(int _score, int _price, string _name)
        {
            score = _score;
            price = _price;
            name = _name;
        }
    }
}