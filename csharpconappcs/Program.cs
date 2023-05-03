// See https://aka.ms/new-console-template for more information

//1.cnvrt data into binary to decimal and hexa without using string
//1
Console.WriteLine("Literal Improvement");
Console.WriteLine("============================");

//var d = 123_456;
//var x = 0xAB_CD_EF;
//var b = 0b1010_1011_1100_1100_1110_1111;

//Console.WriteLine(d);
//Console.WriteLine("Type of D is " + d.GetType());
//Console.WriteLine("........................");

//Console.WriteLine(b);
//Console.WriteLine("Type of B is " + b.GetType());
//Console.WriteLine("........................");


//Console.WriteLine(x);
//Console.WriteLine("Type of X is " + x.GetType());
//Console.WriteLine("........................");

Console.WriteLine("============================");

//2

// *pl sql store procedure diffrence
Console.WriteLine("Tuples And Deconstruction");
// allow to return more than one value
Console.WriteLine("-----------------------------");
/*
var primes = Tuple.Create(2, 3, 5, 7, 11, 13, 80, 23);
Console.WriteLine("Prime numbers less than 20: " +
                  "{0}, {1}, {2}, {3}, {4}, {5}, {6}, and {7}",
                 primes.Item1, primes.Item2, primes.Item3,
                 primes.Item4, primes.Item5, primes.Item6,
                  primes.Item7, primes.Rest.Item1);
Console.WriteLine("........................");

*/



/*
(double, int) t1 = (4.5, 3);
Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
// Output: Tuple with elements 4.5 and 3.
Console.WriteLine("........................");


(double Sum, int Count) t2 = (4.5, 3);
Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
// Output: Sum of 3 elements is 4.5.
Console.WriteLine("........................");

*/

/*
(double, int) t = (4.5, 3);
Console.WriteLine(t.ToString());
Console.WriteLine($"Hash Code of {t} is {t.GetHashCode()}.");
//output:(4.5, 3)
//       Hash Code of (4.5, 3) is 1839267287.
*/

/*
var population = new Tuple<string, int, int, int, int, int, int>("India",1,2,3,4,5,6);
Console.WriteLine("population of {0} in 2000 : {1:N0}", population.Item1,population.Item6);
//OUTPUT = population of India in 2000 : 5
Console.WriteLine("........................");

var population1 = Tuple.Create<string, int, int, int, int, int, int>("India", 1, 2, 3, 4, 5, 6);
Console.WriteLine("population of {0} in 2000 : {1:N0}", population1.Item1, population1.Item7);
//OUTPUT = population of India in 2000 : 6
Console.WriteLine("........................");


var t =(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
Console.WriteLine(t.Item10);
//OUTPUT = 10
Console.WriteLine("........................");
*/

/*
var xs = new[] { 4, 7, 9 };
var limits = FindMinMax(xs);
Console.WriteLine($"Limits of [{string.Join(" ", xs)}] are {limits.min} and {limits.max}");
//OUTPUT = Limits of[4 7 9] are 4 and 9


var ys = new[] { -9, 0, 67, 100 };
var (minimum, maximum) = FindMinMax(ys);
Console.WriteLine($"Limits of [{string.Join(" ", ys)}] are {minimum} and {maximum}");
// OUTPUT = Limits of [-9 0 67 100] are - 9 and 100
*/

var xs = new[] { 4, 7, 9 };
var limits = FindMinMax(xs);
Console.WriteLine($"Limits of [{string.Join(" ", xs)}] are {limits.min} and {limits.max}");
//OUTPUT = Limits of[4 7 9] are 4 and 9


var ys = new[] { -9, 0, 67, 100 };
var (minimum, maximum) = FindMinMax(ys);
Console.WriteLine($"Limits of [{string.Join(" ", ys)}] are {minimum} and {maximum}");
// OUTPUT = Limits of [-9 0 67 100] are - 9 and 100
(int min, int max) FindMinMax(int[] input)
{
    if (input is null || input.Length == 0)
    {
        throw new ArgumentException("Cannot find minimum and maximum of a null or empty array.");
    }

    var min = int.MaxValue;
    var max = int.MinValue;
    foreach (var i in input)
    {
        if (i < min)
        {
            min = i;
        }
        if (i > max)
        {
            max = i;
        }
    }
    return (min, max);
}

static void Main(string[] args)
{
    /*
    var xs = new[] { 4, 7, 9 };
    var limits = FindMinMax(xs);
    Console.WriteLine($"Limits of [{string.Join(" ", xs)}] are {limits.min} and {limits.max}");
    //OUTPUT = Limits of[4 7 9] are 4 and 9


    var ys = new[] { -9, 0, 67, 100 };
    var (minimum, maximum) = FindMinMax(ys);
    Console.WriteLine($"Limits of [{string.Join(" ", ys)}] are {minimum} and {maximum}");
    // OUTPUT = Limits of [-9 0 67 100] are - 9 and 100
    */
    


}


Console.WriteLine("============================");
