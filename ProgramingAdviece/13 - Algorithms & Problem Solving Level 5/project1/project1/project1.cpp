
#include <iostream>
#include<string>
using namespace std;
#include"clsDbLinkedList.h"
#include"clsMyQueue.h"
#include"clsMyStack.h"
#include"clsDynamicArray.h"
#include"clsMyQueueArr.h"
#include"clsMYstackArr.h"
#include"clsMyString.h"
#include"clsQueueLine.h"
//main ideat is compaination and inheretinc
int main()
{
   

    #pragma region  clsdoubllinkedlist
    //clsDbLinkedList<int> doubleLinkedList;
    //doubleLinkedList.insertAtBeginning(5);
    //doubleLinkedList.insertAtBeginning(4);
    //doubleLinkedList.insertAtBeginning(3);
    //doubleLinkedList.insertAtBeginning(2);
    //doubleLinkedList.insertAtBeginning(1);

    //doubleLinkedList.printList();

    //clsDbLinkedList<int>::node* n=doubleLinkedList.find(2);
    //if (n != NULL) {
    //    cout << "\n\nwe found node:-) "<<n->value << endl;
    //}
    //else {
    //    cout << "node not found:-(" << endl;
    //}

    //cout << "\n\ninsert aftar operation:(2::2222)" << endl;
    //doubleLinkedList.insertAfter(2, 2222);
    //doubleLinkedList.printList();

    //cout << "\n\ninsert at end operation:6" << endl;
    //doubleLinkedList.insertAtEnd(6);
    //doubleLinkedList.printList();

    //clsDbLinkedList<int>::node* d = doubleLinkedList.find(2222);
    //cout << "\n\ndelete node:"<<d->value << endl;
    //doubleLinkedList.deleteNode(d);
    //doubleLinkedList.printList();

    //cout << "\n\ndelete frist node:" << endl;
    //doubleLinkedList.deleteFristNode();
    //doubleLinkedList.printList();

    //cout << "\n\n delete last node:" << endl;
    //doubleLinkedList.deleteLastNode();
    //doubleLinkedList.printList();


   
    //if (doubleLinkedList.isEmpty()) {
    //    cout << "\n\nthe list is empty:\n";
    //}
    //else {
    //    cout << "\n\nlist not empty\n";
    //}
    //cout << "the size of double linked list is:"
    //    << doubleLinkedList.size();

   

    ///*doubleLinkedList.clear();
    //cout << "\n\nafter exiscut clear:\n";
    //cout << "\nthe linked list:";doubleLinkedList.printList();
    //cout << "\nthe size of double linked list is:"<< doubleLinkedList.size();*/

    //doubleLinkedList.Reverse();
    //cout << "\n\nrevers :";
    //doubleLinkedList.printList();
    //  
    //doubleLinkedList.Reverse();
    //cout << "\n\nrevers :";
    //doubleLinkedList.printList();



    //   cout << "\n\nthis is  get index 5 out or range:\n";
    //   
    //   n = doubleLinkedList.getNode(5);
    //   if (n != nullptr) {

    //   cout << "this is value:" <<  n->value<<endl;
    //   }
    //   else {
    //       cout << "there is no value:";
    //   }

    //   
    //   short index = 4;
    //   cout << "\n\n this is get item of index:" << index << endl;
    //   cout << "the value of item:" << doubleLinkedList.getItem(index) << endl;
    //   
    //   
    //   
    //   doubleLinkedList.printList();
    //   cout << "\n\n this is update item in index 0 by 1000:";
    //   doubleLinkedList.updateItem(0, 1000);
    //   doubleLinkedList.printList();

    //  doubleLinkedList.insertAfter(1, 2222);
    //  cout << "\n\nafter insert after index 1 value 2222:\n";
    //  doubleLinkedList.printList();

#pragma endregion
     
  
    #pragma region  myQueue
     /* clsMyQueue<int> queue;
      queue.push(10);
      queue.push(2);
      queue.push(3);
      queue.push(63);
      queue.push(21);
      queue.push(3123);
      queue.print();
      queue.pop();
      cout << endl << endl;
      queue.print();
      
      cout << "\n\n the size:" << queue.size();
      cout << "\n\n the frist emlemten:" << queue.front();
      cout << "\n\n the last emlemten:" << queue.back();
      
      if (queue.isEmpty()) {
          cout << "\nthe queue is empty:";
      }
      else {
          cout << "\nnot empty;";
      }
      
      cout << endl << endl;
      queue.print();
      cout << "\nthis is item you want in index 7:" << queue.getItem(7);

      cout << "\n\nthis is queue after revers:"; queue.reverse();
      queue.print();
      cout << endl << endl;

      cout << "\nthis is quew after update item in index 2 by 2000:";
      queue.updateItem(2, 2000);
      queue.print();
      cout << endl << endl;


      cout << "\nthis is queue after insert after item ind index 2 by 3000:";
      queue.insertAfter(2, 3000);
      queue.print();
      cout << endl << endl;


      cout << "\nthis is queue after insert at front and back:";
      queue.insertAtFront(1);
      queue.insertAtBack(10000);
      queue.print();
      cout << "\n\n";


      cout << "this is empty queue aftere clear:"; queue.clear();
      queue.print();*/

#pragma endregion
    

    #pragma region myStack

      //clsMyStack<int> stack;
      //stack.push(10);
      //stack.push(9);
      //stack.push(8);
      //stack.push(7);
      //stack.push(6);
      //stack.push(5);

      //stack.print();

      //cout << "\nthe is size:" << stack.size();
      //cout << "\nthis is frist element:" << stack.top();
      //cout << "\nthis is last element:" << stack.bottom();

      //cout << "\n\ndelete element:" << stack.top() << endl;
      //cout << endl;
      //stack.pop();
      //stack.print();


      //if (stack.isEmpty()) {
      //    cout << "\nthe queue is empty:";
      //}
      //else {
      //    cout << "\nnot empty;";
      //}

      //cout << endl << endl;
      //stack.print();
      //cout << "\nthis is item you want in index7:" << stack.getItem(7);

      //cout << "\n\nthis is queue after revers:"; stack.reverse();
      //stack.print();
      //cout << endl << endl;

      //cout << "\nthis is quew after update item in index 2 by 2000:";
      //stack.updateItem(2, 2000);
      //stack.print();
      //cout << endl << endl;


      //cout << "\nthis is queue after insert after item ind index 2 by 3000:";
      //stack.insertAfter(2, 3000);
      //stack.print();
      //cout << endl << endl;


      //cout << "\nthis is queue after insert at front and back:";
      //stack.insertAtFront(1);
      //stack.insertAtBack(10000);
      //stack.print();
      //cout << "\n\n";


      //cout << "this is empty queue aftere clear:"; stack.clear();
      //stack.print();
#pragma endregion


    #pragma region myDynamicarray

    //clsDynamicArray<int> myDynamicArray(10);
    //myDynamicArray.setItem(0, 1);
    //myDynamicArray.setItem(1, 2);
    //myDynamicArray.setItem(2, 3);
    //myDynamicArray.setItem(3, 4);
    //myDynamicArray.setItem(4, 5);
    //myDynamicArray.setItem(5, 6);

    //cout << "\narrey is empty:" << myDynamicArray.isEmpty();
    //cout << "\nthe size:" << myDynamicArray.size();
    //cout << "\nthe element in array:"; myDynamicArray.print();

    //myDynamicArray.resize(11);
    //cout << "\nthe new size is:" << myDynamicArray.size();
    //cout << "\nthe element in array:"; myDynamicArray.print();
    //

    //myDynamicArray.setItem(6, 55);
    //cout << "\nthe new size is:" << myDynamicArray.size();
    //cout << "\nthe element in array:"; myDynamicArray.print();


    //cout << "\nthie is item in index 2:"<< myDynamicArray.getItem(2);
    //myDynamicArray.revers();
    //cout << "\nthe element in array:"; myDynamicArray.print();

    ////myDynamicArray.clear();
    ////cout << "\nthe new size is:" << myDynamicArray.size();
    ////cout << "\nthe element in array:"; myDynamicArray.print();
    //myDynamicArray.revers();
    //myDynamicArray.deleteItemAt(2);
    //cout << "\n\ndelete item in index 2:";
    //cout << "\nthe new size is:" << myDynamicArray.size();
    //cout << "\nthe element in array:"; myDynamicArray.print();

    //cout << "\n\nafter delete frist elemten:";
    //myDynamicArray.deleteFristItem();
    //cout << "\nthe new size is:" << myDynamicArray.size();
    //cout << "\nthe element in array:"; myDynamicArray.print();

    //cout << "\n\nafter delete last elemten:";
    //myDynamicArray.deleteLastItem();
    //cout << "\nthe new size is:" << myDynamicArray.size();
    //cout << "\nthe element in array:"; myDynamicArray.print();

    //int index =myDynamicArray.find(2);
    //cout << "\n\n to find item by value 2:";
    //if (index != -1) {
    //    cout << "\nwe found item in index:" << index;
    //}
    //else
    //{
    //    cout << "\nwe not found it:";
    //}

    //myDynamicArray.deleteItem(2);
    //cout << "\n\nafter delete value 2 :";
    //cout << "\nthe new size is:" << myDynamicArray.size();
    //cout << "\nthe element in array:"; myDynamicArray.print();

    //myDynamicArray.insertAt(1, 2);
    //cout << "\n\nafter insert at index X by value V:";
    //cout << "\nthe new size is:" << myDynamicArray.size();
    //cout << "\nthe element in array:"; myDynamicArray.print();

    //myDynamicArray.insertAtBegining( 4555);
    //cout << "\n\nafter insert at begining:";
    //cout << "\nthe new size is:" << myDynamicArray.size();
    //cout << "\nthe element in array:"; myDynamicArray.print();


    //myDynamicArray.insertAtEnd(4555);
    //cout << "\n\nafter insert at end:";
    //cout << "\nthe new size is:" << myDynamicArray.size();
    //cout << "\nthe element in array:"; myDynamicArray.print();

    //myDynamicArray.insertAfter(6,4555);
    //cout << "\n\nafter insert after index 6 by value 4555:";
    //cout << "\nthe new size is:" << myDynamicArray.size();
    //cout << "\nthe element in array:"; myDynamicArray.print();

    //myDynamicArray.insertBefore(6, 4555);
    //cout << "\n\nafter insert before index 6 by value 4555:";
    //cout << "\nthe new size is:" << myDynamicArray.size();
    //cout << "\nthe element in array:"; myDynamicArray.print();
#pragma endregion


    #pragma region myQueueArr


  //clsMyQueueArr<int> queue;
  //    queue.push(10);
  //    queue.push(2);
  //    queue.push(3);
  //    queue.push(63);
  //    queue.push(21);
  //    queue.push(3123);
  //    queue.print();
  //    queue.pop();
  //    cout << endl << endl;
  //    queue.print();

  //    cout << "\n\n the size:" << queue.size();
  //    cout << "\n\n the frist emlemten:" << queue.front();
  //    cout << "\n\n the last emlemten:" << queue.back();

  //    if (queue.isEmpty()) {
  //        cout << "\nthe queue is empty:";
  //    }
  //    else {
  //        cout << "\nnot empty;";
  //    }

  //    cout << endl << endl;
  //    queue.print();
  //    cout << "\nthis is item you want in index 7:" << queue.getItem(7);

  //    cout << "\n\nthis is queue after revers:"; queue.reverse();
  //    queue.print();
  //    cout << endl << endl;

  //    cout << "\nthis is quew after update item in index 2 by 2000:";
  //    queue.updateItem(2, 2000);
  //    queue.print();
  //    cout << endl << endl;


  //    cout << "\nthis is queue after insert after item ind index 2 by 3000:";
  //    queue.insertAfter(2, 3000);
  //    queue.print();
  //    cout << endl << endl;


  //    cout << "\nthis is queue after insert at front and back:";
  //    queue.insertAtFront(1);
  //    queue.insertAtBack(10000);
  //    queue.print();
  //    cout << "\n\n";


  //    cout << "this is empty queue aftere clear:"; queue.clear();
  //    queue.print();
#pragma endregion

    #pragma region mystackArr


 //clsMyStack<int> stack;
 //     stack.push(10);
 //     stack.push(9);
 //     stack.push(8);
 //     stack.push(7);
 //     stack.push(6);
 //     stack.push(5);

 //     stack.print();

 //     cout << "\nthe is size:" << stack.size();
 //     cout << "\nthis is frist element:" << stack.top();
 //     cout << "\nthis is last element:" << stack.bottom();

 //     cout << "\n\ndelete element:" << stack.top() << endl;
 //     cout << endl;
 //     stack.pop();
 //     stack.print();


 //     if (stack.isEmpty()) {
 //         cout << "\nthe queue is empty:";
 //     }
 //     else {
 //         cout << "\nnot empty;";
 //     }

 //     cout << endl << endl;
 //     stack.print();
 //     cout << "\nthis is item you want in index7:" << stack.getItem(7);

 //     cout << "\n\nthis is queue after revers:"; stack.reverse();
 //     stack.print();
 //     cout << endl << endl;

 //     cout << "\nthis is quew after update item in index 2 by 2000:";
 //     stack.updateItem(2, 2000);
 //     stack.print();
 //     cout << endl << endl;


 //     cout << "\nthis is queue after insert after item ind index 2 by 3000:";
 //     stack.insertAfter(2, 3000);
 //     stack.print();
 //     cout << endl << endl;


 //     cout << "\nthis is queue after insert at front and back:";
 //     stack.insertAtFront(1);
 //     stack.insertAtBack(10000);
 //     stack.print();
 //     cout << "\n\n";


 //     cout << "this is empty queue aftere clear:"; stack.clear();
 //     stack.print();
#pragma endregion

    #pragma region undo redo


    //clsMyString string;
    //cout << "\n string value:" << string.value;

    //string.value = "hossam1";
    //cout << "\nstring value:" << string.value;

    //string.value = "hossam2";
    //cout << "\nstring value:" << string.value;

    //string.value = "hossam3";
    //cout << "\nstring value:" << string.value;


    //cout << "\n\n\n undo:";
    //cout << "\n________________\n";
    //string.undo();
    //cout << "\nstring after undo:" << string.value;
    //string.undo();
    //cout << "\nstring after undo:" << string.value;
    //string.undo();
    //cout << "\nstring after undo:" << string.value;

    //cout << "\n\n\n redo:";
    //cout << "\n________________\n";
    //string.redo();
    //cout << "\nstring after redo:" << string.value;
    //string.redo();
    //cout << "\nstring after redo:" << string.value;
    //
    //string.redo();
    //cout << "\nstring after redo:" << string.value;
#pragma endregion

    clsQueueLine queue("A", 10);
    queue.issueTicket();
    queue.issueTicket();
    queue.issueTicket();
    queue.issueTicket();

    queue.printInfo();

 
    queue.printTicketsLineRTL();
    cout << "\n";
    queue.printTicketsLineLTR();
    cout << "\n\n";
   
    queue.printAllTickets();

    cout << "after serve nex client\n";

    queue.serveNextClient();
    
    queue.printInfo();

    
}