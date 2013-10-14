﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NDesk.Options;
using RocksmithToolkitLib.DLCPackage;

namespace PcDecrypt
{
    internal class Arguments
    {
        public bool ShowHelp;
        public bool Encrypt;
        public List<string> InputFiles = new List<string>();
        public string OutputDirectory;
    }

    internal class Program
    {
        private static OptionSet GetOptions(Arguments outputArguments)
        {
            return new OptionSet
            {
                { "h|?|help", "Show this help message and exit", v => outputArguments.ShowHelp = v != null },
                { "e|encrypt", "Encrypt the files instead decrypt", v => outputArguments.Encrypt = v != null },
                { "i|input=", "The encrypted input file or directory (required, multiple allowed)", v => outputArguments.InputFiles.Add(v) },
                { "o|output=", "The output directory (defaults to the input directory)", v => outputArguments.OutputDirectory = v }
            };
        }

        static void Main(string[] args)
        {
            var arguments = new Arguments();
            var options = GetOptions(arguments);
            try
            {
                options.Parse(args);
                
                if (arguments.ShowHelp)
                {
                    options.WriteOptionDescriptions(Console.Out);
                    return;
                }
                
                if (!arguments.InputFiles.Any())
                {
                    ShowHelpfulError("Must specify at least one input file or directory.");
                    return;
                }

                var inputDirectories = arguments.InputFiles.Where(Directory.Exists).ToList();
                foreach (var inputDirectory in inputDirectories)
                {
                    var filesInDirectory = Directory.EnumerateFiles(inputDirectory);
                    arguments.InputFiles.Remove(inputDirectory);
                    arguments.InputFiles.AddRange(filesInDirectory);
                }

                var missingFiles = arguments.InputFiles.Where(i => !File.Exists(i)).ToList();
                if (missingFiles.Any())
                {
                    var message = "The specified input file(s) do not exist: \n"
                        + string.Join("\n", missingFiles.Select(f => "\t" + f));
                    ShowHelpfulError(message);
                }
            }
            catch (OptionException ex)
            {
                ShowHelpfulError(ex.Message);
                return;
            }

            foreach (var inputPath in arguments.InputFiles)
            {
                var inputFile = inputPath;
                if (arguments.Encrypt)
                    if (Path.GetExtension(inputFile) != ".decrypted")
                        Console.WriteLine(String.Format("Warning: The file '{0}' has no '.decrypted' extension. Probably it's already a encrypted file.", inputFile));

                var outputDirectory = arguments.OutputDirectory ?? Path.GetDirectoryName(inputFile);
                var outputFilename = Path.GetFileName(inputFile);

                if (arguments.Encrypt) {
                    outputFilename += Path.GetFileNameWithoutExtension(inputFile);
                } else {
                    outputFilename += ".decrypted";
                }
                var outputPath = Path.Combine(outputDirectory, outputFilename);

                Directory.CreateDirectory(outputDirectory);

                using (var inputStream = File.OpenRead(inputFile))
                using (var outputStream = File.Create(outputPath))
                {
                    if (arguments.Encrypt)
                        RijndaelEncryptor.Encrypt(inputStream, outputStream, RijndaelEncryptor.PcKey);
                    else
                        RijndaelEncryptor.Decrypt(inputStream, outputStream, RijndaelEncryptor.PcKey);
                }
            }
        }

        static void ShowHelpfulError(string message)
        {
            Console.Write("pcdecrypt: ");
            Console.WriteLine(message);
            Console.WriteLine("Try 'pcdecrypt --help' for more information.");
        }
    }
}
