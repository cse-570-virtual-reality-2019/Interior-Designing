using System;

namespace Furniture_Placement
{
    public class Seat_Type : Furniture
    {
        //Probability of standing against a wall
        public float p_wall;
        public string colour;

        public Seat_Type(float prob, string col, float width, float depth, float height, string name)
            : base(width, depth, height, name)
        {
            p_wall = prob;
            colour = col;

        }



    }
}