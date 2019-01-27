using System;
using System.Data;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet library = new DataSet("Library");

            DataTable books = new DataTable("Books");
            DataTable clients = new DataTable("Clients");

            DataColumn Id = new DataColumn("Id", typeof(int));
            DataColumn name = new DataColumn("name", typeof(string));
            DataColumn author = new DataColumn("author", typeof(string));
            books.PrimaryKey = new DataColumn[] { books.Columns["Id"] };

            books.Columns.AddRange(new DataColumn[] { Id, name, author });

            DataColumn ClientId = new DataColumn("Id", typeof(int));
            DataColumn Name = new DataColumn("Name", typeof(string));
            DataColumn BookId = new DataColumn("BookId", typeof(int));
            clients.PrimaryKey = new DataColumn[] { clients.Columns["ClientId"] };

            clients.Columns.AddRange(new DataColumn[] { ClientId, Name, BookId });

            library.Tables.AddRange(new DataTable[] { books, clients });

            DataRow Book = books.NewRow();
            Book.ItemArray = new object[] { 1, "Book 1", "Book 1 Name" };
            books.Rows.Add(Book);


            DataRow Client = clients.NewRow();
            Client.ItemArray = new object[] { 1, "Client 1", 1 };
            clients.Rows.Add(Client);

            Console.ReadLine();
        }
    }
}
