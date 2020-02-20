using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace g3.Tests
{
    public static class AssertExtensions
    {
        public static void AreEqual(Vector2d expected, Vector2d actual)
        {
            if (!expected.EpsilonEqual(actual, MathUtil.Epsilon))
                throw new AssertFailedException($"AssertExtensions.Assert failed. Expected:{expected}. Actual{actual}");
        }

    }
}
