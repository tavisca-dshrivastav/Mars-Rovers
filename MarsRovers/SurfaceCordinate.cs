using System;

namespace MarsRovers
{
    public class SurfaceCordinate
    {
        private int X_Axis;
        private int Y_Axis;
        public SurfaceCordinate(int X_axis, int Y_axis)
        {
            X_Axis = X_axis;
            Y_Axis = Y_axis;
        }

        public int getXAxis()
        {
            return X_Axis;
        }

        public int getYAxis()
        {
            return Y_Axis;
        }
    }
}
