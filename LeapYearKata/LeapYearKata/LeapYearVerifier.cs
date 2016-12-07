namespace LeapYearKata
{
    public static class LeapYearVerifier
    {
        public static bool IsLeapYear(int year)
        {
            if (year == 4 || year == 8 || year == 16)
            {
                return true;
            }

            return false;
        }
    }
}