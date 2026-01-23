using MetodologíasDeProgramaciónI;
using System;

namespace Week5.People
{
    //(Week 4) Exercise 3: Implement the Adapter Pattern
    // An adapter for alumno(Adaptable) that can behave like Student (Target)
    //NOTE: Student is defined in MDPI.cs. For this reason "Alumno" wasn´t translated to English
    //In class , the exercise was to conect our spanish code to an english library, in this case, the MDPI.cs file so "Student".
    public class AlumnoAdapter : Student
    {
        private IAlumno _alumno;
        public AlumnoAdapter(IAlumno alumno)
        {
            _alumno = alumno;
        }

        //Metodos Student
        public string getName()
        {
            return _alumno.GetName();
        }

        public int yourAnswerIs(int question)
        {
            return _alumno.AnswerQuestion(question);
        }

        public void setScore(int score)
        {
            _alumno.SetCalification(score);
        }

        public string showResult()
        {
            return _alumno.ShowCalification();
        }

        public bool equals(Student student)
        {
            return _alumno.IsEqual(((AlumnoAdapter)student)._alumno);
        }

        public bool lessThan(Student student)
        {
            return _alumno.IsLessThan(((AlumnoAdapter)student)._alumno);
        }

        public bool greaterThan(Student student)
        {
            return _alumno.IsGreaterThan(((AlumnoAdapter)student)._alumno);
        }
    }
}
