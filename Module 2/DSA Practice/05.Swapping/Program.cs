using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Swapping
{
    class ListNode : IEnumerable<int>
    {
        private int value;
        private ListNode left;
        private ListNode right; //с right връзките правим swap-ването
        //new syntax doesnt work:
        //public ListNode Left => left;   //един getter за left
        //public ListNode Right => right; //един getter за right
        public ListNode Left
        {
            get { return left; }
        }

        public ListNode Right
        {
            get { return right; }
        }
        //public int Value => value;  //getter за value

        public ListNode(int v)
        {
            this.value = v;
            this.left = null;
            this.right = null;
        }

        public void Link(ListNode r)    //взима нодеа и закача нов отдясно
        {
            right = r; //нашия десен е този който получаваме
            r.left = this;//този който получаваме ние ще сме му левия елемент

        }

        public void Detach()
        {
            if (this.left != null)
            {
                this.left.right = null;
                this.left = null;
            }
            if (this.right != null)
            {
                this.right.left = null;
                this.right = null;
            }
            
            
        }

        public IEnumerator<int> GetEnumerator()
        {
            //трябва да обхожда всички елементи от ляво на дясно
            var node = this;
            while (node != null)
            {
                yield return node.value; //връща текущия елемент. текущият елемент има стойност value
                node = node.right;
            }

            //може и с рекурсия
            //yield return value;
            //дъно:
            //foreach(var next in right)
            //{
            //  yield return next;
            //}
            //return right.GetEnumerator();
            // само, че ще стане с квадратна сложност
            //yield return 1:01:00 https://www.youtube.com/watch?v=0SwUyEyAP7E&t=1883s
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();//return горното за backwards compatibility
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //вграденият свързан списък е леко безполезен за тази задача,
            //защото има readonly property-та
            //var list = new LinkedList<int>();
            //list.AddAfter()
            var n = int.Parse(Console.ReadLine());
            var nodes = Enumerable.Range(0, n + 1)
                .Select(x => new ListNode(x))
                .ToArray();  //индекса на масива отговаря на стойността, която отива в node-a

            for (int i = 1; i < n; i++) // без равно за да не излиза i+ 1 от масива
            {
                nodes[i].Link(nodes[i + 1]);
            }
            var first = nodes[1];
            var last = nodes[n];

            Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList()
                .ForEach(number =>
                {
                    var newLast = nodes[number].Left;
                    var newFirst = nodes[number].Right;

                    nodes[number].Detach();//това е ноде-а константно защото сме го запазили в масив
                    if (last != nodes[number])
                    {
                        last.Link(nodes[number]);
                    }
                    
                    else
                    {
                        newFirst = nodes[number];
                    }

                    if (first != nodes[number])
                    {
                        nodes[number].Link(first);
                    }
                    else
                    {
                        newLast = nodes[number];
                    }

                    first = newFirst;//update=ваме first и last защото ще ни трябват на следващата стъпка
                    last = newLast;
                });
            Console.WriteLine(string.Join(" ", first));//за да ползваме string.Join трябва ноде-овете да са ни IEnumerable
        }
    }
}
