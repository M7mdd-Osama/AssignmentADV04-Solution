using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HashSet
            //HashSet<int> set = new HashSet<int>();

            //set.Add(1);
            //set.Add(2);
            //set.Add(2); //elements must be Unique
            //set.Add(3);
            //set.Add(4);
            ////set.Clear();
            //foreach (int s in set)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion

            #region Dictionary
            //Dictionary<string, int> Phonebook = new Dictionary<string, int>();
            //Phonebook.Add("Mohamed", 1);
            //Phonebook.Add("Omar", 2);
            //Phonebook.Add("Ahmed", 3);
            //Phonebook["Ahmed"] = 0;
            //Phonebook["Ali"] = 324;
            //if (!Phonebook.ContainsKey("Mohamed"))
            //    Phonebook.Add("Mohamed", 222);
            //else
            //    Phonebook["Mohamed"] = 245;

            //Phonebook.TryAdd("Omar", 111);

            //if (!Phonebook.TryAdd("Ali", 333))
            //    Phonebook["Ali"] = 342;

            //Phonebook.TryGetValue("Mohamed", out int R);
            //Console.WriteLine(R);
            //foreach (KeyValuePair<string, int> Person in Phonebook)
            //{
            //    Console.WriteLine(Person);
            //}

            #endregion

            #region Var
            ////var X = null;
            //var X = "zz";
            //X = null;

            ////var Y; 
            #endregion
            #region dynamic
            //dynamic Z;
            //Z = "Ali";
            //Z = 22;
            //Z = null;
            //Z = 2.2;
            //Console.WriteLine(Z);
            #endregion

            #region Extention Method
            //int X = 243453;
            //int Y = X.Reverse();
            //Console.WriteLine(Y); 
            #endregion

            #region Anonymous Type
            //var Emp01 = new { Id = 1, Name = "Mohamed", Salary = 2000 };
            //Console.WriteLine(Emp01.GetType().Name); //AnonymousType0`3
            //var Emp02 = new { Id = Emp01.Id, Name = "Ahmed"};
            //Console.WriteLine(Emp02.GetType().Name); //AnonymousType1`2

            //var Emp03 = Emp01 with { Id = 5 };
            //Console.WriteLine(Emp03.GetType().Name); //AnonymousType0`3
            //Console.WriteLine(Emp03);          
            #endregion



        }
    }
}
