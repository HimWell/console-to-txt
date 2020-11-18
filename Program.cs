using System;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // string value 
            string stringValue = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            
            // array to store letters
            int[] letters = new int[stringValue.Length];

            // loop through each letter in string value
            foreach(char x in stringValue)
            {
                letters[char.ToUpper(x)]++;
            }

                    // output result to text file as spec
                    FileStream fileStream;
                    StreamWriter streamWriter;
                    TextWriter textWriter = Console.Out;
                    try
                    {
                        fileStream = new FileStream("C:/Users/HimalChowhan/Downloads//Output.txt", FileMode.OpenOrCreate, FileAccess.Write);
                        streamWriter = new StreamWriter(fileStream);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Cannot open Output.txt for writing");
                        Console.WriteLine(e.Message);
                        return;
                    }
                    Console.SetOut(streamWriter);
                    for (int i = 0; i < stringValue.Length; i++)
                    {
                        if (letters[i] > 0 && char.IsLetterOrDigit(char.ToUpper((char)i)))
                        {
                            Console.WriteLine("Character: {0}: - Number of characters: {1}", (char)i, letters[i]);                
                        }
                    }
                    Console.SetOut(textWriter);
                    streamWriter.Close();
                    fileStream.Close();

            // this was to test the values in console, can ignore
            for (int i = 0; i < stringValue.Length; i++)
            {
                if (letters[i] > 0 && char.IsLetterOrDigit(char.ToUpper((char)i)))
                {
                    Console.WriteLine("Character: {0}: - Number of characters: {1}", (char)i, letters[i]);
                }
            }
        }
            }
        }