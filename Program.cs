

using System.Security;

namespace LabOOP
{

    class Program
    {
        public static void Main(string[] args)
        {
            ListedList list = new ListedList();

            ListedList newList = new ListedList();
            list.AddFirst(5);
            list.AddFirst(4);
            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);
            list.PrintList();

            Console.WriteLine(list.FirstTask);


            Console.WriteLine(list.SecondTask(2));


            newList = list.ThirdTask();
            newList.PrintList();

            list.FouthTask();
            list.PrintList();

        }
    }

    class Node
    {
        
        public double Value { get; set; }

        public Node Next { get; set; }
    }

    class ListedList
    {

   
        public Node Head { get; set; }

        public void AddFirst(double data)
        {
            Node newNode = new Node() { Value = data };

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }

        public double FirstTask()
        {
            Node current = Head;
            double sum = 0;
            int count = 0;
            double neededValue = 0;

            while (current != null)
            {
                sum += current.Value;
                count++;
                current = current.Next;
            }

            if (count > 0)
            {
                double averageValue = sum / count;

                current = Head; 
                while (current != null)
                {
                    if (current.Value > averageValue)
                    {
                        neededValue = current.Value;
                        break;

                    }
                    current = current.Next;

                }
            }
            return neededValue;
        }

        public double SecondTask(double taskValue)
        {
            double sum = 0;
            Node current = Head;
            while (current != null)
            {
                if(current.Value > taskValue)
                {
                    sum += current.Value;
                }
                current = current.Next;
            }

            return sum;
        }

        public ListedList ThirdTask()
        {
            double sum = 0;
            int count = 0;
            ListedList list = new ListedList();
            Node current = Head;

            while(current != null)
            {
                sum += current.Value;
                count++;
                current = current.Next;
            }

            if (count > 0)
            {
                double averageValue = sum / count;

                current = Head;
                while (current != null)
                {
                    if (current.Value < averageValue && current.Value != averageValue)
                    {
                        list.AddFirst(current.Value);

                    }
                    current = current.Next;

                }
            }
            return list;
        }

        public void FouthTask()
        {
            if(Head == null || Head.Next == null)
            {
                return;
            }

            Node previous = null;
            Node current = Head;
            int index = 0;

            while (current != null)
            {
                if(index%2 == 0)
                {
                    if(previous!= null)
                    {
                        previous.Next = current.Next;
                    }
                    else
                    {
                        Head = current.Next.Next;
                    }
                }
                previous = current;
                current = current.Next;
                index++;
            }

        }

        public void PrintList()
        {
            Node current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}
