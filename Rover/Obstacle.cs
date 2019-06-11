using System;
using System.Collections.Generic;




public class Obstacle : IPoint
{
    int? x = null;
    int? y = null;

    public Obstacle(int? x, int? y)
    {
        this.x = x;
        this.y = y;
    }

    public int? X
    {
        get
        {
            if (x != null)
            {
                return x;
            }
            else
            {
                throw new Exception("The X Point coordinate of obstacle has not been set");
            }
        }
        set { x = value; }
    }
    public int? Y
    {
        get
        {
            if (y != null)
            {
                return y;
            }
            else
            {
                throw new Exception("The Y point coordinate of obstacle has nor been set");
            }
        }
        set { y = value; }
    }

   
 public override bool Equals(object obj)
{
   bool isEqual = false;
   if (obj == null || !this.GetType().Equals(obj.GetType()))
   {
       return false;
   }
   else
   {
       Obstacle pointPassed = (Obstacle)obj;
       if (this.x.Value == pointPassed.X.Value && this.y.Value == pointPassed.Y.Value)
       {
           return true;
       }
   }
   return isEqual;
}


}
