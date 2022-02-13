using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor2_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            User Vasylyna = new User("teri@gmail.com", "Vasylyna", "Zlenko", 19);

            (string login, string name, string lastName, int age) = Vasylyna;

            DateTime thisDate1 = new DateTime(2022, 2, 13, 13, 44, 0, DateTimeKind.Local);


            Console.WriteLine("Анкета 1:\n" +
                $"Логiн: {login}\n" +
                $"Iм'я: {name}\n" +
                $"Прiзвище: {lastName}\n" +
                $"Вiк: {age}\n"+
                "Час створення анкети: {0:dd/MM/yy H:mm zzz}", thisDate1);
            Console.WriteLine(" \n" +
                "===============\n" +
                " ");

            User Jane = new User("aaaaa@gmail.com", "Jane", "Lock", 13);

            (string jlogin, string jname, string jlastName, int jage) = Jane;

            DateTime thisDate2 = new DateTime(2022, 2, 13, 14, 06, 0, DateTimeKind.Local);


            Console.WriteLine("Анкета 2:\n" +
                $"Логiн: {jlogin}\n" +
                $"Iм'я: {jname}\n" +
                $"Прiзвище: {jlastName}\n" +
                $"Вiк: {jage}\n" +
                "Час створення анкети: {0:dd/MM/yy H:mm zzz}", thisDate2);
            Console.ReadKey();
                              

        }
    }
}
