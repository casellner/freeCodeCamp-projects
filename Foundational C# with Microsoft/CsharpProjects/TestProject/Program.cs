const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// define tags to look for
const string openSpan = "<span>";
const string closeSpan = "</span>";
const string openDiv = "<div>";
const string closeDiv = "</div>";

int openingPosition = input.IndexOf(openSpan);
int closingPosition = input.IndexOf(closeSpan);

openingPosition += openSpan.Length; // skip over the span
int length = closingPosition - openingPosition;
quantity += "Quantity: " + input.Substring(openingPosition, length);

// copy input to output and remove <div> tags
output += "Output: " + input;
openingPosition = output.IndexOf(openDiv);
output = output.Remove(openingPosition, openDiv.Length);
closingPosition = output.IndexOf(closeDiv);
output = output.Remove(closingPosition, closeDiv.Length);

output = output.Replace("&trade;", "&reg;");

Console.WriteLine(quantity);
Console.WriteLine(output);
