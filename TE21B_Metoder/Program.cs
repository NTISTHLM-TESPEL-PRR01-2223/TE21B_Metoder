
// Console.WriteLine("Hej");
// string name = Console.ReadLine();
// Console.WriteLine(name);

// Console.WriteLine("FÖRE");
// DescribeRoom();
// Console.WriteLine("EFTER");
string a = AskYesNo("Are you a chicken?");
if (a == "n")
{
  string b = AskYesNo("Are you a dinosaur");
  if (b == "y")
  {
    Console.WriteLine("Pip pip!");
  }
}

Console.ReadLine();

static string AskYesNo(string question)
{
  Console.WriteLine(question);
  Console.WriteLine("[y/n]:");
  string answer = Console.ReadLine();

  return answer;
}



static void DescribeRoom()
{
  // Console.WriteLine("Integer et ornare neque, sit amet porta eros. Sed ligula quam, pretium commodo nulla in, porttitor mattis erat. Integer placerat pharetra bibendum. Aliquam erat volutpat. Etiam pulvinar eu dui eu ultricies. Ut pulvinar id nibh vel commodo. Praesent mauris lacus, aliquet et ipsum eget, ornare commodo arcu. Fusce eget dui sit amet augue iaculis sodales at nec est. Praesent congue, nulla ut blandit dignissim, sapien leo cursus leo, sit amet condimentum orci sem ut metus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. In vehicula malesuada nibh, ornare consectetur mauris auctor non. Pellentesque dictum porta varius. Sed felis tellus, finibus nec sodales ut, bibendum quis lacus. Nam ullamcorper lobortis nisl, tincidunt consectetur ligula vestibulum vel.");

  Console.WriteLine("HELLO");
}



