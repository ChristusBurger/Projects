using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace semestralka01
{
   public static class Database
    {
        public static BindingList<User> Users { get; private set; } = new BindingList<User>();
        public static BindingList<Order> Storage { get; private set; } = new BindingList<Order>();
        public static BindingList<Table> Tables { get; private set; } = new BindingList<Table>();

        //LOGIN heslo atd
        public static void PasswordCheck(string username)
        {
          
            
        }
        

        public static void Init()
        {
            Users.Add(new User("JankoPanko", "jankopanko", false));
            Users.Add(new User("admin","admin",true));

            Storage.Add(new Food("paras", 15, 200, 1200));
            Storage.Add(new Food("sekec", 35, 200, 1500));
            Storage.Add(new Food("tatranka", 10, 500, 800));
            Storage.Add(new Beer("Branicek",25,10000,"pivo","4.8%"));
            Storage.Add(new Beer("Brunclik", 15, 10000, "patok", "4.2%"));
            Storage.Add(new Beer("Plznicka", 45, 10000, "pivicko", "4.4%"));
            Storage.Add((new Wine("Portske",30,700,"silne","17%")));
            Storage.Add((new Wine("Klokanek", 20, 700, "bile", "12%")));
            Storage.Add((new Wine("SkelpMistr", 15, 700, "cervene", "12.5%")));

            Tables.Add(new Table(1, "Table1", false));
            Tables.Add(new Table(2, "Table2", false));
            Tables.Add(new Table(3, "Table3", false));
            Tables.Add(new Table(4, "Table4", false));
            Tables.Add(new Table(0, "TableQuickOrder", false));


            Food food = new Food("paras", 15, 1, 1200);
            Table table1 = new Table(420,"testTable",true);
            table1.TableOrders.Add(food);
            Tables.Add(table1);

            /*  Zakaznici.Add(new Zakaznik("Pepa", "Novy", 1998));
            Zakaznici.Add(new Zakaznik("Alois", "Stary", 1978));

            Zakaznik z = new Zakaznik("Pepa", "Dlouhy", 2009);
            z.Vypujcky.Add(cd);
            Zakaznici.Add(z);*/
        }

        public static void Serialize()
        {
            Serialize(Users, "Users.xml");
        }

        public static void Serialize<T>(BindingList<T> list, string file)
        {

            using (Stream s = File.Open(file, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(BindingList<T>));

                XmlWriter writer = new XmlTextWriter(s, Encoding.UTF8);

                serializer.Serialize(writer, list);
            }
        }

        public static void Deserialize()
        {
          Users = Deserialize<User>("Users.xml");
        }

        public static BindingList<T> Deserialize<T>(string file)
        {
            using (Stream s = File.Open(file, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(BindingList<T>));
                return (BindingList<T>)serializer.Deserialize(s);
            }

        }
    }
   

  

}

