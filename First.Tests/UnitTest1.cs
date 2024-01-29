global using NUnit.Framework;
namespace First.Test;
public class Tests
{
    
    [SetUp]
    public void Setup()
    {
    }
    [Test]
    [TestCase(-15.0, 15.0)]       
    [TestCase(-3.5, 3.5)]      
    [TestCase(-9.0, 9.0)]      
    [TestCase(150.0, 22500.0)]
    [TestCase(5.5, 30.25)]      
    [TestCase(-7.3, 7.3)]       
    [TestCase(0.75, 0.5625)]    
    [TestCase(-2.8, 2.8)]       
    [TestCase(12.34, 152.2756)] 
    [TestCase(-6.66, 6.66)]

    public static void FirstEx_W1(double in_num, double out_result)
    {
        double result = FirstEx.W1(in_num);
        Assert.That(out_result, Is.EqualTo(result));
    }
    [Test]
    [TestCase(123, 321)]           
    [TestCase(111, 111)]        
    [TestCase(54321, 54321)]   
    [TestCase(0, 0)]            
    [TestCase(1234, 4321)]         
    [TestCase(987654321, 987654321)]       
    [TestCase(1001, 1100)]                  
    [TestCase(789, 987)]
    public static void FirstEx_W2(int in_num, int out_result)
    {
        int result = FirstEx.W2(in_num);
        Assert.That(out_result, Is.EqualTo(result));
    }
}