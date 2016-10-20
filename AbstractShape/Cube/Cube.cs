using _3DShapes;
using System;
using TheCoolestShapes;

namespace TheCoolestShapes
{
    public class Cube : a3DShape
    {
        public Cube(double x = 0)
        {
            this.Name = "Cube";
            this.apoint.x = x;
            this.volume = GetVolume();
            this.surfacearea = GetSurfaceArea();
            this.ImagePath = null;
        }

        public override double GetSurfaceArea()
        {
            surfacearea = (6 * apoint.x) * (6 * apoint.x);
            return surfacearea;
        }
    }
}
