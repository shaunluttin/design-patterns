class Course
{
    public LinkedList<Student> Students;
}

// The way we represent a collection of students might change.

class Course 
{
    private LinkedList<Student> _students;
    public bool Register(Student s) 
    {
        _students.Add(s);
    }
}

