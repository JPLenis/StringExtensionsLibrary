namespace StringExtensionsLibrary
{
    public static class StringExtensions
    {
        public static bool StartsWithUpperCase(this string input)
        {
            return !string.IsNullOrEmpty(input) && char.IsUpper(input[0]);
        }
    }
}
