using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pooIntroGroupA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //modificar propiedades de los controles
            label1.Text = "Escriba el titulo del libro";            
            button1.Text = "Agregar";

                     



            //MEDIANTE METODOS DE PROPIEDAD
            //creamos un objeto libro
            //SET
            //book.setBookId(1);
            //book.setTitle("Harry Potter");

            //mostrar datos de libro
            //GET
            //MessageBox.Show(book.getBookId() + book.getTitle());

            //MEDIANTE PROPIEDAD AUTOIMPLEMENTADA
            //SET
            //book._publishedDate = "2001";

            //GET
            //MessageBox.Show(book._publishedDate);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //haciendo uso de constructor pasando todos los parametros
            //instancia de la clase Book
            /*  Book object1 = new Book(1, "PROTECCIÓN DE DATOS Y SEGURIDAD DE LA INFORMACIÓN",
                  "Seguridad de los datos", "2015", "9788499645605");
              Book object2 = new Book(2, "BACKTRACK 5",
                             "Seguridad de los datos", "2015", "9788499642321");

              //mostrar datos de objeto1
              // MessageBox.Show(object1.getBookId() + object1.getTitle() + object1.getSubtitle() +
              //   object1._publishedDate + object1._ISBN);

              //llamado del metodo getBookInfo
              MessageBox.Show(object1.getBookInfo());


              //mostrar datos de objeto2
              MessageBox.Show(object2.getBookId() + object2.getTitle() + object2.getSubtitle() +
                 object2._publishedDate + object2._ISBN);


              //haciendo uso de constructor pasando el parametro titulo
              Book book = new Book(txtTitulo.Text);
              listBox1.Items.Add("Objeto " + book.getTitle());

              //haciendo uso de constructor vacío
              Book libro = new Book();
              libro.setTitle("");

              //agregar datos al listbox
              listBox1.Items.Add(object1.getBookInfo());
              listBox1.Items.Add(object2.getBookInfo());*/



            //crear instancia            
            Book book = new Book();
            book.setTitle(txtTitulo.Text);
            book.setSubtitle(txtSubtitulo.Text);

            //agregar los datos al ListBox
            listBox1.Items.Add(book.getTitleSubtitle());

            //limpiar los textbox y enviar enfoque a txttitle
            txtTitulo.Text = "";
            txtSubtitulo.Text = "";
            txtTitulo.Focus();
        }
    }
}
