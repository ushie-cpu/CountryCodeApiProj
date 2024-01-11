namespace Services.Extensions
{
    public static class Extensions
    {
        public static int GetCountryCode(this string phoneNumber)
        {
            int countryCode = default(int); 
            if(!string.IsNullOrWhiteSpace(phoneNumber) && phoneNumber.Length >= 3)
            {
                var code = phoneNumber.Substring(0, 3);
                int.TryParse(code, out countryCode);   
            };
            return countryCode;
        }
    }
}
