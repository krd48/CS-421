

public class Student
{
    public string Name { get; }
    public DateTime BirthDate { get; }

    public class MyCourse
    {
        public Course Course { get; }
        public Grade Grade { get; set; }
    } 

    public List<MyCourse> Courses { get; } 

    public float Gpa
    {
        get
        {

        }
    }
}



