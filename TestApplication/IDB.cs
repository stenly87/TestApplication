namespace TestApplication
{
    public interface IDB<T>
    {
        void Update(TestMe testMe);

        int Count();
        void Insert(T value);
    }
}