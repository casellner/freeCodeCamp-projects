Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

daysUntilExpiration = 11;

if (daysUntilExpiration == 0) {
    Console.WriteLine("Your subscription has expired.");
} else if (daysUntilExpiration == 1) {
    Console.WriteLine("Your subscription expires within a day!");
} else if (daysUntilExpiration <= 5) {
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
} else if (daysUntilExpiration <= 10) {
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (daysUntilExpiration == 1) {
    discountPercentage = 20;
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
} else if (daysUntilExpiration <= 5 && daysUntilExpiration != 0) {
    discountPercentage = 10;
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
