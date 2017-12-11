using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    /*
        Code snappits
        ctor: Default constructor

        prop: Property

        propg: Read only property

        sim: static int main method

        svm: static void main method
    */



    public class BookManager
    {

        List<Books> _books;

        public BookManager(int capacity)
        {
            _books = new List<Books>(capacity);
        }
     
        public void AddBok(Books newbook) {
            _books.Add(newbook);
        }


        public string writeGrades() {
            string marge = "";
            foreach (var item in _books)
            {
                marge += "Name: " + item.Name + " - Price: " + item.price.ToString() + " - HashCode: " + item.HashCode.ToString() + Environment.NewLine;
            }

            return marge;
        }

        public List<Books> GetBook()
        {
            return _books;
        }

    }

    public class Books {
        public int id { get; set; }
        public string Name { get; set; }
        public float price { get; set; }
        public int HashCode{ get; set; }

    }
}
