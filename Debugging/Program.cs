

const double a = 4.5;
const double b = 2.5;
var answer = Add(a, b);

WriteLine($"{a} + {b} = {answer}");
WriteLine("Press Enter to end app.");
ReadLine(); // Wait for user to press Enter
double Add(double a, double b)
{
    return a * b; // Deliberate bug
}

