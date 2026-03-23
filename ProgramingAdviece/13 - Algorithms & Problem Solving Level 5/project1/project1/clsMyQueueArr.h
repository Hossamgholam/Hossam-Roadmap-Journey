#pragma once
#include<iostream>
#include"clsDynamicArray.h"
using namespace std;

#pragma region description

/*
 * clsMyQueueArr
 * ----------------
 * This class represents a Queue (?????) using Dynamic Array.
 *
 * - A Queue works in FIFO order (First In, First Out).
 *   That means: the first element you add is the first element that comes out.
 *
 * Main operations:
 * - push(newValue): add a new item at the back of the queue.
 * - pop(): remove the first item (the front).
 * - front(): see the first item without removing it.
 * - back(): see the last item.
 * - isEmpty(): check if the queue has no items.
 * - size(): get how many items are inside.
 * - print(): display all items.
 *
 * Extra features (not in normal queue but useful for practice):
 * - reverse(): reverse the order of items.
 * - updateItem(index, newValue): change an item at a specific position.
 * - insertAtFront() / insertAtBack(): add items directly at front or back.
 * - insertAfter(index, newValue): insert item after a position.
 * - clear(): remove all items from the queue.
 */
#pragma endregion

template<class T>
class clsMyQueueArr
{
protected:
	// we but intial value for parameter(_size) in constractor 
	clsDynamicArray<T> myStorge;
public:
	
	void push(T newValue)
	{
		myStorge.insertAtEnd(newValue);
	}
	void pop()
	{
		myStorge.deleteFristItem();
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
	int size()
	{
		return myStorge.size();
	}
	void print()
	{
		myStorge.print();
	}

	// this is extion from1 to 7
	T getItem(short index)
	{
		return myStorge.getItem(index);
	}
	void reverse()
	{
		myStorge.revers();
	}
	void updateItem(short index, T newValue)
	{
		myStorge.setItem(index, newValue);
	}
	void insertAfter(short index, T newValue)
	{
		myStorge.insertAfter(index, newValue);
	}
	void insertAtFront(T newValue)
	{
		myStorge.insertAtBegining(newValue);
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

