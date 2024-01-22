char CheckGrade(int grade)
{
    if (grade >= 90) return 'A';
    else if (grade >= 80 && grade < 90) return 'B';
    else if (grade >= 70 && grade < 80) return 'C';
    else if (grade >= 60 && grade < 70) return 'D';
    else return 'F';
}
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CheckGrade(a));