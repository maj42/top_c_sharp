namespace homework_11_04._09
{
    internal class Student : ICloneable
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Student(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return $"I'm student {Name}, my ID {Id}";
        }
    }
}
