using System.Text;

namespace Verifiabled.Constraints
{
    public static class FailureMessageHelper
    {
        public static string FromExpectedAndActual(object expected, object actual)
        {
            if (expected == null)
                expected = "null";

            if (actual == null)
                actual = "null";

            var builder = new StringBuilder("Assertion failed.\n");
            builder.AppendLine($"Expected: {expected.ToString()}");
            builder.AppendLine($"Actual: {actual.ToString()}");
            return builder.ToString();
        }
    }
}
