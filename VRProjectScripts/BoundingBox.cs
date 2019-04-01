using System;
namespace Furniture_Placement
{
    public class Boundingbox
    {
        // Data members

        public readonly float Width;
        public readonly float Height;
        public readonly float Depth;


        // Constructor

        public Boundingbox(float width, float depth, float height)
        {
            Width = width;
            Depth = depth;
            Height = height;
           
        }
    }
}
