

public class Student
{
    public string Name { get; }
    public DateTime BirthDate { get; }

    public class MyClass
    {
        public Class Class { get; }
        public Grade Grade { get; set; }
    } 

    public List<MyClass> Classes { get; } 

    public float Gpa
    {
        get
        {
            float total = 0;
            foreach (var klass in Classes)
            {
                int grade = (int)klass.Grade;
                if (grade >= 0)
                {
                    total += grade;
                }
            }
            return total / Classes.Count;
        }
    }
}



