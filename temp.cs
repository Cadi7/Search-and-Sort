namespace C___Individual
{
    public static class temp {

       public static string asortare = null;
       public static string tipsortare = null;
       public static string tipparcurgere = null;

        public static string initial()
        {
            string matrixString = "";
            for (int i = 0; i < sortari.b.Length; i++)
            {
                for (int j = 0; j < sortari.b[0].Length; j++)
                {
                    matrixString += sortari.b[i][j].ToString();
                    matrixString += " ";
                }

                matrixString += Environment.NewLine;
            }
            return matrixString;
        }
       
        public static string sortat()
        {
            string matrixString = "";
            for (int i = 0; i < sortari.a.Length; i++)
            {
                for (int j = 0; j < sortari.a[0].Length; j++)
                {
                    matrixString += sortari.a[i][j].ToString();
                    matrixString += " ";
                }
                matrixString += Environment.NewLine;
            }
            return matrixString;
        }
    }
}