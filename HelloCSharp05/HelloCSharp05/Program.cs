using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp05
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Animal a = new Animal(); // 안됨
            Animal c = new Cat();
            Animal d = new Dog();
            Animal b = new Bulbasaur();

            Cat c1 = new Cat();
            Dog d1 = new Dog();
            Bulbasaur b1 = new Bulbasaur();

            // 인터페이스로도 생성 가능
            IPlant p = new Bulbasaur();
            IPokemon p2 = new Bulbasaur();

            b1.ability = "심록";
            b1.name = "상해";
            b1.age = 5;
            b1.description = "고집있음";
            Console.WriteLine(b1.age);
            b1.age = -5;
            Console.WriteLine(b1.age);
            b1.bearFruit();
            b1.sleep();
            b1.eat();
            b1.cry();
            b1.blooming();
            b1.charming();
            b1.photosynthesis();
            b1.fight();

            c1.eat();
            c1.cry();

            Bulbasaur i1 = new Ivysaur();
            IPokemon i2 = new Ivysaur();
            Ivysaur i = new Ivysaur();
            IPlant i3 = new Ivysaur();

            i.cry();
            i.fight();
            Console.WriteLine();
            Console.WriteLine();
            Venusaur v = new Venusaur();
            v.bearFruit();
            v.sleep();
            v.eat();
            v.cry();
            v.blooming();
            v.charming();
            v.photosynthesis();
            v.fight();
            Console.WriteLine();
            Console.WriteLine();

            GoldDragon g = new GoldDragon();
            g.polymorp("이동준");
            g.sayHello();
            g.castMagic("흑염구");
            g.fly();

        }
    }
}
