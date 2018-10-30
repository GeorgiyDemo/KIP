using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DatabaseApp
{
    public class StoreArrayClass
    {
        public static void AddValues(string FirstNameString, string SecondNameString, string ThirdNameString, string EmailString, string PhoneString, string AgeString, string RegionString, string CollegeString, string CollegeProfession, string CollegeCourse)
        {
            DatabaseLogicClass.SQLiteExecute("INSERT INTO users(Firstname, Secondname, Thirdname, Email, Phone, Age, Region, College, CollegeProfession, Course) VALUES ('" + FirstNameString + "','" + SecondNameString + "','" + ThirdNameString + "','" + EmailString + "','" + PhoneString + "','" + AgeString + "','" + RegionString + "','" + CollegeString + "','" + CollegeProfession + "','" + CollegeCourse + "');");
        }

        public static DataTable DataGridInput()
        {
            string[,] array = GetValues();
            string[] FormatArray = { "Фимилия", "Имя", "Отчество", "E-mail", "Мобильный телефон", "Возраст", "Субъект РФ", "Учереждение", "Специальность", "Курс" };
            var rows = array.GetLength(0);
            var columns = array.GetLength(1);

            var t = new DataTable();
            for (var c = 0; c < columns; c++)
                t.Columns.Add(new DataColumn(FormatArray[c]));

            for (var r = 0; r < rows; r++)
            {
                var newRow = t.NewRow();
                for (var c = 0; c < columns; c++)
                    newRow[c] = array[r, c];
                t.Rows.Add(newRow);
            }

            return t;
        }

        public static string[,] GetValues()
        {
            string[,] array = new string[10, 10];
            string[] FieldsArr = { "Firstname", "Secondname", "Thirdname", "Email", "Phone", "Age", "Region", "College", "CollegeProfession", "Course" };
            for (int i = 0; i < 3; i++)
            {
                for (int s = 0; s < FieldsArr.Length; s++)
                {
                    string bufstr = DatabaseLogicClass.SQLiteGet("SELECT "+ FieldsArr[s] + " from users WHERE id=" + (i + 1).ToString());
                    if (bufstr == "")
                        break;
                    array[i, s] = bufstr;
                }
            }
            
            return array;
        }
          
        /*
        array[globalarrayindex, 0] = FirstNameString;
        array[globalarrayindex, 1] = SecondNameString;
        array[globalarrayindex, 2] = ThirdNameString;
        array[globalarrayindex, 3] = EmailString;
        array[globalarrayindex, 4] = PhoneString;
        array[globalarrayindex, 5] = AgeString;
        array[globalarrayindex, 6] = RegionString;
        array[globalarrayindex, 7] = CollegeString;
        array[globalarrayindex, 8] = CollegeProfession;
        array[globalarrayindex, 9] = CollegeCourse;

         */

}
}
