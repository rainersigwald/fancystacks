using System;
using System.Text;
using System.Text.RegularExpressions;

namespace fancystacks
{
    public class Program
    {
        static Regex parser = new(
            @"^(?<method>.*\)) Line \d+\r?\n\s+at (?<file>[^(]+)\((?<line>\d+)\)",
            RegexOptions.Multiline | RegexOptions.Compiled);

        static void Main(string[] args)
        {
            // Read stack from clipboard or prompt.

            // Get base URL including commit

            // transform into markdown

            // copy to clipboard
        }

        public static string Markdownify(string stack, string baseUri, string repoRoot)
        {
            if (!repoRoot.EndsWith('\\'))
            {
                repoRoot += '\\';
            }

            StringBuilder o = new(stack.Length);

            foreach (Match match in parser.Matches(stack))
            {
                GroupCollection groups = match.Groups;
                string file = groups["file"].Value;

                if (file.StartsWith(repoRoot))
                {
                    o.Append("* [`");
                    o.Append(groups["method"]);
                    o.Append("`](");
                    o.Append(baseUri);
                    o.Append(file.Substring(repoRoot.Length).Replace('\\', '/'));
                    o.Append("#L");
                    o.Append(groups["line"]);
                    o.AppendLine(")");
                }
                else
                {
                    o.Append("* ");
                    o.AppendLine(groups["method"].Value);
                }
            }

            return o.ToString();
        }
    }
}
