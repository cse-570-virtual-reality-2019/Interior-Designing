namespace Furniture_Placement
{
    public class Furniture
    {
        // Data members
        public enum StaticFaceTypes
        {
            Seat_Type,
            Table,
            Accessories
        };

        public Furniture_Placement.Boundingbox boundingbox;
        public string Name;
        public float[] clearance_distance;

        // Constructor

        public Furniture(float width, float depth, float height, string name)
        {
            boundingbox = new Boundingbox(width, depth, height);
            Name = name;
            clearance_distance = new float[4] { 0f, 0.0f, 0.0f, 0.0f};
        }

        public void set_Name(string name)
        {
            Name = name;

        }

        public void set_ClearanceDistance(float[] arr)
        {
            clearance_distance = arr;
        }

    }
}
