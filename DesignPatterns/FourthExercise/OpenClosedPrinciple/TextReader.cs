using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthExercise.OpenClosedPrinciple
{
    public class TextReader
    {
        public void ReadAndPrint(string fileName)
        {
            var lines = File.ReadLines(fileName);
            var codeElements = new List<ICodeElement>();

            foreach (var line in lines)
            {
                switch (line[0])
                {
                    case '$':
                        codeElements.Add(new Variable());
                        break;
                    case '!':
                        if (line == "!execute")
                        {
                            codeElements.Add(new Execution());
                        }
                        else if(line.StartsWith("!command")
                        {
                            codeElements.Add(new Command());
                        }
                        else if(line == "!directive")
                        {
                            codeElements.Add(new Directive());
                        }                     
                        break;                    
                    default:
                        break;
                }            
            }

            codeElements.ForEach(c => c.Print());
        }
    }
}
