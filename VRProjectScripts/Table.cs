using System;

namespace Furniture_Placement
{
    public class Table : Furniture
    {
        //Probability of standing against a wall
        public float p_wall;
        public string colour;

        public Table(float prob, string col, float width, float depth, float height, string name)
            : base(width, depth, height, name)
        {
            p_wall = prob;
            colour = col;

        }



    }
}