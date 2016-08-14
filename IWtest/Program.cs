using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IWtest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create list, using string because it's easier
            List<string> myList = new List<string>();

            // Fill list with data
            for (int i = 0; i < 10000; i++)
            {
                myList.Add(string.Format("BS data line #{0}", i.ToString()));
            }

            // Create a file that will not work
            StreamWriter writer = File.CreateText("colon:is:bad:in:file:names.txt");

            // So when this fails you still like to get your data out.
            // In the Immediate Window you can run this, press enter after each line
            // StreamWriter writer1 = File.CreateText("output.txt");
            // myList.ForEach(writer1.WriteLine);
            // writer1.Close();
            //
            // It will give you this output;
            // StreamWriter writer1 = File.CreateText("output.txt");
            // {System.IO.StreamWriter}
            //  base: {System.IO.StreamWriter}
            //  AutoFlush: false
            //  BaseStream: {System.IO.FileStream}
            //  Encoding: {System.Text.UTF8Encoding}
            // myList.ForEach(writer1.WriteLine);
            // Expression has been evaluated and has no value
            // writer1.Close();
            // Expression has been evaluated and has no value
            //
            // Now there will be a output.txt file in the debug folder containing 10000 lines.
        }
    }
}
