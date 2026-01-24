using System;

namespace Week7.People
{
    public class DiligentAlumno :Alumno
    {
        //(Week 4) Exercise 2: Create the very diligent student that inherits from Student and reimplements the answer question method
        public DiligentAlumno(string name, int id, int fileNumber, double average) : base(name, id, fileNumber, average) { }

        public override int AnswerQuestion(int question)
        {
            return question % 3;
        }
    }
}
