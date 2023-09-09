using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tech_Share_Laptop_Distribution.BL;

namespace Tech_Share_Laptop_Distribution.DL
{

    public static class EmployeeDL
    {
        public static List<EmployeeBL> EmployeesList = new List<EmployeeBL>();
        private class Node
        {

            internal EmployeeBL Value;
            internal Node next;
            internal Node prev;

            public Node(EmployeeBL value, Node prev, Node next)
            {
                this.Value = value;
                this.prev = prev;
                this.next = next;
            }
        }
        // The pointer to the linklist
        private static Node head;

        // The counter of the number of elements in the list
        private static int counter = 0;


        /*
         The Function to put a vlue at the start of the LinkList
         Time complexity: O(1).
        */

        public static void Insert(EmployeeBL value)
        {
            Node new_Node = new Node(value, null, Head);
            if (Head != null)
                Head.prev = new_Node;
            Head = new_Node;
            counter++;
        }

        /*  
            Method that deletes all the elements in the list. 
            Time complexity: O(1)
        */
        public static bool ClearList()
        {
            if (counter == 0)
            {
                return false;
            }

            /*  Set the pointer of the head to the null, and the counter to 0.
                The garbage collector in C# will take care of the rest of the
                elements left in the memory */
            Head = null;
            counter = 0;
            return true;
        }

        /*  
            Check if the value given in the parameter is already in the list or not
            Time complexity: O(n)
        */
        public static bool ContainsEmail(EmployeeBL value)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (Equals(temp.Value.Email, value.Email))
                {
                    return false;
                }
                temp = temp.next;
            }
            return true;
        }
        public static bool ContainsName(EmployeeBL value)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.Value.Name == value.Name)
                {
                    return false;
                }
                temp = temp.next;
            }
            return true;
        }
        public static bool ContainsCNIC(EmployeeBL value)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (Equals(temp.Value.Cnic, value.Cnic))
                {
                    return false;
                }
                temp = temp.next;
            }
            return true;
        }
        public static bool ContainsNumber(EmployeeBL value)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (Equals(temp.Value.Phone_no, value.Phone_no))
                {
                    return false;
                }
                temp = temp.next;
            }
            return true;
        }
        /*  
            Function will return the index the element if it is found present in the linklist 
            Time complexity: O(n)
        */
        public static int GetIndex(EmployeeBL value)
        {
            Node temp = Head;
            for (int i = 0; i < counter; i++, temp = temp.next)
            {
                if (Equals(temp.Value, value))
                {
                    return i;
                }
            }
            // If the element is not in the list, return -1
            return -1;
        }

        /*  
            Get the number of element in the LinkList.
        */
        public static int length
        {
            get
            {
                return counter;
            }
        }

        private static Node Head { get => head; set => head = value; }


        /*  
            Delete the value in the linklist by comparing it with the value in the parameter
            Time complexity: O(n).
        */
        public static EmployeeBL DeleteByValue(EmployeeBL value)
        {
            // If list is empty, throw an exception
            if (Equals(Head, null))
            {
                throw new InvalidOperationException("Error! Cannot delete from an empty list!");
            }

            // Declare a container variable for the value of the EmployeeBL
            EmployeeBL toBeDeleted;

            // If the element that should be deleted is the first element in the list
            if (Equals(Head.Value, value))
            {
                toBeDeleted = Head.Value;
                Head = Head.next;
                counter--;
                return toBeDeleted;
            }

            // Initialize a temporary element that will be used to iterate through the list
            Node temp = Head;

            // Iterate through the list, searching for the element that is to be deleted
            while (temp.next != null)
            {
                // If the value of the current element is the same as the specified value
                if (Equals(temp.next.Value, value))
                {
                    // Move the pointers
                    toBeDeleted = temp.next.Value;
                    temp.next = temp.next.next;
                    temp.prev = temp;
                    // Decrease the number of elements in the list
                    counter--;
                    // Return the value of the deleted element
                    return toBeDeleted;
                }
                // Go to the next element
                temp = temp.next;
            }

            // If the specified value of the element is not found
            return null;
        }
        /*  
            Delete the value in the linklist at the specific index given
            Time complexity: O(n).
        */
        public static EmployeeBL DeleteByIndex(int index)
        {
            if (index >= counter || index < 0)
            {
                throw new IndexOutOfRangeException("Error! Specified index was outside the bounds of the list!");
            }
            EmployeeBL toBeDeleted_Value;

            if (index == 0)
            {
                toBeDeleted_Value = Pop();
                return toBeDeleted_Value;
            }
            Node temp = Head;
            int i = 0;
            while (temp.next != null && i < index - 1)
            {
                temp = temp.next;
                i++;
            }
            toBeDeleted_Value = temp.next.Value;
            temp.next = temp.next.next;
            counter--;
            return toBeDeleted_Value;
        }
        /*  
            Method used to delete the first element of the LinkList
            Time complexity: O(1).
        */
        public static EmployeeBL Pop()
        {
            if (counter == 0)
            {
                throw new InvalidOperationException("Error! Trying to delete from an already empty list!");
            }

            // initialize a temporary container variable
            EmployeeBL toBeDeleted = Head.Value;

            // If there is only one element in the list
            if (counter == 1) Head = null;
            // If there is more than one element in the list
            else Head = Head.next;

            // Decrease the number of elements in the list by one
            counter--;
            // Return the value of the deleted element
            return toBeDeleted;
        }

        /*  
            Method used to add value at the end of the linklist
            Time complexity: O(n).
        */
        public static void InsertAtEnd(EmployeeBL value)
        {
            if (Equals(Head, null))
            {
                Insert(value);
                return;
            }
            Node temp = Head;
            Node newNode = new Node(value, null, null);
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
            newNode.prev = temp;
            counter++;
        }

        /*  
            Method used to swap the one element of the LinkList with the other
        */
        public static bool Swap(int first, int second)
        {
            if (first >= counter || second >= counter || first < 0 || second < 0)
            {
                throw new IndexOutOfRangeException("Error! One of the specified indexes was outside the bounds of the list!");
            }

            Node firstElem = Head;
            Node secondElem = Head;

            // Find the first element
            while (first != 0)
            {
                firstElem = firstElem.next;
                first--;
            }
            // Find the second element
            while (second != 0)
            {
                secondElem = secondElem.next;
                second--;
            }

            // Swap the values of the elements
            EmployeeBL temp = firstElem.Value;
            firstElem.Value = secondElem.Value;
            secondElem.Value = temp;

            // Return true if the values of the elements are swapped
            return true;
        }


        public static void Print()
        {
            // // Initialize the temporary Node object used for iterating through the list
            Node temp = Head;

            // Iterate through the list
            while (temp != null)
            {
                // Print the value of the current element
                Console.Write($"{temp.Value.Name} ");
                // Go to the next element
                temp = temp.next;
            }
        }
        public static void storeincsv()
        {
            Node temp = Head;
            string path = "EmployeesData.csv";
            StreamWriter f = new StreamWriter(path);
            // Iterate through the list
            while (temp != null)
            {
                f.WriteLine(temp.Value.Name + ',' + temp.Value.Cnic + ',' + temp.Value.Email + ',' + temp.Value.Phone_no + ',' + temp.Value.Adress + ',' + temp.Value.Salary + ',' + temp.Value.Gender);
                // Go to the next element
                temp = temp.next;
            }
            f.Flush();
            f.Close();
        }
        public static void DeleteEmployee(EmployeeBL employee)
        {
            for (int i = 0; i < EmployeesList.Count; i++)
            {
                if (employee.Name == EmployeesList[i].Name)
                {
                    EmployeesList.Remove(EmployeesList[i]);
                }
            }
        }


        public static void LoadFromCSV()
        {
            ClearList();
            EmployeesList.Clear();
            string path = "EmployeesData.csv";
            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                {
                    string Name;
                    string Cnic;
                    string Email;
                    string Phone_no;
                    string Address;
                    long salary;
                    string gender;
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        Name = values[0];
                        Cnic = values[1];
                        Email = values[2];
                        Phone_no = values[3];
                        Address = values[4];
                        salary = int.Parse(values[5]);
                        gender = values[6];
                        EmployeeBL temp = new EmployeeBL(Name, Cnic, Email, Phone_no, Address, salary, gender);
                        EmployeesList.Add(temp);
                        InsertAtEnd(temp);
                    }
                }
            }
        }

        public static void addintofileList()
        {
            string path = "EmployeesData.csv";
            StreamWriter f = new StreamWriter(path);

            foreach (EmployeeBL i in EmployeesList)
            {
                f.WriteLine(i.Name + "," + i.Cnic + "," + i.Email + "," + i.Phone_no + "," + i.Adress + "," + i.Salary + "," + i.Gender);
            }
            f.Flush();
            f.Close();
        }

        public static bool updateInfo(EmployeeBL temp)
        {
            Node Temp = Head;

            // Iterate through the list
            while (Temp != null)
            {
                if (Temp.Value.Name == temp.Name)
                {
                    Temp.Value.Cnic = temp.Cnic;
                    Temp.Value.Email = temp.Email;
                    Temp.Value.Phone_no = temp.Phone_no;
                    Temp.Value.Adress = temp.Adress;
                    Temp.Value.Salary = temp.Salary;
                }
                Temp = Temp.next;
            }
            foreach (EmployeeBL i in EmployeesList)
            {
                if (i.Name == temp.Name)
                {
                    i.Cnic = temp.Cnic;
                    i.Email = temp.Email;
                    i.Phone_no = temp.Phone_no;
                    i.Adress = temp.Adress;
                    i.Salary = temp.Salary;
                    return true;
                }
            }
            return false;
        }

    }
}
