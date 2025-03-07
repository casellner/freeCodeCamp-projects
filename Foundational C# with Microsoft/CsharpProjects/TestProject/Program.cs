/*
Random coin = new Random();
string coinFlip = coin.Next(0, 2) == 0 ? "heads" : "tails";

Console.WriteLine(coinFlip);
*/

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin")) {
    if (level > 55) {
        Console.WriteLine("Welcome, Super Admin user.");
    } else {
        Console.WriteLine("Welcome, Admin user.");
    }
} else if (permission.Contains("Manager")) {
    if (level >= 20) {
        Console.WriteLine("Contact an Admin for access.");
    } else {
        Console.WriteLine("You do not have sufficient privileges.");
    }
} else {
    Console.WriteLine("You do not have sufficient privileges.");
}
