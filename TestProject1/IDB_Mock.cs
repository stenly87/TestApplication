using TestApplication;

namespace TestProject1
{
    internal class IDB_Mock<T> : IDB<T>
    {
        List<T> values = new List<T>();

        public int Count()
        {
            return values.Count;
        }

        public void Insert(T value)
        {
            values.Add(value);
        }

        public void Update(TestMe testMe)
        {
            
        }


    }
}