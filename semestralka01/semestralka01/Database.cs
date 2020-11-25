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

        /*
        public static BindingList<Table> Table1 { get; private set; } = new BindingList<Table>();
        public static BindingList<Table> Table2 { get; private set; } = new BindingList<Table>();
        public static BindingList<Table> Table3 { get; private set; } = new BindingList<Table>();
        public static BindingList<Table> Table4 { get; private set; } = new BindingList<Table>();
        public static BindingList<Table> Table5 { get; private set; } = new BindingList<Table>();*/
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



            //Table2.Add(new Table(2,"table2",true));

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

