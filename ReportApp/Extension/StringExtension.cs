namespace ReportApp.Extension
{
    public static class StringExtention
    {
        public static string ContentPreview(this string text)
        {
            if (text.Length > 20)
            {
                text = text.Substring(0, 20);
                return text;
            }
            return text;
        }
    }
}
