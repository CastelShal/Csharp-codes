using System.Xml.Linq;

namespace AllPracs
{
    internal class Linkq
    {
        public static void Main(string[] args)
        {
            const String path = "C:\\Users\\Shalom\\Documents\\cd_catalog.xml";
            XDocument doc = XDocument.Load(path);
            var books = doc.Element("catalog").Elements("book");
            var res = books.Where(book => DateTime.ParseExact(book.Element("publish_date").Value, "yyyy-MM-dd", null) >= DateTime.ParseExact("01-01-2001", "dd-MM-yyyy", null));
            foreach (var book in res)
            {
                Console.WriteLine($"Title: {book.Element("title").Value} - Date: {book.Element("publish_date").Value}");
            }
        }
    }
}
