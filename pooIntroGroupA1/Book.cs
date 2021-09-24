using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooIntroGroupA1
{
    class Book
    {
        //DEFINIR MIEMBROS DE LA CLASE
        //propiedades|atributos|datos
        private int _bookId;
        private string _title;
        private string _subtitle;

        //propiedades autoimplementadas
        public string _publishedDate { get; set; }
        public string _ISBN { get; set; }


        //metodo constructor
        /// <summary>
        /// sobrecarga de metodo constructor
        /// </summary>
        public Book() //constructor vacío
        { }
        public Book(int bookId, string title, string subtitle, string publishedDate, string ISBN) //metodo constructor 
        {
            _bookId = bookId;
            _title = title;
            _subtitle = subtitle;
            _publishedDate = publishedDate;
            _ISBN = ISBN;
        }

        public Book(string title)
        {
            _title = title;
        }
        public Book(string title, string subtitle)
        {
            _title = title;
            _subtitle = subtitle;
        }

        //metodos de propiedad
        //get -- obtiene el valor almacenado en la propiedad
        //set --  asignar un valor a la variable de propiedad

        //_bookId
        public void setBookId(int bookId)
        {
            _bookId = bookId;
        }
        public int getBookId()
        {
            return _bookId;
        }
        //_title
        public void setTitle(string title)
        {
            _title = title;
        }
        public string getTitle()
        {
            return _title;
        }
        //_subtitle
        public void setSubtitle(string subtitle)
        {
            _subtitle = subtitle;
        }
        public string getSubtitle()
        {
            return _subtitle;
        }


        //METODOS
        public string getBookInfo()
        {
            return _bookId + " " + _title + " " + _subtitle + " " + _publishedDate + " "
                + _ISBN;
        }

        public string getTitleSubtitle()
        {
            return "Titulo: " + _title + " Subtitulo: " + _subtitle;
        }
    }
}
