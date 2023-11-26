namespace PrimaryConstructor
{
    internal class Person(string name, int age)
    {
        // Constructor body is empty as properties are initialized directly in the parameter list
        public string Name { get; } = name;
        public int Age { get; } = age;
    }    
}
