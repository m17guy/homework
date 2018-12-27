using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace links
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex 1
            var students = new[] { new { name = "guy",age=22, gender="m"},
            new { name = "noy",age=21, gender="f"},
            new { name = "ruven",age=20, gender="m"}};
            var onlyM = students.Where(s => s.gender == "m").OrderByDescending(x => x.age).Select(stud => new { name = stud.name, age = stud.age });
            foreach (var student in onlyM)
            {
                Console.WriteLine(student.name + " is " + student.age);
            }


            Console.WriteLine("***********************");

            
            //ex 2
            List<renter> renters = new List<renter>
            {
                new renter() { name = "guy", id = 1 },
                new renter() { name = "ruven", id = 2 },
                new renter() { name = "noy", id = 3 },
                new renter() { name = "cait", id = 4 },
                new renter() { name = "giora", id = 5 }
            };
            List<apartmint> myaparts = new List<apartmint>
            {
                new apartmint()
                {
                    addres ="1,a,zz",review=new string[] {"its nice","grea"}, renterid= 1
                },
                new apartmint()
                {
                    addres ="45,yk",review=new string[] {"small","cozy"}, renterid= 2
                },
                new apartmint()
                {
                    addres ="32,e,zpo",review=new string[] {"smalls like weed all the time"}, renterid= 4
                }
            };
            var rentinaddres = renters.Join(myaparts,
                renter => renter.id,
                apartmint => apartmint.renterid,
                (rent, apart) => new { name = rent.name, addres = apart.addres });
            foreach (var ap in rentinaddres)
            {
                Console.WriteLine(ap.name+" lives at "+ap.addres);
            }
            


            Console.WriteLine("***********************");

            //ex 3
            List<person> people = new List<person>
            {
                new person(){name="guy",id=1,bday="123",ismale=true,motherid=2,fatherid=-1},
                new person(){name="sharon",id=2,bday="143",ismale=false,motherid=-1,fatherid=3},
                new person(){name="martin",id=3,bday="23",ismale=true,motherid=-1,fatherid=-1},
                new person(){name="baruh",id=4,bday="133",ismale=true,motherid=-1,fatherid=3},
                new person(){name="ruven",id=5,bday="195",ismale=true,motherid=6,fatherid=4},
                new person(){name="raily",id=6,bday="111",ismale=false,motherid=-1,fatherid=-1},
                new person(){name="noy",id=7,bday="742",ismale=false,motherid=43,fatherid=77}
            };
            var fathers = people.Join(people,
                person => person.id,
                person => person.fatherid,
                (father, sun) => new { fname = father.name, sname = sun.name });
            foreach (var pep in fathers)
            {
                Console.WriteLine(pep.fname+" is the father of "+pep.sname);
            }



            Console.WriteLine("***********************");

            //ex 4 using my people list from ex 3
            List<animelfood> foods = new List<animelfood>
            {
                new animelfood("fuckos","joke inc"),
                new animelfood("shitty stuff","evil.co"),
                new animelfood("its ok","evil.co")
            };
            List<pet> pets = new List<pet>
            {
                new pet("mo","dog",8,1,"fuckos"),
                new pet("dvash","dog",90,6,"its ok"),
                new pet("mama","cat",12,3,"shitty stuff")
            };
            var handelers = people.Join(pets,
                person => person.id,
                pet => pet.onerid,
                (pep, anm) => new { owner = pep, theanimal = anm });
            var allthree = handelers.Join(foods,
                handeler => handeler.theanimal.favoretfood,
                animelfood => animelfood.name,
                (two, food) => new { owner = two.owner, anim = two.theanimal, thefood = food });
            foreach (var info in allthree)
            {
                Console.WriteLine(info.owner.name + " is the owner of " + info.anim.name +
                    " the " + info.anim.type + " who's favoret food is " + info.thefood.name);
            }
        }
    }
    class animelfood
    {
        public string name;
        public string perontcompony;

        public animelfood(string name, string perontcompony)
        {
            this.name = name;
            this.perontcompony = perontcompony;
        }
    }
    class pet
    {
        public string name;
        public string type;
        public int age;
        public int onerid;
        public string favoretfood;

        public pet(string name, string type, int age, int onerid, string favoretfood)
        {
            this.name = name;
            this.type = type;
            this.age = age;
            this.onerid = onerid;
            this.favoretfood = favoretfood;
        }
    }
    class person
    {
        public string name { get; set; }
        public int id;
        public string bday;
        public bool ismale;
        public int motherid;
        public int fatherid;
    }
    class renter
    {
        public string name;
        public int id;
    }
    class apartmint
    {
        public string addres;
        public string[] review;
        public int renterid;
    }
}
