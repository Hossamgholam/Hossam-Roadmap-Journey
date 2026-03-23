#pragma once
#include<iostream>
using namespace std;
#include"clsMyQueueArr.h"
template<class T>
class clsStackArr :public clsMyQueueArr<T>
{
public:
	void puch(T value) {
		clsMyQueueArr<T>::mystorge.insertAtBeginning(value); egining(value);
	}
	T top() {
		return clsMyQueueArr<T>::front();
	}
	T bottom() {
		return clsMyQueueArr<T>::back();
	}

};

