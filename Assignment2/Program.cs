foreach (var wizard in WizardCollection.Create())
{
    Console.WriteLine(wizard);
}

Extensions.IsSecure(new Uri("https://www.ietf.org/rfc/rfc2396.txt"));