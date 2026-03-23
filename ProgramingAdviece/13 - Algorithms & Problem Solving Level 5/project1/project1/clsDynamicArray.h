#pragma once
#include<iostream>
using namespace std;

#pragma region description
/*
 * clsDynamicArray
 * ----------------
 * This class is a simple implementation of a Dynamic Array.
 *
 * - A Dynamic Array is like a normal array, but it can change its size at runtime.
 * - It stores items in a continuous block of memory.
 * - You can access elements directly by their index (just like a normal array).
 *
 * Main features:
 * - setItem(index, value): set a value at a specific position.
 * - getItem(index): get the value at a specific position.
 * - size(): returns how many items are stored.
 * - isEmpty(): check if the array is empty.
 * - print(): display all items.
 * - resize(newSize): change the array size (shrink or grow).
 * - clear(): remove all items.
 * - reverse(): reverse the order of items.
 * - find(value): search for an item and return its index.
 * - insertAt(index, value): insert a new item at a specific position.
 * - insertAtBegining(), insertAtEnd(), insertBefore(), insertAfter():
 *   helper functions to insert items in different positions.
 * - deleteItemAt(index): delete an item at a specific position.
 * - deleteItem(value): find and delete an item by its value.
 * - deleteFirstItem(), deleteLastItem(): remove items from start or end.
 *
 * Note:
 * - This class is just for practice, to understand how arrays can work internally.
 * - In real projects, C++ provides std::vector which already does all of this.
 */
#pragma endregion

template<class T>
class clsDynamicArray
{
private:
	int _size=0;
	T* _tempArray;

public:
	T* array;

	clsDynamicArray(int size=0) {
		//we can not user return so but size=0
		if (size < 0) {
			size = 0;
		}
		_size = size;
		array = new T[_size];
	}
	~clsDynamicArray() {
		delete[] array;
	}

	bool setItem(int index, T value) {
		if (index<0 || index>=_size) {
			return false;
		}
		else {
		    array[index] = value;
		    return true;
		}
	}
	bool isEmpty() {
		return(_size == 0 ? true : false);
	}
	int size() {
		return _size;
	}
	void print() {
		
		for (int i = 0; i < _size; i++) {
			cout << array[i] << " ";
		}
	}

	void resize(int newSize) {
		if (newSize < 0) {
			newSize = 0;
		}

		_tempArray = new T[newSize];

		if (newSize < _size) {
			_size = newSize;
		}
		for (int i = 0; i < _size; i++) {
			_tempArray[i] = array[i];
		}

		_size = newSize;
		delete[] array;
		array = _tempArray;
		
	}

	T getItem(int index) {
		if (index < 0 || index >= _size) {
			return T();
		}
		return array[index];
	}
	void revers() {
		
		///*for (int i = 0; i < _size / 2; i++) {
		//	swap(array[i], array[_size - 1 - i]);
		//}*/

		_tempArray = new T[_size];
		int counter = 0;
		for (int i = _size - 1; i >= 0; i--) {
			_tempArray[counter] = array[i];
			counter++;
		}
		delete[] array;
		array = _tempArray;
	
	}
	void clear() {
		_tempArray = new T[0];
		delete[] array;
		array = nullptr;
		array = _tempArray;
		_size = 0;


	}

	bool deleteItemAt(int index) {
         #pragma region my sloution

		///*if (index < 0 || index >= _size) {
		//	return;
		//}
		//_tempArray = new T[_size - 1];
		//int counter = 0;
		//for (int i = 0; i < _size; i++) {
		//	if (i != index) {
		//		_tempArray[counter] = array[i];
		//		counter++;
		//		
		//	}
		//	else {
		//		continue;
		//	}
		//}
		//delete[] array;
		//array = _tempArray;
		//_size = counter;*/

#pragma endregion
		if (index < 0 || index >= _size) {
			return false;
		}
		_size--;
		_tempArray = new T[_size];

		for (int i = 0; i < index; i++) {
			_tempArray[i] = array[i];
		}

		for (int i = index + 1; i < _size+1; i++) {
			_tempArray[i - 1] = array[i];
		}
		delete[] array;
		array=_tempArray;
		
		return true;
		

	}
	bool deleteItem(T value) {
		int index = find(value);
		if (index == -1) {
			return false;
		}
		deleteItemAt(index);
		return true;
		
	}

	void deleteFristItem() {
		/*if (_size == 0) {
			return;
		}
		_size--;
		_tempArray = new T[_size];
		for (int i = 1; i < _size + 1; i++) {
			_tempArray[i - 1] = array[i];
		}
		delete[] array;
		array = _tempArray;*/
		deleteItem(0);
	}
	void deleteLastItem() {
		/*if (_size == 0) {
			return;
		}
		_size--;
		_tempArray = new T[_size];
		for (int i = 0; i < _size ; i++) {
			_tempArray[i ] = array[i];
		}
		delete[] array;
		array = _tempArray;*/

		deleteItem(_size - 1);
	}
	int find(T value) {
		int index = -1;
		for (int i = 0; i < _size; i++) {
			if (array[i] == value) {
				index = i;
				return index;
			}
		}
			return index;
	}

	bool insertAt(int index, T value) {
		/*_size++;
		_tempArray = new T[_size];
		int counter = 0;
		for (int i = 0; i < _size; i++) {
			if (i == index) {
				_tempArray[i] = value;
			}
			else {
				_tempArray[i] = array[counter];
				counter++;
			}
		}
		delete[]array;
		array = _tempArray;*/
		//we make it index > not >= becuset we used 
		//this fuction to insert after so if it insert after last elment it not do and return
		if (index < 0 || index > _size) {
			return false;
		}
		_size++;
		_tempArray = new T[_size];

		//it stop befor index we what 
		for (int i = 0; i < index;i++) {
			_tempArray[i] = array[i];
		}
	     //but value in index
		_tempArray[index] = value;
		//continue after index
		for (int i = index + 1; i < _size; i++) {
			_tempArray[i] = array[i-1];
		}
		delete[]array;
		array = _tempArray;
		return true;
	}
	void insertAtBegining(T value) {
		insertAt(0, value);
	}
	void insertBefore(int index, T value) {
		if (index < 1) {
			insertAt(0, value);
		}
		else {

		insertAt(index - 1, value);
		}
	}
	void insertAfter(int index, T value) {
		if (index >= _size) {
			insertAt(_size, value);
		}
		else{
		insertAt(index + 1, value);

		}
	}
	void insertAtEnd(T value) {

		insertAt(_size, value);
	}


};

