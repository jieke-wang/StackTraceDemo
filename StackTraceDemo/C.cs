using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StackTraceDemo
{
    public class C
    {
        public void MethodC()
        {
            StackTrace stackTrace = new StackTrace();
            foreach (var frame in stackTrace.GetFrames())
            {
                MethodBase method = frame.GetMethod();
                Console.WriteLine($"FileName: {frame.GetFileName()}; ColumnNumber: {frame.GetFileColumnNumber()}; LineNumber: {frame.GetFileLineNumber()}; ILOffset: {frame.GetILOffset()}; NativeOffset: {frame.GetNativeOffset()}; Method: {method?.Name}");
            }

            try
            {
                int i = 0;
                int j = i / i;
                Console.WriteLine(j);
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine();
                stackTrace = new StackTrace(ex);
                foreach (var frame in stackTrace.GetFrames())
                {
                    MethodBase method = frame.GetMethod();
                    Console.WriteLine($"FileName: {frame.GetFileName()}; ColumnNumber: {frame.GetFileColumnNumber()}; LineNumber: {frame.GetFileLineNumber()}; ILOffset: {frame.GetILOffset()}; NativeOffset: {frame.GetNativeOffset()}; Method: {method?.Name}");
                }
            }
        }
    }
}
