using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    public interface IPokemon
    {
        int age {  get; set; } // 포켓몬이라면 나이를 가지고 있음. 대신 이게 인터페이스에 들어가면 get, set 직접 구현해야함
        string ability { get; set; } // 특성

        void fight();
        void charming();

    }
}
