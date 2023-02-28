using Lesson;
internal class Program
{
    private static void Main(string[] args)
    {
        LessonFive lesson = new LessonFive();
        lesson.EnterTaskNumber();
        int a = 13;
        string str = Convert.ToString(a, 2);
        //text.Split(' ').Where(i => int.TryParse(i, out _)).Select(int.Parse).ToArray();
    }
}