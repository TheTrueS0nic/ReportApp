namespace ReportApp.Extension
{
    public static class StringExtention
    {
        public static string TrimText(this string text, int size = 20)
        {
            if (text.Length > size)
            {
                text = text.Substring(0, size);
                return text;
            }
            return text;
        }
    }
}
