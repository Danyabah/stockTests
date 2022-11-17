using stockhouse;
using Action =  ClassActions.Action;

namespace UnitTest
{
    public class Unit
    {
        [Fact]
        public void AddButton()
        {
            Action SCL = new();
            var result = SCL.Get();
            Tovar mytest = new()
            {
                Name = "Гвоздь",
                Size = 11,
                Material = material.Медь,
                count = 12,
                minCount = 2,
                price = 10
            };
            SCL.Add(mytest);
            Assert.Equal(mytest, result[0]);
        }

        [Fact]
        public void ChangeButton()
        {
            Action SCL = new();
            var result = SCL.Get();
            Tovar mytest = new()
            {
                Name = "Молоток",
                Size = 14,
                Material = material.Железо,
                count = 1,
                minCount = 2,
                price = 100
            };
            SCL.Add(mytest);
            Tovar mytest2 = new()
            {
                Name = "Молоток",
                Size = 14,
                Material = material.Железо,
                count = 2,
                minCount = 2,
                price = 110
            };
            SCL.Change(mytest, mytest2);
            Assert.Equal(mytest2, result[0]);
        }

        [Fact]
        public void DeleteButton()
        {
            Action SCL = new();
            var result = SCL.Get();
            Tovar mytest = new()
            {
                Name = "Рама",
                Size = 20,
                Material = material.Сталь,
                count = 13,
                minCount = 2,
                price = 90
            };
            SCL.Add(mytest);
            SCL.Remove(mytest);
            Assert.Empty(result);
        }
    }
}
    
