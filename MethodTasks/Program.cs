//void ShowText()
//{
//    Console.WriteLine("Hello");
//}

//ShowText();

//void Sum()
//{
//    int a = 5;
//    int b = 10;
//    int sum = a + b;
//    Console.WriteLine(sum);
//}

//Sum();

//int SumOfNumbers()
//{
//    int a = 5;
//    int b = 10;
//    int sum = a + b;
//    return sum;
//}
//int result = SumOfNumbers();

// Console.WriteLine(result);

//string SumOfNumbers()
//{
//    int a = 5;
//    int b = 10;
//    int sum = a + b;
//    return "Salam";
//}
//var result = SumOfNumbers();
//Console.WriteLine(result);

//using static System.Net.Mime.MediaTypeNames;

//void SumOfEvenNumbers()
//{
//    int[] nums = { 1, 2, 3, 4, 5, 6 };
//    int sum = 0;
//    foreach (var item in nums)
//    {
//        if (item%2==0)
//        {
//            sum += item;
//        }
//    }
//    Console.WriteLine(sum);
//}

//SumOfEvenNumbers();


//void ShowText(string text)
//{
//    Console.WriteLine(text);
//}
//ShowText("Hello");

//bool isMarried = false;

//if (isMarried)
//{
//    string text = "Evli";
//    ShowText(text);
//}
//else
//{
//    string text = "Subay";
//    ShowText(text);
//}

//int SumOfNumbers(int num1,int num2)
//{
//    int sum = num1 + num2;
//    return sum;
//}
//int result = SumOfNumbers(5, 6);
//Console.WriteLine(result);

//void SumOfNumbers2(int num1,int num2)
//{
//    int sum = num1 + num2;
//    Console.WriteLine(sum);
//}
//SumOfNumbers2(5,6);

//void SumOfEvenNumbers(int[] elems,int num1)
//{
//    int sum = 0;
//    foreach (var item in elems)
//    {
//        if (item%2==0)
//        {
//            sum += item;
//        }
//    }
//    int result = sum + num1;

//    Console.WriteLine(result);
//}

//int[] nums = { 1, 2, 3, 4, 5, 6 };

//SumOfEvenNumbers(nums,100);

//string name = Console.ReadLine();

//Console.WriteLine(name);

//Console.WriteLine("Add FIrst Number:");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Add Second Number:");
//int num2 = int.Parse(Console.ReadLine());

//int result = num1 + num2;
//Console.WriteLine("Result:");
//Console.WriteLine(result);

//int[] GetDatas(params int[] nums)
//{
//    return nums;
//}

//var result = GetDatas(1, 2, 3, 4, 5);

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("---------");


//int[] GetDatas2(int num1,params int[] nums)
//{
//    return  nums;
//}

//var result2 = GetDatas2(1, 2, 3, 4, 5);

//foreach (var item in result2)
//{
//    Console.WriteLine(item);
//}

//int sumOfDatas(int num1,int num2, params int[] nums)
//{

//    int sumNumbers = num1 + num2;
//    int sumOfArrayItems = 0;

//    foreach (var item in nums)
//    {
//        sumOfArrayItems += item;
//    }

//    int result = sumNumbers + sumOfArrayItems;

//    return result;
//}

//int result = sumOfDatas(1, 2, 3, 4, 5, 6);

//Console.WriteLine(result);

//string GetName(string name)
//{
//    return name;
//}

//Console.WriteLine(GetName("Hacker"));

//string GetName(string name="XXX")
//{
//    return name;
//}

//Console.WriteLine(GetName());

//string GetName(string name = "XXX")
//{
//    return name;
//}

//Console.WriteLine(GetName(Console.ReadLine()));


//string GetName(string name = "XXX")
//{
//    return name;
//}

//Name: string name = Console.ReadLine();

//if (name=="")
//{
//    Console.WriteLine(GetName());
//    goto Name;
//}
//else
//{
//    Console.WriteLine(GetName(name));
//}

//ClassTask

//Faha's Version

//string Login(string userName,string password)
//{

//    if (userName == "Cavid123" && password=="cavid123_")
//    {
//        return "Login Successfull";
//    }
//    else
//    {
//        return "Username or Password is wrong";
//    }

//}
//Console.WriteLine("Username:");
//string userName = Console.ReadLine();
//Console.WriteLine("Password");
//string password = Console.ReadLine();

//string result= Login(userName, password);

//Console.WriteLine(result);


//Kamran's version

string Login(string userName, string password)
{
    string message;

    if (userName == "Cavid123" && password == "cavid123_")
    {
        message= "Login Successfull";
    }
    else
    {
        message= "Username or Password is wrong";
    }

    return message;
}
Inputs: Console.WriteLine("Username:");
string userName = Console.ReadLine();
Console.WriteLine("Password");
string password = Console.ReadLine();

if(!IsValid(userName,password))
{
    Console.WriteLine("Input cannot be Empty, add Username again");
    goto Inputs;
}

string result = Login(userName, password);

Console.WriteLine(result);

bool IsValid(string userName,string password)
{

    if (userName == "" || password == "")
    {
        return false;
    }
    return true;
}


