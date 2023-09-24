namespace FileHandlingDemo
{
    public class Example
    {
        public static void Main(string[] args)
        {
            FileStream f1 = new FileStream("C:\\Users\\varda\\Desktop\\C-_practice\\CreateTextFile\\CreateTextFile.csproj\\text.txt", FileMode.OpenOrCreate);
            StreamWriter s1 = new StreamWriter(f1);
            for(int i =0; i < 10; i++)
            {
                s1.WriteLine(i);
            }
            s1.Close();
            f1.Close();
           
        }
    }
}