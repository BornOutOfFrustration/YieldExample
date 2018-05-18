namespace YieldExample
{
    using System.Collections.Generic;

    public class Example2
    {
        List<string> ListWithCharacters = new List<string>()
        {
            "A", "B", "C",
        };

        public IEnumerable<Character> ListOfCharsUsingYield()
        {
            foreach (var @char in ListWithCharacters)
            {
                // Yield will make a statemachine.
                // - return type of the method is IEnumerable<Character>. A virtual return object is created.
                // - each time a yield return is encountered, the return value (in this case a new character object)
                //   is added to the virtual return object.
                // After the foreach the virtual return object is returned.
                yield return new Character() { Char = @char };
            }
        }
    }

    public class Character
    {
        public string Char { get; set; }
    }
}
