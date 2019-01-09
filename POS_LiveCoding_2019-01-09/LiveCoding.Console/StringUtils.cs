namespace LiveCoding.Console
{
    public static class StringUtils
    {
        public static int CountChars(this string text, char ch, bool ignoreCase = true)
        {
            int cnt = 0;

            foreach (char c in text)
            {
                if (ignoreCase)
                {
                    if (c.ToUpper() == ch.ToUpper())
                    {
                        cnt++;
                    }
                }
                else
                {
                    if (c == ch)
                    {
                        cnt++;
                    }
                }
            }

            return cnt;
        }
    }
}
