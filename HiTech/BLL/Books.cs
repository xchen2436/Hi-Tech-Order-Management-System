using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTech.DAL;

namespace HiTech.BLL
{
    public class Books
    {
        private long iSBN;
        private string bookTitle;
        private int qOH;
        private double price;
        private int categoryId;
        private int authorId;
        private int publisherId;
        private string yearPublished;
        private string edition;
        public long ISBN { get => iSBN; set => iSBN = value; }
        public string BookTitle { get => bookTitle; set => bookTitle = value; }
        public int QOH { get => qOH; set => qOH = value; }
        public double Price { get => price; set => price = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public int AuthorId { get => authorId; set => authorId = value; }
        public int PublisherId { get => publisherId; set => publisherId = value; }
        public string YearPublished { get => yearPublished; set => yearPublished = value; }
        public string Edition { get => edition; set => edition = value; }

        public List<Books> ListBook()
        {
            return BookDB.GetListBook();
        }
    }
}