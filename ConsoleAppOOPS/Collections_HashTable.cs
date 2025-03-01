using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleAppOOPS
{
    class Collections_HashTable
    {
        static void Main()
        {
            //If you want to store Homogeneous type of data - prefer Array
            //If you want to store Heterogeneous type of data - prefer ArrayList OR List<object> for good performance
            //HashTable not that much flexible like that of ArrayList.
            //Advantage is Hashing algorithm: In Hashtable, to store & retrieve the data it uses Hashing Algorithm.
            //Another advantage is index is User-defined unlike Array, ArrayList.
            Hashtable ht = new Hashtable();
            ht.Add("eno", 1000);//(key, value) Key is like user-defined index.
            ht.Add("ename", "vamsi");
            ht.Add("sal", 75000);
            ht.Add("Role", "Project engg");

            //Prefer Hashtable only when you want user-defined index.
            //AddRange, is not available for Hashtable because we need to give Index also.
            //Bcs, while storing it follows hashing algorithm, it won't support.  
            //Insert(), InsertRange(), RemoveAt(), RemoveRange() also not available.
            //For Remove() we specify key instead of element.

            //To access data in Hashtable, we need key.
            foreach (var key in ht.Keys)//Storing, retriving, removing done using Keys.
                Console.WriteLine(key + " - "+ht[key]);//ht is object of HashTable, key is key. using key, we are getting data. Directly we can't fetch this is security.
            /*Output:
            eno - 1000
            sal - 75000
            Role - Project engg
            ename - vamsi
            *Output order is different than Input. This is Hashing algo, it stores in different order not like how we enter the data.
            
            What is hashing algorithm in C#?
            Hashing in cryptography is a process of mapping a binary string of an arbitrary length to a small binary string of a fixed length, known as a hash value, a hash code, or a hash. 

            What is ht.Keys: HT takes key - value. Array/ AL have pre-defined integer index associated with data. ht.Keys is index for ht HashTable.
            In Arrays/ AL: al[1]/ al[2] we use
            ///y in HT: ht[key] we use
            */

            //We can get the HashCode of any variable.
            int a = 100;
            Console.WriteLine("Hash code of int a: " + a.GetHashCode());//Every variable is having some HashCode. 
            int eno = 1000; string ename = "Lokesh"; int sal = 75000; string role = "Project engg";
            Console.WriteLine("Hash code of eno: " + eno.GetHashCode() + 
                "\nHash code of ename: " + ename.GetHashCode() +
                "\nHash code of sal: " + sal.GetHashCode() +
                "\nHash code of role: " + role.GetHashCode());
            //Hashing algorithm will applied to that Hash code, based on that it store in the Hash table [Ascending order of HashCode].
            foreach (var key in ht.Keys)
                Console.WriteLine(key + " - " + ht[key].GetHashCode());


            ht.Remove("eno");//It expects 'key' not value.
            Console.WriteLine("Data after removing eno and its value:");
            foreach (DictionaryEntry item in ht)
                Console.WriteLine("{0} - {1} ", item.Key, item.Value);
            //The elements of hashtable that is a key/value pair are stored in DictionaryEntry, so you can also cast the key/value pairs to a DictionaryEntry.

            Console.WriteLine("Total number of elements present" +" in hashtable:{0} before Clear()", ht.Count);//Before Clear()
            ht.Clear();
            Console.WriteLine("Total number of elements present" + " in hashtable:{0} after Clear()", ht.Count);//After Clear()
            //In Hashtable, the key can't be null, but value can be.
            //key objects must be immutable [key must be unique. Duplicate keys are not allowed]
            //The elements of hashtable that is a key/value pair are stored in DictionaryEntry, so you can also cast the key/value pairs to a DictionaryEntry.

            /*Methods & Properties of Hashtable:
            ht.Add();
            ht.Count;
            ht.Keys;
            ht.Remove(); used to remove all objects from the hashtable.
            ht.Clear(); used to remove the element with the specified key from the hashtable
            ht.GetHash(); But it is protected method. So, use GetHashCode() method. It returns integer Hash code.
            */

            /*In hashtable, you can check whether the given pair is present or not using the following methods:
            Contains: This method is used to check whether the Hashtable contains a specific key.
            ContainsKey: This method is also used to check whether the Hashtable contains a specific key.
            ContainsValue: This method is used to check whether the Hashtable contains a specific value.
            */
        }
    }
}
