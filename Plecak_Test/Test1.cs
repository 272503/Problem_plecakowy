using Problem_plecakowy;

namespace Plecak_Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestAtLeastOneItemSelected_WhenValidItemsExist()
        {
            Problem problem = new Problem(5, 42);  // 5 losowych przedmiotów
            Result result = problem.Solve(10);     // Pojemność plecaka = 10

            Assert.IsTrue(result.UsedItems.Count > 0, "Przynajmniej jeden przedmiot powinien być wybrany.");
        }

        [TestMethod]
        public void TestEmptyResult_WhenCapacityIsZero()
        {
            Problem problem = new Problem(5, 42);
            Result result = problem.Solve(0);  // Pojemność plecaka = 0

            Assert.AreEqual(0, result.UsedItems.Count, "Żaden przedmiot nie powinien być wybrany.");
        }


        [TestMethod]
        public void TestKnownInstance()
        {
            Problem problem = new Problem(3, 1); // 3 przedmioty, seed = 1
            Result result = problem.Solve(10);   // Pojemność plecaka = 10

            // Oczekiwane wartości
            List<int> expectedItems = new List<int> { 1, 3 };
            int expectedValue = 10;
            int expectedWeight = 7;

            Assert.AreEqual(expectedValue, result.TotalValue, "Wartość rozwiązania jest błędna.");
            Assert.AreEqual(expectedWeight, result.TotalWeight, "Łączna waga rozwiązania jest błędna.");
            CollectionAssert.AreEqual(expectedItems, result.UsedItems, "Lista wybranych przedmiotów jest błędna.");
        }

        [TestMethod]
        public void TestNoItems()
        {
            Problem problem = new Problem(0, 1); // Brak przedmiotów
            Result result = problem.Solve(10);   // Pojemność plecaka = 10

            Assert.AreEqual(0, result.TotalValue, "Łączna wartość powinna być 0.");
            Assert.AreEqual(0, result.TotalWeight, "Łączna waga powinna być 0.");
            Assert.AreEqual(0, result.UsedItems.Count, "Lista wybranych przedmiotów powinna być pusta.");
        }

        [TestMethod]
        public void TestSingleItemFitsExactly()
        {
            Problem problem = new Problem(1, 42); // 1 przedmiot
            Result result = problem.Solve(2);     // Pojemność plecaka = 2

            // Zakładamy, że jedyny przedmiot ma wagę 2 (zależnie od seed)
            Assert.IsTrue(result.UsedItems.Count == 1, "Powinien zostać wybrany dokładnie jeden przedmiot.");
            Assert.AreEqual(2, result.TotalWeight, "Łączna waga powinna być równa 2.");
        }


    }
}
