namespace WebApplicationX0.Services
{
     
    public static class RomeNumberExtension
    {
        private readonly static int[] divs = new int[]           { 1000,900, 500,400, 100, 90, 50, 40,   10,   9,   5,   4,  1 };
        private readonly static string[] divs_str = new string[] { "M","CM", "D","CD","C","XC","L","XL", "X","IX", "V","IV", "I" };

        public static string? RomeNumber(this int? Number)
        {
            string str = "";
            if ((Number == null) ||(Number==0)) return "0";
            int? number = Number;
            int i = 0;
            do
            {
                if (number >= divs[i])
                {
                    str += divs_str[i];
                    number -= divs[i];
                }
                else
                { i++; }
            }
            while (number > 0);

            return str;
        }
    }
}
