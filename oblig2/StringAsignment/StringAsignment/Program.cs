using System;
using System.IO;
using static System.IO.File;
using System.IO.Compression;
using System.Diagnostics;

namespace StringAsignment
{
    class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Press 1 to Compress file. \n Press 2 to decrompress.");
            var answer = Console.ReadLine();
            if (answer == "1")
            {
                Console.WriteLine("Enter path to file you want to compress.");
                var path = Console.ReadLine();
                CompressFile(path);
            }
            else if (answer == "2")
            {
                Console.WriteLine("Enter path to file you want to decompress.");
                var path = Console.ReadLine();
                DecompressFile(path);
            }
            else
            {
                Console.WriteLine("you Oofed yourself, try again.");
            }
        }

        private static void DecompressFile(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    using (var zipfile = OpenRead(path))
                    {
                        using (var outputFile = Create(path.Split(".gz")[0]))
                        {
                            using (var decompressor = new GZipStream(zipfile, CompressionMode.Decompress))
                            {
                                decompressor.CopyTo(outputFile);
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }
            else
            {
                Console.WriteLine("File does not exist in given directiory.");
                Environment.Exit(1);
            }
        }

        static void CompressFile(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    // make the stopwatch
                    var stopWatch = new Stopwatch();
                    stopWatch.Restart();
                    //timer has now started , start compression.
                    using (var targetFile = OpenRead(path))
                    {
                        using (var output = Create(path + ".gz"))
                        {
                            using (var compressor = new GZipStream(output, CompressionMode.Compress))
                            {
                                targetFile.CopyTo(compressor);
                            }
                        }
                    }
                    // compression is done. 
                    stopWatch.Stop();
                    Console.WriteLine("File has been compressed in " + stopWatch.ElapsedMilliseconds / 100 + " time.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }
            else
            {
                Console.WriteLine("File does not exist in given directiory.");
                Environment.Exit(1);
            }

        }
    }
}


