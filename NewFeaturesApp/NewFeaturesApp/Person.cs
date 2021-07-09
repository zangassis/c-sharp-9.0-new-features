using System;

namespace NewFeaturesApp
{
    // With 'init' it will give error if we will try to set property value
    // anywhere else except constructor or initializer
    public class Person
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string LastName { get; init; }
    }
}
