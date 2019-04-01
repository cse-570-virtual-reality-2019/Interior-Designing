using System;

namespace Furniture_Placement
{
    public class Accessories : Furniture
    {
        //Probability of standing against a wall

        public string ground_feature;

        public Accessories(string feature, float width, float depth, float height, string name)
            : base(width, depth, height, name)
        {
            ground_feature = feature;

        }



    }
}