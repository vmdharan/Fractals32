using System;

namespace PlasmaFractals
{
    public class PlasmaFractals
    {
        // Dimensions
        public int height = 513;
        public int width = 513;
        // Data
        public Pixel[,] data;

        private Random rand1;

        // Roughness
        private double R_FACTOR = 0.28;
        // Maximum magnitude of change
        private double HMAX = 255.0;

        // Constructor
        public PlasmaFractals(double rough, double intense)
        {
            rand1 = new Random();
            R_FACTOR = rough;
            HMAX = intense;
        }

        // Method to initialise the pixel array.
        public void initialiseData()
        {
            int i, j;

            data = new Pixel[width, height];
            for (i = 0; i < width; i++)
            {
                for (j = 0; j < height; j++)
                {
                    data[i,j] = new Pixel(i, j, 0x00, 0x00, 0x00, 0x00);
                }
            }
        }

        // The entry point for the Plasma Fractal algorithm.
        public void createFractal()
        {
            double roughness = R_FACTOR;    // Initial roughness
            double maxDiff = HMAX;          // Initial color intensity

            // Initialise the four corner pixels of the image with random 
            // color intensites.
            Pixel TL = new Pixel(0, 0, randomColour(maxDiff), randomColour(maxDiff),
                    randomColour(maxDiff), randomColour(maxDiff));

            Pixel TR = new Pixel(width - 1, 0, randomColour(maxDiff), randomColour(maxDiff),
                    randomColour(maxDiff), randomColour(maxDiff));

            Pixel BL = new Pixel(0, height - 1, randomColour(maxDiff), randomColour(maxDiff),
                    randomColour(maxDiff), randomColour(maxDiff));

            Pixel BR = new Pixel(width - 1, height - 1, randomColour(maxDiff), randomColour(maxDiff),
                    randomColour(maxDiff), randomColour(maxDiff));

            // Start the recursive subdivision of the image.
            subdivide_Poly(TL, TR, BR, BL, maxDiff, roughness);
        }

        // Method to recursively subdivide and colour the image.
        public void subdivide_Poly(Pixel TL, Pixel TR, Pixel BR, Pixel BL,
                double maxDiff, double rough)
        {
            // Initialise the new midpoint pixels.
            Pixel LM = new Pixel();     // Left midpoint
            Pixel RM = new Pixel();     // Right midpoint
            Pixel TM = new Pixel();     // Top midpoint
            Pixel BM = new Pixel();     // Bottom midpoint
            Pixel M = new Pixel();      // Geometric midpoint

            // Obtain the midpoints.
            M = calcMid2(TL, TR, BR, BL, maxDiff);
            LM = calcMid(TL, BL, maxDiff);
            RM = calcMid(TR, BR, maxDiff);
            TM = calcMid(TL, TR, maxDiff);
            BM = calcMid(BL, BR, maxDiff);

            // Update and reduce the color range for the next subdivision.
            if (maxDiff > 1)
            {
                maxDiff = Math.Pow(2, -HMAX);
            }
            else {
                maxDiff = 1;
            }

            // Recursively subdivide each of the four polygons until 
            // the size of each subdivision reaches a single pixel.
            if ((TR.getX() - TL.getX()) >= 2)
            {
                subdivide_Poly(TL, TM, M, LM, maxDiff, rough);
                subdivide_Poly(TM, TR, RM, M, maxDiff, rough);
                subdivide_Poly(LM, M, BM, BL, maxDiff, rough);
                subdivide_Poly(M, RM, BR, BM, maxDiff, rough);
            }
            else if ((TR.getX() - TL.getX()) < 2)
            {
                // Add the color intensity to the pixel array.
                addToPixelArray(TL, TR, BR, BL);
            }
        }

        // Calculate the midpoint of two pixels and apply a 
        // random colour intensity.
        public Pixel calcMid(Pixel A, Pixel B, double maxDiff)
        {
            Pixel Mid = new Pixel();
            Mid.setX((int)(A.getX() + B.getX()) / 2);
            Mid.setY((int)(A.getY() + B.getY()) / 2);

            Mid.setA((int)(A.getA() + B.getA()) / 2 + (int)randomColour(maxDiff));
            Mid.setR((int)(A.getR() + B.getR()) / 2 + (int)randomColour(maxDiff));
            Mid.setG((int)(A.getG() + B.getG()) / 2 + (int)randomColour(maxDiff));
            Mid.setB((int)(A.getB() + B.getB()) / 2 + (int)randomColour(maxDiff));

            return Mid;
        }

        // Calculate the midpoint given four pixels and apply a 
        // randome colour intensity.
        public Pixel calcMid2(Pixel A, Pixel B, Pixel C, Pixel D, double maxDiff)
        {
            Pixel Mid = new Pixel();
            Mid.setX((int)(A.getX() + B.getX() + C.getX() + D.getX()) / 4);
            Mid.setY((int)(A.getY() + B.getY() + C.getY() + D.getY()) / 4);

            Mid.setA((int)(A.getA() + B.getA() + C.getA() + D.getA()) / 4
                    + (int)randomColour(maxDiff));
            Mid.setR((int)(A.getR() + B.getR() + C.getR() + D.getR()) / 4
                    + (int)randomColour(maxDiff));
            Mid.setG((int)(A.getG() + B.getG() + C.getG() + D.getG()) / 4
                    + (int)randomColour(maxDiff));
            Mid.setB((int)(A.getB() + B.getB() + C.getB() + D.getB()) / 4
                    + (int)randomColour(maxDiff));

            return Mid;
        }

        // Method to add the colour intensities to the pixel array.
        public void addToPixelArray(Pixel TL, Pixel TR, Pixel BR, Pixel BL)
        {
            Pixel temp = new Pixel();

            int ty1 = (int)(TL.getY());
            int tx1 = (int)(TL.getX());

            int ty2 = (int)(TR.getY());
            int tx2 = (int)(TR.getX());

            int ty3 = (int)(BR.getY());
            int tx3 = (int)(BR.getX());

            int ty4 = (int)(BL.getY());
            int tx4 = (int)(BL.getX());

            temp = data[tx1,ty1];
            data[tx1,ty1] = TL;

            temp = data[tx2,ty2];
            data[tx2,ty2] = TR;

            temp = data[tx3,ty3];
            data[tx3,ty3] = BR;

            temp = data[tx4,ty4];
            data[tx4,ty4] = BL;
        }

        // Method to get the average colour intensity for two pixels.
        public Pixel getAvgColour(Pixel A, Pixel B)
        {
            Pixel avg = new Pixel();
            avg.setX(A.getX());
            avg.setY(A.getY());
            avg.setA((A.getA() + B.getA()) / 2);
            avg.setR((A.getR() + B.getR()) / 2);
            avg.setG((A.getG() + B.getG()) / 2);
            avg.setB((A.getB() + B.getB()) / 2);
            return avg;
        }

        // Method to return a random colour intensity.
        public int randomColour(double diff)
        {
            return (int)(rand1.NextDouble() * diff);
        }
    }
}
