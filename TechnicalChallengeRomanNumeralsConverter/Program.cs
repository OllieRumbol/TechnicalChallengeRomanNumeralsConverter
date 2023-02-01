using TechnicalChallengeRomanNumeralsConverterService;

int numberToConvert = 17;
ConverterService convertService = new ConverterService();
string result = convertService.ConvertNumberToRomanNumerial(numberToConvert);

Console.WriteLine(numberToConvert);
Console.WriteLine(result);