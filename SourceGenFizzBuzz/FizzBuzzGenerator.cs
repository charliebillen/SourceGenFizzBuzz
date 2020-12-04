using Microsoft.CodeAnalysis;

namespace SourceGenFizzBuzz
{
    [Generator]
    public class FizzBuzzGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
        }

        public void Execute(GeneratorExecutionContext context)
        {
            const string source = @"
    public static class FizzBuzz
    {
        public static string GetAnswer(int n)
            => (n % 3, n % 5) switch
            {
                (0, 0) => ""FizzBuzz"",
                (_, 0) => ""Buzz"",
                (0, _) => ""Fizz"",
                _ => $""{n}""
            };
    }
";
            context.AddSource("FizzBuzz.cs", source);
        }
    }
}
