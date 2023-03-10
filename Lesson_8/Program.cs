using Lesson;
using AssistantClass;
internal class Program
{
    private static void Main(string[] args)
    {
        LessonAll lesson = new LessonAll();
        lesson.EnterTaskNumber();
        Assistant ass = new Assistant();
        /*var mas = ass.CreateDoubleArray();
        ass.FillDoubleArray(ref mas);
        ass.PrintArray(mas);
        ass.quikSortArray(ref mas, 0, mas.Length - 1);
        ass.PrintArray(mas);*/
    }
}
