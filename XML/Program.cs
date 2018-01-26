using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Создайте XML- документ, представляющий информацию по определенной вариантом
             *  предметной области. Созданный документ должен соответствовать следующим
             *   требования:
1.	документы должны иметь глубину вложенности не менее четырех элементов;
2.	число элементов документа, не имеющих вложенных, должно быть не менее пяти;
*/
            XDocument xdoc1 = new XDocument(new XElement("Games",
                new XElement("Game",
                  new XAttribute("genre", "Arcade"),
                  new XElement("name","Pac-Man"),
                  new XElement("releasedYear","1980"),
                  new XElement("Programmers","Shigeo Funaki")),
                new XElement("Game", 
                  new XAttribute("genre","Simulator"),
                  new XElement("name","Need for Speed"),
                  new XElement("releasedYear", "1994"),
                  new XElement("Programmers", "Brad Gour")),
                new XElement("Game",
                  new XAttribute("genre","Shooter"),
                  new XElement("name","Doom"),
                  new XElement("releasedYear", "1993"),
                  new XElement("Programmers", "John Carmack, John Romero, Dave Taylor")),
                new XElement("Game",
                  new XAttribute("genre","Strategy"),
                  new XElement("name", "Heroes of Might and Magic"),
                   new XElement("releasedYear", "1995"),
                  new XElement("Programmers", "Phil Steinmeyer")),
                 new XElement("Game",
                  new XAttribute("genre", "Sport")),
                  new XElement("Game",
                  new XAttribute("genre", "Quest"),
 // 3.элементы документа должны содержать комментарии о своем содержании;
            new XComment("Out of sold")),
                  new XElement("Game",
                  new XAttribute("genre", "For-kids"),
                  new XComment("Out of sold")),
                  new XElement("Game",
                  new XAttribute("genre", "For-girls"),
                  new XComment("Out of sold"))));
            xdoc1.Save("Games.xml");
          
            Console.WriteLine(xdoc1);
            Console.WriteLine();
            /*5.	Создание XML документа в текстовом редакторе и 
   проверка структуры документа в программе-броузере Internet Explorer.*/
            XmlDocument xdoc2 = new XmlDocument();
            xdoc2.Load("films.xml");
            XmlElement xRoot = xdoc2.DocumentElement;
            foreach(XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                    {
                        Console.WriteLine(attr.Value);
                    }
                 }
                foreach(XmlNode chlnode in xnode.ChildNodes)
                {
                    if (chlnode.Name != null)
                    {
                        Console.WriteLine("\t" + chlnode.InnerText);
                    }
                }
            }


            /*6.	Создать XML документ в файле 1.xml следующей структуры:
Информационная часть документа содержится в элементах NAIM и PRICE 
и равна слову Бензин – для элемента NAIM и числу 20 – для элемента PRICE. 
Кодировка документа должна быть WINDOWS-1251, версия языка XML – 1.0, 
документ должен быть автономным.
*/
            XDocument xdoc = new XDocument(new XElement("Tovary",
                new XElement("Tovar",
                  new XElement("Naim", "Бензин"),
                  new XElement("Price", "20")),
                new XElement("Tovar",
                  new XElement("Naim", "Gaz"),
                  new XElement("Price", "15"))));
            xdoc.Save("1.xml");

            Console.WriteLine(xdoc);
            /*Создайте XML- документ, представляющий информацию по определенной вариантом
             *  предметной области. Созданный документ должен соответствовать следующим
             *   требования:
1.	документы должны иметь глубину вложенности не менее четырех элементов;

2.	число элементов документа, не имеющих вложенных, должно быть не менее пяти;

3.	элементы документа должны содержать комментарии о своем содержании;

4.	документ должен включать элементы, содержащие символьные данные и дочерний элементы;

5.	Создание XML документа в текстовом редакторе и 
проверка структуры документа в программе-броузере Internet Explorer.

6.	Создать XML документ в файле 1.xml следующей структуры:
  

Информационная часть документа содержится в элементах NAIM и PRICE 
и равна слову Бензин – для элемента NAIM и числу 20 – для элемента PRICE. 
Кодировка документа должна быть WINDOWS-1251, версия языка XML – 1.0, 
документ должен быть автономным.

*/
        }
    }
}
