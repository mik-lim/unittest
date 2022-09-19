using Xunit;
using Microsoft.AspNetCore.Mvc;


namespace unittest;

public class UnitTest1
{

    [Fact]
    public void CalculateSumTest()
    {
        Assert.Equal("{'sum' : 11}", CalculateSum(5, 6));
    }

    public string CalculateSum(int a, int b)
    {
        int sum = a + b;
        string res = "{'sum' : " + sum + "}";
        //Console.WriteLine(res);
        return res;
    }
}