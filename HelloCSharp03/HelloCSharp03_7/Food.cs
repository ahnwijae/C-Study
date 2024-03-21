using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp03_7
{

    // Food 만으론 인스턴스 못 만듬
    // 추상화 = 구체화를 못 한다 = 인스턴스 못 만든다.
    // Food f = new Food(); <-불가능
    public abstract class Food // 추상화 된 클래스
    {
        public string name {  get; set; }
        public int price { get; set; }

        public abstract void taste(); // 시식 추상화
        // Food를 상속받은 크래스에서 이 메소드를 구체화 해야 함
        // 음식마다 시식하는 방법은 다 다르기 때문

    }
}
