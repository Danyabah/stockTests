using System;
namespace ClassActions
{
    public class Action<T> where T : class
    {
        public List<T> Tovars = new List<T>();
        public List<T> Get() => Tovars;

        public void Add(T item) => Tovars.Add(item);

        public void Remove(T item) => Tovars.Remove(item);

        public void Change(int index, T item) => Tovars[index] = item;
    }
}