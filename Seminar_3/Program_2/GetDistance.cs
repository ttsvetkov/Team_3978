 public class GetDistance
    {
        public static double Distance(string[] X, string[] Y)
        {
            int[] Xint = Array.ConvertAll(X, int.Parse);
            int[] Yint = Array.ConvertAll(Y, int.Parse);

            double distance = Math.Sqrt(Math.Pow(Xint[0]-Yint[0], 2) + Math.Pow(Xint[1]-Yint[1], 2) + Math.Pow(Xint[2]-Yint[2], 2));

            return distance;
        }
    }
