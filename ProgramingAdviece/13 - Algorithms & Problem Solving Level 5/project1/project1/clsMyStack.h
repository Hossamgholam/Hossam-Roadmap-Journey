#pragma once
#include <iostream>
#include "clsMyQueue.h"
using namespace std;
#pragma region descrpion

//===========================================================
// Class: clsMyStack
//===========================================================
//
// Description:
//------------
// This class represents a generic **Stack** data structure
// based on the LIFO (Last In, First Out) principle.
//
//- The stack is implemented using composition and inheritance:
//	* It inherits from clsMyQueue<t>.
//	* Internally, it stores items using a doubly linked list.
//
// Key Operations:
//---------------
// 1. push(newValue):
//   Adds a new element to the top of the stack.
//
// 2. pop():
//   Removes the element from the top of the stack.
//
// 3. top():
//   Returns the element at the top of the stack
//   (the most recently added element).
//
// 4. bottom():
//   Returns the element at the bottom of the stack
//   (the oldest element).
//
// Notes:
//------
//- Unlike a Queue (FIFO), a Stack follows LIFO.
//- `push()` inserts at the beginning of the linked list.
//- `pop()` removes from the beginning of the linked list.
//- This ensures O(1) time complexity for push and pop operations.
//
// Use Cases:
//----------
//- Function call management (Call Stack).
//- Undo/Redo features in applications.
//- Expression evaluation and syntax parsing.
//
//===========================================================
//*/
#pragma endregion

template <class T>
class clsMyStack : public clsMyQueue<T>
{

public:
	void push(T newValue)
	{
		clsMyQueue<T>::myStorge.insertAtBeginning(newValue);
	}
	T top()
	{
		return clsMyQueue<T>::front();
	}
	T bottom()
	{
		return clsMyQueue<T>::back();
	}
};
