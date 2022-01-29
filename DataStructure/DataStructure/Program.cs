// See https://aka.ms/new-console-template for more information
using DataStructure;
LinkedList customLinkedList = new LinkedList();
customLinkedList.AddLast(56);
customLinkedList.AddLast(30);
customLinkedList.AddLast(76);
Console.WriteLine("nodes inserted");
customLinkedList.DisplayLinkedList();

customLinkedList.AddFirst(70);
customLinkedList.AddFirst(30);
customLinkedList.AddFirst(56);
customLinkedList.DisplayLinkedList();
