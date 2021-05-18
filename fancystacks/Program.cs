using System;
using System.Text;

namespace fancystacks
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Read stack from clipboard or prompt.

            // Get base URL including commit

            // transform into markdown

            // copy to clipboard
        }

        public static string Markdownify(string stack, string baseUri)
        {
            StringBuilder o = new(stack.Length);

            int i = stack.IndexOf('\n');

            o.Append("* [`");
            o.Append(stack, 0, i);

            System.Console.WriteLine(o.ToString());

            o.Append("`](asdf");

            System.Console.WriteLine(o.ToString());

            // o.Append(baseUri);

            return o.ToString();
        }
    }
}
