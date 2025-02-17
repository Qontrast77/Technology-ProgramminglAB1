using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nikitalab1; // Путь к основному проекту

namespace Nikitalab1.Tests
{
    // Атрибут для тестового класса
 
    public class WordCheckerTests
    {
        // Тест с несколькими вариантами слов
        // Атрибут для метода теста
        [DataRow("программирование", "система", new[] { "да", "да", "нет", "нет", "да", "да", "нет", "да", "да", "да", "нет", "да" })]
        [DataRow("hello", "world", new[] { "да", "нет", "да", "нет", "да" })]
        [DataRow("abc", "xyz", new[] { "нет", "нет", "нет" })]
        [DataRow("cat", "act", new[] { "да", "да", "да" })]
        [DataRow("a", "a", new[] { "да" })]
        [DataRow("abc", "def", new[] { "нет", "нет", "нет" })]
     
        public void CheckLettersInWord_ShouldReturnCorrectResult(string word1, string word2, string[] expected)
        {
            // Act
            var result = WordChecker.CheckLettersInWord(word1, word2);

            // Assert
            Assert.AreEqual(expected.Length, result.Count); // Проверяем, что количество элементов совпадает.

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]); // Сравниваем каждый элемент
            }
        }

        // Тест с пустыми строками
        // Атрибут для метода теста
      
        public void CheckLettersInWord_EmptyStrings_ShouldReturnEmptyList()
        {
            // Act
            var result = WordChecker.CheckLettersInWord("", "");

            // Assert
            Assert.AreEqual(0, result.Count);
        }

        // Тест с пустыми строками, где одно из слов пустое
        // Атрибут для метода теста
    
        public void CheckLettersInWord_OneEmptyString_ShouldReturnEmptyList()
        {
            // Act
            var result = WordChecker.CheckLettersInWord("hello", "");

            // Assert
            Assert.AreEqual(0, result.Count);

            result = WordChecker.CheckLettersInWord("", "world");

            Assert.AreEqual(0, result.Count);
        }

        // Тест с одинаковыми словами
        // Атрибут для метода теста
    
        public void CheckLettersInWord_SameWords_ShouldReturnAllYes()
        {
            // Act
            var result = WordChecker.CheckLettersInWord("hello", "hello");

            // Assert
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual("да", result[i]);
            }
        }

        // Тест с разными буквами
        // Атрибут для метода теста
    
        public void CheckLettersInWord_NoCommonLetters_ShouldReturnAllNo()
        {
            // Act
            var result = WordChecker.CheckLettersInWord("abc", "xyz");

            // Assert
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual("нет", result[i]);
            }
        }
    }
}
