using NUnit.Framework;

public class FindConsecutiveTests
{
    [TestCase(new int[] { 1, 2, 3, 3, 3, 5, 6 }, 3, "2 4")]  // 0-индексация
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, null)]
    [TestCase(new int[] { 1, 1, 1, 1, 1 }, 5, "0 4")]  // 0-индексация
    [TestCase(new int[] { 5, 5, 5, 5, 5 }, 5, "0 4")]  // 0-индексация
    [TestCase(new int[] { 1, 2, 3, 4 }, 3, null)]  // Нет одинаковых соседних чисел
    public void TestFindConsecutiveNumbers(int[] sequence, int n, string expectedResult)
    {
        var result = FindConsecutive.FindConsecutiveNumbers(sequence, n);

        // Преобразуем результат в строку: если null, то результат тоже null
        var resultString = result == null ? null : $"{result.Item1} {result.Item2}";   
    }
}
