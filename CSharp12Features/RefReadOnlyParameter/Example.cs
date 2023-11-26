namespace RefReadOnlyParameter
{
    public class Example
    {
        public void MethodWtithoutRefReadOnlyParameter(ref int age)
        {
            Console.WriteLine($"Age: {age}");
            age = 50;
        }

        public void MethodWithRefReadOnlyParameter(ref readonly int age)
        {
            //age = 50; //Error CS8331 Cannot assign to variable 'in int' because it is a readonly variable
            Console.WriteLine($"Age: {age}");
        }
    }
}
