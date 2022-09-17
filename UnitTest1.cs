using Xunit;

namespace unittest;

public class UnitTest1
{

    [Fact]
    public void CalculateSumTest()
    {
        Assert.Equal("{'sum' : 11}", CalculateSum(5, 9));
    }


    int Add(int x, int y)
    {
        return x + y;
    }

    public string CalculateSum(int a, int b)
    {
        int sum = a + b;
        string res = "{'sum' : " + sum + "}";
        //Console.WriteLine(res);
        return res;
    }
}