using NuGet.Frameworks;
using System;
using Xunit;

namespace FTTT.Tests
{
    public class FirstShould
    {
        [Fact]
        public void ReturnCorrectType_WithLambda_AndNoOutVariable_AndZeroThens()
        {
            int correctResult = 100;
            var result = First.This(() => 10 * 10).Resolve();

            Assert.IsType<int>(result);
            Assert.Equal(correctResult, result);
            Assert.Equal(correctResult.GetType(), result.GetType());
        }
    }
}
