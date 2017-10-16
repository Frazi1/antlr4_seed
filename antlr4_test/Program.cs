using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Tree;

namespace antlr4_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            // to type the EOF character and end the input: use CTRL+D, then press <enter>     
            text = File.ReadAllText("input.txt");
            AntlrInputStream inputStream = new AntlrInputStream(text.ToString());
            Combined1Lexer speakLexer = new Combined1Lexer(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(speakLexer);
            Combined1Parser speakParser = new Combined1Parser(commonTokenStream);
            IParseTree tree = speakParser.compileUnit();
            AstNodePrinter.Print(tree);
            //Console.WriteLine(tree.ToStringTree());
            //ParseTreeWalker walker = new ParseTreeWalker();
            //walker.Walk(new TestWalker(), tree);
        }
    }

    internal class TestWalker : Combined1BaseListener
    {
      
    }
}
