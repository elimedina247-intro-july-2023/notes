namespace CSharpSyntax
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddTwoNumbers()
        {
            // Given
            int a = 10; int b = 20; int answer;
            //When
            answer = a + b; //System under test

            //Then
            Assert.Equal(30, answer);


        }
        [Theory]
        [InlineData(10,20,30)] //One test multiple inputs.
        [InlineData(2,8,10)]
        [InlineData(2,2,4)]
        public void CanAddAnyTwoIntegers(int a, int b, int expected)
        {
            int answer = a + b;
            Assert.Equal(expected, answer);
        }
    }
}