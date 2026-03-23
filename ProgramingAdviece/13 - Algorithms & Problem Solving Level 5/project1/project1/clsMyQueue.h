#pragma once
#include <iostream>
#include "clsDbLinkedList.h"
using namespace std;

#pragma region descrption

/*
=====================================================
	clsMyQueue<T>
	-------------------
	A Queue (FIFO structure) implementation that
	depends on clsDbLinkedList<T> using composition.

	?? Main Features:
	- push(value)       ? add item to back of queue
	- pop()             ? remove item from front
	- front()           ? get first item
	- back()            ? get last item
	- size()            ? number of items
	- isEmpty()         ? check if queue is empty
	- clear()           ? remove all items
	- print()           ? print items

	?? Extended Features (from linked list):
	- getItem(index)    ? get item at index
	- updateItem(index, value) ? update value by index
	- insertAfter(index, value) ? insert after index
	- insertAtFront(value)      ? insert at front
	- insertAtBack(value)       ? insert at back
	- reverse()         ? reverse order of queue


=====================================================
*/
#pragma endregion

template <class T>
class clsMyQueue
{
protected:
	clsDbLinkedList<T> myStorge;

public:
	void push(T newValue)
	{
		myStorge.insertAtEnd(newValue);
	}
	void pop()
	{
		myStorge.deleteFristNode();
	}
	T front()
	{
		return myStorge.getItem(0);
	}
	T back()
	{
		return myStorge.getItem(myStorge.size() - 1);
	}
	bool isEmpty()
	{
		return myStorge.isEmpty();
	}
	short size()
	{
		return myStorge.size();
	}
	void print()
	{
		myStorge.printList();
	}

	// this is extion from1 to 7
	T getItem(short index)
	{
		return myStorge.getItem(index);
	}
	void reverse()
	{
		myStorge.Reverse();
	}
	void updateItem(short index, T newValue)
	{
		myStorge.updateItem(index, newValue);
	}
	void insertAfter(short index, T newValue)
	{
		myStorge.insertAfter(index, newValue);
	}
	void insertAtFront(T newValue)
	{
		myStorge.insertAtBeginning(newValue);
	}
	void insertAtBack(T newValue)
	{
		myStorge.insertAtEnd(newValue);
	}
	void clear()
	{
		myStorge.clear();
	}
};
