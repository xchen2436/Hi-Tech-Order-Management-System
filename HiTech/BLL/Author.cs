using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTech.DAL;

namespace HiTech.BLL
{
    public class Author
    {
        private int authorId;
        private string authorName;

        public int AuthorId { get => authorId; set => authorId = value; }
        public string AuthorName { get => authorName; set => authorName = value; }

        public List<Author> ListAuthor()
        {
            return AuthorDB.GetListAuthor();
        }
    }
}