using TechnicalChallengeRomanNumeralsConverterService;

namespace TechnicalChallengeRomanNumeralsConverterUnitTests;

[TestClass]
public class ConvertRomanNumerialsTest
{
    ConverterService converterService;

    [TestInitialize]
    public void StartUp()
    {
        converterService = new ConverterService();
    }

    [TestMethod]
    public void ConvertNumber1ToRomanNumerial()
    {
        // Arrange 
        int numberToConvert = 1;
        string expectedOutput = "I";

        // Act 
        string result = converterService.ConvertNumberToRomanNumerial(numberToConvert);

        // Assert
        Assert.AreEqual(expectedOutput, result);
    }

    [TestMethod]
    public void ConvertNumber4ToRomanNumerial()
    {
        // Arrange 
        int numberToConvert = 4;
        string expectedOutput = "IV";

        // Act 
        string result = converterService.ConvertNumberToRomanNumerial(numberToConvert);

        // Assert
        Assert.AreEqual(expectedOutput, result);
    }

    [TestMethod]
    public void ConvertNumber5ToRomanNumerial()
    {
        // Arrange 
        int numberToConvert = 5;
        string expectedOutput = "V";

        // Act 
        string result = converterService.ConvertNumberToRomanNumerial(numberToConvert);

        // Assert
        Assert.AreEqual(expectedOutput, result);
    }

    [TestMethod]
    public void ConvertNumber8ToRomanNumerial()
    {
        // Arrange 
        int numberToConvert = 8;
        string expectedOutput = "VIII";

        // Act 
        string result = converterService.ConvertNumberToRomanNumerial(numberToConvert);

        // Assert
        Assert.AreEqual(expectedOutput, result);
    }

    [TestMethod]
    public void ConvertNumber9ToRomanNumerial()
    {
        // Arrange 
        int numberToConvert = 9;
        string expectedOutput = "IX";

        // Act 
        string result = converterService.ConvertNumberToRomanNumerial(numberToConvert);

        // Assert
        Assert.AreEqual(expectedOutput, result);
    }

    [TestMethod]
    public void ConvertNumber10ToRomanNumerial()
    {
        // Arrange 
        int numberToConvert = 10;
        string expectedOutput = "X";

        // Act 
        string result = converterService.ConvertNumberToRomanNumerial(numberToConvert);

        // Assert
        Assert.AreEqual(expectedOutput, result);
    }

    [TestMethod]
    public void ConvertNumber47ToRomanNumerial()
    {
        // Arrange 
        int numberToConvert = 47;
        string expectedOutput = "XLVII";

        // Act 
        string result = converterService.ConvertNumberToRomanNumerial(numberToConvert);

        // Assert
        Assert.AreEqual(expectedOutput, result);
    }

    [TestMethod]
    public void ConvertNumber89ToRomanNumerial()
    {
        // Arrange 
        int numberToConvert = 89;
        string expectedOutput = "LXXXIX";

        // Act 
        string result = converterService.ConvertNumberToRomanNumerial(numberToConvert);

        // Assert
        Assert.AreEqual(expectedOutput, result);
    }

    [TestMethod]
    public void ConvertNumber93ToRomanNumerial()
    {
        // Arrange 
        int numberToConvert = 93;
        string expectedOutput = "XCIII";

        // Act 
        string result = converterService.ConvertNumberToRomanNumerial(numberToConvert);

        // Assert
        Assert.AreEqual(expectedOutput, result);
    }

    [TestMethod]
    public void ConvertNumber100ToRomanNumerial()
    {
        // Arrange 
        int numberToConvert = 100;
        string expectedOutput = "C";

        // Act 
        string result = converterService.ConvertNumberToRomanNumerial(numberToConvert);

        // Assert
        Assert.AreEqual(expectedOutput, result);
    }
}