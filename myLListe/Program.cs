namespace myLListe
{
    class Program
    {
        static void Main(string[] args)
        {
            myLinkedList myList = new myLinkedList();
            myList.addFirst(192);
            myList.addFirst(12);
            myList.addFirst(29);
            myList.addFirst(3);
            // myList.removeFirst();
            myList.addLast(101010);
            myList.showData();
            
            //  Console.WriteLine("Last element: " + myList.getLast().Item);
            //  Console.WriteLine("First element: " + myList.getFirst().Item);
            myList.insertAfter(2020, 12);
            // Console.WriteLine("Last element: " + myList.getLast().Item);
            myList.removeElement(29);
            myList.showData();
        }
    }
}
