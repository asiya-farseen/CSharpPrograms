using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class throw2
    {
public static void demo10()
		{
			
			Student std = null;

		try
		{
			PrintStudentName(std);
    }
		catch(Exception ex)
		{
			Console.WriteLine(ex.Message );
		}

Console.ReadKey();
	}
	
	public static void PrintStudentName(Student std)
{
			
    if (std == null)
        throw new NullReferenceException("Student object is null. ");

    Console.WriteLine(std.StudentName);
}
}

public class Student
{

    public string StudentName { get; set; }
}
    }
