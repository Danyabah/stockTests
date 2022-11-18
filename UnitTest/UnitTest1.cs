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
            Tovar mytest = new()
            {
                Name = "Ãâîçäü",
                Size = 11,
                Material = material.Ìåäü,
                count = 12,
                minCount = 2,
                price = 10
            };
            SCL.Add(mytest);
            var result = SCL.Get();
            Assert.Equal(mytest, result[0]);
        }

        [Fact]
        public void ChangeButton()
        {
            Action SCL = new();
            Tovar mytest = new()
            {
                Name = "Ìîëîòîê",
                Size = 14,
                Material = material.Æåëåçî,
                count = 1,
                minCount = 2,
                price = 100
            };
            SCL.Add(mytest);
            Tovar mytest2 = new()
            {
                Name = "Ìîëîòîê",
                Size = 14,
                Material = material.Æåëåçî,
                count = 2,
                minCount = 2,
                price = 110
            };
            SCL.Change(mytest, mytest2);
             var result = SCL.Get();
            Assert.Equal(mytest2, result[0]);
        }

        [Fact]
        public void DeleteButton()
        {
            Action SCL = new();
            Tovar mytest = new()
            {
                Name = "Ðàìà",
                Size = 20,
                Material = material.Ñòàëü,
                count = 13,
                minCount = 2,
                price = 90
            };
            SCL.Add(mytest);
            SCL.Remove(mytest);
            var result = SCL.Get();
            Assert.Empty(result);
        }
    }
}
    
