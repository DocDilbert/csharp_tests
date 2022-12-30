namespace blabla;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var a = new A();
        Assert.Equal(4, 3);
    }

    [Fact]
    public void Test2()
    {
        var a = new A();
        Assert.Equal(4, 4);
    }
}
