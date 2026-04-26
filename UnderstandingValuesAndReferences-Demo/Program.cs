//Example 1: Value Type

//using UnderstandingValuesAndReferences_Demo;

//Console.WriteLine("============Example 1 value Type ==============");
//int x = 5;
//int y = x;

//y = 10;

//Console.WriteLine(x);
//Console.WriteLine(y);


//Example 2 : 
//Console.WriteLine("============Example 2 reference Type ==============");

//Student s1 = new Student();
//s1.Name = "Alex";

//Student s2 = s1;

//s2.Name = "Amina";

//Console.WriteLine(s1.Name);

//Console.WriteLine("============Example 3 Reference Type==============");
//Example 3:

//Student myS1 = new Student();
//Student myS2 = myS1;

//myS2.Name = "Lusukama";

//Console.WriteLine(myS1.Name);





//Example 1: Value Type

//using UnderstandingValuesAndReferences_Demo;

//Console.WriteLine("============Example 1 value Type ==============");
//int x = 5;
//int y = x;

//y = 10;

//Console.WriteLine(x);
//Console.WriteLine(y);


//Example 2 : 
//Console.WriteLine("============Example 2 reference Type ==============");

//Student s1 = new Student();
//s1.Name = "Alex";

//Student s2 = s1;

//s2.Name = "Amina";

//Console.WriteLine(s1.Name);

//Console.WriteLine("============Example 3 Reference Type==============");
//Example 3:

//Student myS1 = new Student();
//Student myS2 = myS1;

//myS2.Name = "Lusukama";

//Console.WriteLine(myS1.Name);




//using System;

//namespace UnderstandingValuesAndReferences_Demo
//{
//    class StudentList
//    {
//        public string Name;
//        public int? ExamMark;   // Nullable value type

//        public void DisplayStudent()
//        {
//            Console.WriteLine($"Student Name: {Name}");

//            // Using null-coalescing operator
//            Console.WriteLine($"Exam Mark: {ExamMark ?? 0}");

//            // Using conditional logic
//            if (ExamMark is null)
//            {
//                Console.WriteLine("Exam not written yet");
//            }
//            else
//            {
//                Console.WriteLine("Exam completed");
//            }
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Reference type example
//            StudentList student = null;

//            // Safe null check
//            if (student is null)
//            {
//                Console.WriteLine("Student object not created yet");
//            }

//            // Assign object if null
//            student ??= new StudentList();

//            // Assign student details
//            student.Name = "Lusukama";

//            Console.Write("Enter exam mark (press ENTER to skip): ");
//            string input = Console.ReadLine();

//            // Nullable value type handling
//            if (string.IsNullOrWhiteSpace(input))
//            {
//                student.ExamMark = null;
//            }
//            else
//            {
//                student.ExamMark = Convert.ToInt32(input);
//            }

//            Console.WriteLine();

//            // Null-conditional operator example
//            Console.WriteLine($"Student Name Length: {student?.Name.Length}");

//            Console.WriteLine();

//            student.DisplayStudent();
//        }
//    }
//}

//Example 4: Pass by Value, Pass by Ref, Pass by Out

//using System;

//namespace RefAndOutDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== PASS BY VALUE EXAMPLE ===");

//            int marks = 50;

//            Console.WriteLine($"Before method call: {marks}");

//            UpdateMarks(marks);

//            Console.WriteLine($"After method call: {marks}");
//            Console.WriteLine();


//            Console.WriteLine("=== PASS BY REF EXAMPLE ===");

//            int studentScore = 40;

//            Console.WriteLine($"Before bonus added: {studentScore}");

//            AddBonusMarks(ref studentScore);

//            Console.WriteLine($"After bonus added: {studentScore}");
//            Console.WriteLine();


//            Console.WriteLine("=== PASS BY OUT EXAMPLE ===");

//            int total;
//            string result;

//            CalculateResult(75, 65, out total, out result);

//            Console.WriteLine($"Total Marks: {total}");
//            Console.WriteLine($"Result Status: {result}");
//        }


//        // PASS BY VALUE
//        static void UpdateMarks(int score)
//        {
//            score = 80;
//        }


//        // PASS BY REF
//        static void AddBonusMarks(ref int score)
//        {
//            score += 10;
//        }


//        // PASS BY OUT
//        static void CalculateResult(int mark1, int mark2, out int totalMarks, out string status)
//        {
//            totalMarks = mark1 + mark2;

//            if (totalMarks >= 100)
//                status = "Pass";
//            else
//                status = "Fail";
//        }
//    }
//}



//Working demo for the Stack vs Heap / Value vs Reference Types
//using System;

//namespace MemoryDemo
//{
//    class Student
//    {
//        public string Name;
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== VALUE TYPE DEMO ===");

//            int a = 10;
//            int b = a;

//            Console.WriteLine($"Before change: a = {a}, b = {b}");

//            b = 20;

//            Console.WriteLine($"After change:  a = {a}, b = {b}");
//            Console.WriteLine("Explanation: a did not change because int is a value type.\n");


//            Console.WriteLine("=== REFERENCE TYPE DEMO ===");

//            Student s1 = new Student();
//            s1.Name = "Lusukama";

//            Student s2 = s1;

//            Console.WriteLine($"Before change: s1.Name = {s1.Name}, s2.Name = {s2.Name}");

//            s2.Name = "Selemani";

//            Console.WriteLine($"After change:  s1.Name = {s1.Name}, s2.Name = {s2.Name}");
//            Console.WriteLine("Explanation: both s1 and s2 point to the same object in heap memory.\n");


//            Console.WriteLine("=== NULL AND GARBAGE COLLECTION CONCEPT ===");

//            s1 = null;
//            s2 = null;

//            Console.WriteLine("Both references are now null.");
//            Console.WriteLine("The Student object is no longer referenced and can be cleaned by the Garbage Collector.");
//        }
//    }
//}


//Example Simple Working Example Boxing
//using System;

//namespace BoxingDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            int marks = 75;

//            object boxedMarks = marks;   // Boxing

//            Console.WriteLine("Original value: " + marks);
//            Console.WriteLine("Boxed value: " + boxedMarks);
//        }
//    }
//}



//Working Example: Boxing + Unboxing
//using System;
//using System.Collections;

//namespace BoxingUnboxingDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            int marks = 85;

//            // Boxing
//            object boxedMarks = marks;

//            Console.WriteLine("Boxed value: " + boxedMarks);

//            // Unboxing
//            int unboxedMarks = (int)boxedMarks;

//            Console.WriteLine("Unboxed value: " + unboxedMarks);
//        }
//    }
//}

//Example 2: Boxing and Unboxing with Nullable Types
//using System;
//using System.Collections;

//namespace BoxingUnboxingDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            ArrayList marksList = new ArrayList();

//            int marks = 90;

//            // Boxing
//            marksList.Add(marks);

//            Console.WriteLine("Value stored in ArrayList (boxed): " + marksList[0]);

//            // Unboxing
//            int retrievedMarks = (int)marksList[0];

//            Console.WriteLine("Retrieved value after unboxing: " + retrievedMarks);
//        }
//    }
//}



//Example-1 Basic Enum Example
//using System;

//namespace EnumDemo
//{
//    enum TransactionType
//    {
//        Deposit,
//        Withdrawal,
//        BalanceCheck
//    }

//    class Program
//    {
//        static void Main()
//        {
//            TransactionType transaction = TransactionType.Withdrawal;

//            Console.WriteLine("Selected transaction: " + transaction);

//            if (transaction == TransactionType.Withdrawal)
//            {
//                Console.WriteLine("Processing withdrawal...");
//            }
//        }
//    }
//}

//Example 2: Class + Method + Enum Together
using System;

enum AccountStatus
{
    Active,
    Suspended,
    Closed
}

class BankAccount
{
    public string AccountHolder;
    public AccountStatus Status;

    public void DisplayStatus()
    {
        Console.WriteLine($"Account status: {Status}");
    }
}

class Program
{
    static void CheckAccount(AccountStatus status)
    {
        Console.WriteLine($"Checking account: {status}");
    }

    static void Main()
    {
        BankAccount acc = new BankAccount();

        acc.AccountHolder = "Lusukama";
        acc.Status = AccountStatus.Active;

        acc.DisplayStatus();

        CheckAccount(AccountStatus.Active);
    }
}