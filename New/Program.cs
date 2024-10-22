using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace New
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Student student=new Student("kanan",55);
            Group group =new Group("Bp-215",6);
            User user = new User();
            user.FullName = "fariz eyyubov";
            user.Email = "fariz.E@mail.ru";
            user.AddUser(user);
            student.ShowInfo();
        }

    }

}













