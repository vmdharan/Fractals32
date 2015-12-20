using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals32
{
    // Define the pixel format
    public class Pixel
    {
        private int x;          // X position
        private int y;          // Y position
        private int[] col;      // Colour

        // Constructors
        public Pixel()
        {
            x = 0;
            y = 0;

            col = new int[4];
            col[0] = 0x00;
            col[1] = 0x00;
            col[2] = 0x00;
            col[3] = 0x00;
        }

        public Pixel(int x, int y, int r, int g, int b, int a)
        {
            this.x = x;
            this.y = y;

            col = new int[4];
            col[0] = 0x000000FF & a;
            col[1] = 0x000000FF & r;
            col[2] = 0x000000FF & g;
            col[3] = 0x000000FF & b;
        }

        // Mutators
        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public void setR(int r)
        {
            col[1] = 0x000000FF & r;
        }

        public void setG(int g)
        {
            col[2] = 0x000000FF & g;
        }

        public void setB(int b)
        {
            col[3] = 0x000000FF & b;
        }

        public void setA(int a)
        {
            col[0] = 0x000000FF & a;
        }

        // Accessors
        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public int getR()
        {
            return col[1];
        }

        public int getG()
        {
            return col[2];
        }

        public int getB()
        {
            return col[3];
        }

        public int getA()
        {
            return col[0];
        }
    }
}
