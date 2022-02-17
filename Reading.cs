using IronOcr;
using System;

namespace Reading
{
  class Read
  {
    static void Main(string[] args)
    {
      //Input for file location//
      Console.WriteLine("Enter file name: \n");
      string File = Console.ReadLine();
      
      //Reads the file and turns it into text//
      var Ocr = new IronTesseract();
      Ocr.Language = OcrLanguage.English;
      var Result = IronTesseract().Read(File).Text;
      
      //Returns the text//
      return Result
    }
  }
}
