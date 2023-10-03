string MyString = "Hello, World!";
char[] MyChar = { 'r', 'o', 'W', 'l', 'd', '!', ' ' };
string NewString = MyString.TrimStart(MyChar);
Console.WriteLine(NewString);