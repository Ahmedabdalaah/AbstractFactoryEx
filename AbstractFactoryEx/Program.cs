// See https://aka.ms/new-console-template for more information
using AbstractFactoryEx;
string userName;
string cardNumber;
string code;
string codeNum;
FactoryBank bankfactory = new FactoryBank();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" please enter username :");
userName = Console.ReadLine();
Console.WriteLine("Please enter card number");
cardNumber = Console.ReadLine();
code = cardNumber.Substring(0, 4);
codeNum = cardNumber.Substring(0, 2);
IBank bank = bankfactory.getBank(code);
IPayment cardP = bankfactory.GetCard(codeNum);
if(bank == null || cardP == null)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Error.WriteLine("Invalid card number");
}
else
{ 
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(bank.Welcome(code, userName));
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(cardP.GetName());

}

