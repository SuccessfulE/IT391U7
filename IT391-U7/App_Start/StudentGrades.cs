using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace IT391_U7.App_Start
{
    public class StudentGrades
    {
        //Declaring Variables required
        private ArrayList stuGrades;
        public int MaxGrade = 0;
        public int MinGrade = 100;
        public int AvgGrade = 0;

        //Setting the class solutions into variables to be used in the aspx.cs file.
        public StudentGrades(string sGradeFile)
        {
            stuGrades = new ArrayList();
            ReadStudentGradesXML(sGradeFile);
            AvgGrade = AverageGrade();
            MaxGrade = GradeMax();
            MinGrade = GradeMin();
        }

        //Reading XML File
        private void ReadStudentGradesXML(string XMLStudentGrades)
        {
            XmlTextReader reader = new XmlTextReader(XMLStudentGrades);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: //Getting the first element of <grade>
                        System.Diagnostics.Debug.Write("<" + reader.Name);
                        System.Diagnostics.Debug.Write(">");
                        break;
                    case XmlNodeType.Text: //Getting the value that's inbetween <grade>EX.</grade>
                        System.Diagnostics.Debug.Write(reader.Value);
                        int val = Convert.ToInt32(reader.Value); //Converting text to int
                        addGrade(val); //Setting values in addGrade
                        break;
                    case XmlNodeType.EndElement: //Getting the last element of </grade>
                        System.Diagnostics.Debug.Write("</" + reader.Name);
                        System.Diagnostics.Debug.WriteLine(">");
                        break;
                }
            }
        }

        //Adding grades to array list
        private void addGrade(int aGrade)
        {
            stuGrades.Add(aGrade);
        }

        //Calculating Average grades
        private int AverageGrade()
        {
            int averageG = 0;
            int AvG = 0;
            foreach (int grade in stuGrades)
            {
                AvG = AvG + grade;
            }
            averageG = AvG / stuGrades.Count;
            return averageG;
        }
        //Calculating Maximum grades
        private int GradeMax()
        {
            stuGrades.Sort();
            int maximumG = (int)stuGrades[stuGrades.Count - 1];
            return maximumG;
        }

        //Calculating Minimum grades
        private int GradeMin()
        {
            stuGrades.Sort();
            int minimumG = (int)stuGrades[0];
            return minimumG;
        }
    }
}