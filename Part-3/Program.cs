using System;
using System.Collections.Generic;
using System.Text;
namespace Program
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            /********Part-3***********/
            /* var number =new int[3];
             number[0]=1;
            Console.WriteLine(number[0]);*/

            /********Part-4***********/
            // var method=ShippingMethod.Express;
            // Console.WriteLine((int)method);

            // var methodId=3;
            // Console.WriteLine((ShippingMethod)methodId);

            // Console.WriteLine(method.ToString());

            // //parsing
            // var methodName="Express";
            // var shippingMethod=(ShippingMethod)Enum.Parse(typeof(ShippingMethod),methodName);

            /********Part-5: Value Types and Reference Types***********/
            // var a = 10;
            // var b = a;
            // b++;
            // Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            // var arr1 = new int[3] { 1, 2, 3 };
            // var arr2 = arr1;
            // arr2[0] = 0;
            // Console.WriteLine(string.Format("arr1: {0}, arr2: {1}", arr1[0], arr2[0]));

            // var number = 1;
            // Increment(number);
            // Console.WriteLine(number);

            // var p=new Person(){Age=20};
            // MakeOld(p);
            // Console.WriteLine(p.Age);

            /********Part-6: Foreach loops***********/
            // var name="john Smith";
            // for(var i=0;i<name.Length;i++)
            // {
            //     Console.WriteLine(name[i]);
            // }

            // foreach (var letter in name)
            // {
            //     Console.WriteLine(letter);
            // }

            /********Part-7:Random ***********/
            // var random = new Random();
            // for (var i = 0; i < 10; i++)
            // {
            //     Console.Write((char)random.Next(97, 122));
            // }

            /********Part-8:Arrays and List ***********/
            // var numbers = new int[] { 2, 4, 11, 6, 7, 8, 10 };
            // //Length
            // Console.WriteLine("Length: " + numbers.Length);
            // //IndexOf
            // var index = Array.IndexOf(numbers, 7);
            // Console.WriteLine("Index of 7" + index);
            // //Clear
            // Array.Clear(numbers, 0, 2);
            // foreach (var i in numbers)
            // {
            //     Console.Write(i + " ");
            // }
            // Console.WriteLine("");

            // //Copy
            // var another = new int[] { 11, 12, 13, 14 };
            // Array.Copy(numbers, another, 3);
            // foreach (var i in another)
            // {
            //     Console.Write(i + " ");
            // }

            // Console.WriteLine("");

            // //Sort
            // Array.Sort(numbers);
            // foreach (var i in numbers)
            // {
            //     Console.Write(i + " ");
            // }
            // Console.WriteLine("");

            // //Reverse
            // Array.Reverse(numbers);
            // foreach (var i in numbers)
            // {
            //     Console.Write(i + " ");
            // }

            // var numbers=new List<int>(){1,2,3,4,5};
            // numbers.Add(1);
            // numbers.AddRange(new int[3]{5,6,7});

            // foreach(var i in numbers)
            // {
            //     Console.WriteLine(i);
            // }
            // Console.WriteLine(numbers.IndexOf(1));
            // Console.WriteLine(numbers.LastIndexOf(1));

            /********Part-9: Date Time***********/
            // var dateTime=new DateTime(2015,1,1);
            // var now=DateTime.Now;
            // var today=DateTime.Today;

            // Console.WriteLine("Hour: "+now.Hour);
            // Console.WriteLine("Minute: "+now.Minute);

            // var tomorow=now.AddDays(1);
            // var yesterday=now.AddDays(-1);
            // Console.WriteLine(now.ToLongDateString());
            // Console.WriteLine(now.ToShortDateString());
            // Console.WriteLine(now.ToLongTimeString());
            // Console.WriteLine(now.ToShortTimeString());
            // Console.WriteLine(now.ToString());

            // var timespan=new TimeSpan(1,2,3);
            // var timespan1=new TimeSpan(1,0,0);
            // var timespan2=TimeSpan.FromHours(1);

            // var start=DateTime.Now;
            // var end=DateTime.Now.AddMinutes(2);
            // var duration=end-start;
            // Console.WriteLine("Duration: "+duration);

            // //Properties
            // Console.WriteLine("Minutes: "+timespan.Minutes);
            // Console.WriteLine("Toatl Minutes: "+timespan.TotalMinutes);

            // // Add
            // Console.WriteLine("Add Example: "+timespan.Add(TimeSpan.FromMinutes(8)));
            // Console.WriteLine("Subtract Example: "+timespan.Subtract(TimeSpan.FromMinutes(8)));

            // //ToString
            // Console.WriteLine("ToString: "+timespan.ToString());
            // //Parse
            // Console.WriteLine("Parse: "+TimeSpan.Parse("01:02:03"));

            /********Part-10: Strings***********/
            // var name = "Rohan S Kamath ";
            // Console.WriteLine("Trim: '{0}'", name.Trim());
            // Console.WriteLine("Upper Case: '{0}'", name.ToUpper());
            // Console.WriteLine("Lower Case: '{0}'", name.ToLower());

            // var index = name.IndexOf(' ');
            // var firstName = name.Substring(0, index);
            // var lastName = name.Substring(index + 1);
            // Console.WriteLine(firstName);
            // Console.WriteLine(lastName);

            // var nameArray = name.Split(' ');
            // Console.WriteLine("FName: {0}, MName: {1}, LName: {2}", nameArray[0], nameArray[1], nameArray[2]);

            // var change = name.Replace("Rohan", "ROHAN");
            // Console.WriteLine(change);

            //Summarize a give text or paragraph
            // var text = "This is really long long text his is really long long text his is really long long text his is really long long text his is really long long text";
            // Console.WriteLine(SummarizeText(text));

            //String Builder
            // var builder=new StringBuilder();
            // builder.Append('-',10);
            // builder.AppendLine();
            // builder.Append("Header");
            // builder.AppendLine();
            // builder.Append('-',10);
            // builder.Replace('-','+');
            // builder.Remove(0,10);
            // builder.Insert(0,new string('-',10));
            // Console.WriteLine(builder);

            /********Part-10: Files & Directory***********/
            var path = @"C:\Sample Data\test-file.txt";
            // var pathOther = @"C:\Sample Data\Copied-File.txt";
            // File.Copy(@"C:\Sample Data\test-file.txt", @"C:\Sample Data\Copied-File.txt", true);
            // File.Delete(path);

            // if (File.Exists(path))
            // {

            // }
            // var content = File.ReadAllText(pathOther);
            // Console.WriteLine(content);

            // var fileInfo = new FileInfo(pathOther);
            // fileInfo.CopyTo("...");
            // fileInfo.Delete();
            // if (fileInfo.Exists) { }

            // Directory.CreateDirectory(@"C:\Sample Data");
            // var files = Directory.GetFiles(@"C:\Sample Data", "*.*", SearchOption.AllDirectories);
            // foreach (var file in files)
            // {
            //     Console.WriteLine(file);
            // }

            // var directories=Directory.GetDirectories(@"C:\Sample Data","*.*",SearchOption.AllDirectories);
            // foreach(var directory in directories)
            // {
            //     Console.WriteLine(directory);
            // }
            // Directory.Exists("...");

            //Path Class
            Console.WriteLine("Extension: "+Path.GetExtension(path));
            Console.WriteLine("Extension: "+Path.GetFileName(path));
            Console.WriteLine("Extension: "+Path.GetDirectoryName(path));

            
        }
        static string SummarizeText(string text)
        {
            const int maxLength = 20;
            if (text.Length < maxLength)
            {
                return text;
            }
            else
            {
                var words = text.Split(' ');
                var totalChar = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalChar = totalChar + word.Length + 1;
                    if (totalChar > maxLength)
                    {
                        break;
                    }
                }
                var summary = String.Join(" ", summaryWords) + "...";
                return summary;
            }
        }
        public static void Increment(int number)
        {
            number = number + 10;
        }

        public static void MakeOld(Person p)
        {
            p.Age = p.Age + 10;
        }
    }
}