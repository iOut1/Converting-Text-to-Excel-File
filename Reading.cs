using IronOcr;
using System;

namespace Reading
{
  class Read
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter file name: \n");
      string File = Console.ReadLine();

      var Ocr = new IronTesseract();
      Ocr.Language = OcrLanguage.English;
      var Result = Ocr.Read(File);
      return Result.Text;
    }
  }
}
