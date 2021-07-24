using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StackTraceDemo
{
    public class B
    {
        public void MethodB(C c)
        {
            StackTrace stackTrace = new StackTrace();
            foreach (var frame in stackTrace.GetFrames())
            {
                MethodBase method = frame.GetMethod();
                Console.WriteLine($"FileName: {frame.GetFileName()}; ColumnNumber: {frame.GetFileColumnNumber()}; LineNumber: {frame.GetFileLineNumber()}; ILOffset: {frame.GetILOffset()}; NativeOffset: {frame.GetNativeOffset()}; Method: {method?.Name}");
            }
            Console.WriteLine();
            Console.WriteLine();
            c.MethodC();
        }
    }
}
