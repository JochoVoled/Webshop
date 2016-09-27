using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using BestOfBrands.Interfaces;

namespace BestOfBrands.Logs
{
    public class Log : ILog
    {
        //*** This is a Singleton design pattern ***

        // The single instance
        private static Log instance;

        // Initialize the single instance in a static constructor
        static Log()
        {
            instance = new Log();
        }

        // The property for retrieving the single instance
        public static Log Instance
        {
            get { return instance; }
        }

        // Private constructor: protects against direct instantiation
        private Log() { }

        private string fileName = "..\\..\\Log.txt";

        // Public Add method to add an entry to the log (write to file).
        public void Add(string logEntry)
        {
            StreamWriter sr = new StreamWriter(fileName, true);

            using (sr)
            {
                try
                {
                    sr.WriteLine(DateTime.Now + " : " + logEntry);
                }
                catch (Exception ex)
                {
                   
                }
                
            }


        }
    }
}