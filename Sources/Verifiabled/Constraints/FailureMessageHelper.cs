namespace Verifiabled.Constraints
{
    public static class FailureMessageHelper
    {
        public static string FromExpectedAndActual(object? expected, object? actual)
        {
            expected ??= "null";
            actual ??= "null";

            var builder = new StringBuilder();
            builder.AppendLine($"Expected: {expected}");
            builder.AppendLine($"Actual: {actual}");
            return builder.ToString();
        }

        public static string FromExpectedAndActual(Type expected, Exception actual)
        {
            var builder = new StringBuilder();
            builder.AppendLine($"Expected: {expected.Name}");
            builder.AppendLine($"Actual: {actual.GetType().Name}");
            return builder.ToString();
        }
    }
}
