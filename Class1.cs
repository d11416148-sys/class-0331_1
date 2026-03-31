using System;
using System.Security.Cryptography.X509Certificates;

public struct Student
{
    private int ID;
    private string Name;
    private Test Score;

    public static int count;

    public Student(int id, string n, int m, int f)
    {
        ID = id;
        Name = n;
        Score = new Test(m, f);

        count++;
    }

    public string GetStudent()
    {
        string str;
        str = " 學生編號: " + ID.ToString();
        str += "\n 學生姓名: " + Name;
        str += "\n 期中考成績: " + Score.GetMid().ToString();
        str += "\n 期末考成績: " + Score.GetFinal().ToString();
        str += "\n 平均成績: " + Score.GetAvg().ToString();
        return str;
    }
}