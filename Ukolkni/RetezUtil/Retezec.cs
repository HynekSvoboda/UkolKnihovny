namespace RetezUtil
{
    public class Retezec
    {
        static public string Smaz(string vstup)
        {
            foreach (char c in vstup)
            {
                if (c >= '0' && c <= '9') vstup=vstup.Replace(c,' ');
            }

            while (vstup.Contains("  "))
            {
                vstup = vstup.Replace("  ", " ");
            }

            return vstup;
        }
    }
}