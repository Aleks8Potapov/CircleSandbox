using AppForTests;

namespace SampleApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var sourceString = @"ä'á`č-ď_ěéíľľňôóřŕšťúůýž ÄÁČĎĚÉÍĽĽŇÔÓŘŔŠŤÚŮÝŽ ÖÜË łŁđĐ ţŢşŞçÇ øı";
            var result = Helper.RemoveDiacritics(sourceString);
            var expected = @"a'a`c-d_eeillnoorrstuuyz AACDEEILLNOORRSTUUYZ OUE łŁđĐ tTsScC øı";

            Assert.Equal(expected, result);
        }
    }
}