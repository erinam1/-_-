using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зарплата_ФИО
{
    public class Работник
    {
        readonly int рабНом;
        string фио;
        string адрес;
        public Работник(int рабНом, string фио, string адрес)
        {
            this.рабНом = рабНом;
            this.фио = фио;
            this.адрес = адрес;
        }
        public string ФИО
        {
            get { return фио; }
            set { фио = value; }
        }
        public string Address
        {
            get { return адрес; }
            set { адрес = value; }
        }
        public int РабНом
        {
            get { return рабНом; }
        }
    }
}
