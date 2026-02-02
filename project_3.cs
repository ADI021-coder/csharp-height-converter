{
    Console.WriteLine("Hello World!");
    Console.WriteLine("Height Converter");

    Console.Write("enter your height in cm: ");
    string cmHeight = Console.ReadLine();
    double mHeight = Convert.ToDouble(cmHeight)/100;

    double fHeight = (double) (mHeight*100)/30.48;

    Console.WriteLine("Your height in meters is " + mHeight + "m and in feet is " + fHeight + "f.");
}