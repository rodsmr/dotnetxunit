using System.Reflection.Metadata.Ecma335;

namespace FooBarQix
{
    //Step 1 - Rules
    //If the number is divisible by 3, write “Foo” instead of the number
    //If the number is divisible by 5, add “Bar”
    //If the number is divisible by 7, add “Qix”
    //For each digit 3, 5, 7, add “Foo”, “Bar”, “Qix” in the digits order.
    public class FooBarQix
    {
        public string? Compute(string item) {
            
            int? number = Convert.ToInt32(item);

            if (number % 3 == 0) return "Foo";
            
            return "Foo";
        }
    }
}
