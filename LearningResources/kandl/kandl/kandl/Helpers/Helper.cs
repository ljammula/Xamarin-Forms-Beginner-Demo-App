using System;

namespace kandl.Helpers
{
    static class Helper
    {
        public static string GetRandomGUID()
        {
            // Get the GUID
            string guidResult = Guid.NewGuid().ToString();

            // Remove the hyphens and convert to uppercase
            guidResult = guidResult.Replace("-", string.Empty).ToUpper();

            return guidResult;
        }
    }
}
