/*
string? readResult;
bool validEntry = false;
bool inRange = false;
int numericEntry;

Console.WriteLine("Enter an integer value between 5 and 10");

do {
    readResult = Console.ReadLine();
    validEntry = int.TryParse(readResult, out numericEntry);

    if (validEntry) {
        if (numericEntry >= 5 && numericEntry <= 10) {
            inRange = true;
            Console.WriteLine($"Your input value ({numericEntry}) has been accepted.");
        } else {
            Console.WriteLine($"You entered {numericEntry}. Please enter a number between 5 and 10.");
        }
    } else {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (inRange == false);
*/

/*
string? readResult;
string parsedResult = "";
bool matches = false;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do {
    readResult = Console.ReadLine();
    if (readResult != null) {
        parsedResult = readResult.Trim().ToLower();
    }
    switch (parsedResult) {
        case "administrator":
            matches = true;
            break;
        case "manager":
            matches = true;
            break;
        case "user":
            matches = true;
            break;
        default:
            Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");
            break;
    }
} while (matches == false);

Console.WriteLine($"Your input value ({readResult}) has been accepted.");
*/

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
string myString;
int periodLocation;
string sentence;

for (int i = 0; i < myStrings.Length; i++) {
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");
    
    while (periodLocation != -1) {
        sentence = myString.Substring(0, periodLocation);
        myString = myString.Remove(0, periodLocation + 1).TrimStart();
        Console.WriteLine(sentence);
        periodLocation = myString.IndexOf(".");
    }
    Console.WriteLine(myString);
}
