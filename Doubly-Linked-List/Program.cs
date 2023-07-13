namespace Doubly_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            DLinkedList<int> doublyList = new DLinkedList<int>();

            doublyList.AddEnd(34);
            doublyList.AddBeginning(5);
            doublyList.AddBeginning(10);
            doublyList.AddBeginning(15);
            doublyList.DeleteBack();
            doublyList.AddBeginning(2);
            doublyList.AddBeginning(8);

            doublyList.PrintListForward();

            System.Console.WriteLine();

            doublyList.PrintListBackward();
        }

    }
}




