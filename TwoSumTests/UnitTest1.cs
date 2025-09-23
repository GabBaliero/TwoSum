using Xunit;
using TwoSum;

namespace TwoSumTests
{
    public class UnitTest1
    {
        [Fact]
        public void Should_Find_Correct_Indices_For_Target()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            var result = Program.TwoSum(nums, target);
            Assert.NotNull(result);
            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void Should_Handle_Negative_Numbers()
        {
            int[] nums = { -3, 4, 3, 90 };
            int target = 0;
            var result = Program.TwoSum(nums, target);
            Assert.NotNull(result);
            Assert.Equal(new int[] { 0, 2 }, result);
        }

        [Fact]
        public void Should_Handle_Duplicates()
        {
            int[] nums = { 3, 3 };
            int target = 6;
            var result = Program.TwoSum(nums, target);
            Assert.NotNull(result);
            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Fact]
        public void Should_Return_Null_When_No_Solution()
        {
            int[] nums = { 1, 2, 3 };
            int target = 10;
            var result = Program.TwoSum(nums, target);
            Assert.Null(result);
        }

        [Fact]
        public void Should_Find_Indices_When_Last_Elements_Match()
        {
            int[] nums = { 1, 2, 3, 4, 6 };
            int target = 10;
            var result = Program.TwoSum(nums, target);
            Assert.NotNull(result);
            Assert.Equal(new int[] { 3, 4 }, result);
        }
    }
}
