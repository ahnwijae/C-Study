using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp07
{
    public class Book
    {
        public string isbn {  get; set; } // 책의 고유 번호
        public string name { get; set; }
        public string publisher { get; set; }
        public int page { get; set; }
        public string userId { get; set; } // 빌린 사람의 ID (일종의 FK)
        public string userName { get; set; } // 빌린 사람의 이름(inner join으로 얻을 수 있는 값)
        public bool isBorrowed { get; set; }
        public DateTime BorrowedAt { get; set; }

    }
}
