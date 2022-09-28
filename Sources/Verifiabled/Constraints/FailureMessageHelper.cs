using System.Text;

namespace Verifiabled.Constraints
{
    public static class FailureMessageHelper
    {
        public static string FormMessageFromExpectedAndActual(string expected, string actual)
        {
            if (expected == null)
                expected = "null";

            if (actual == null)
                actual = "null";

            var builder = new StringBuilder("Assertion failed.");
            builder.AppendLine($"Expected: {expected}");
            builder.AppendLine($"Actual: {actual}");
            return builder.ToString();
        }
    }
}
