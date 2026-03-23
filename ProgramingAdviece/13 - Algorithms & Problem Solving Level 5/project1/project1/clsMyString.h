#pragma once
#include"iostream"
#include"clsMyStack.h"
using namespace std;
class clsMyString
{
private:
	clsMyStack<string> _myStackUndo;
	clsMyStack<string>_myStackRedo;
	string _value;
public:
	/*clsMyString(string value="") {
		_value = value;
		_myStackUndo.push(_value);
	}*/

	//last value that assing not push
	void setValue(string value) {
		_myStackUndo.push(_value);
		_value = value;
	}

	string getValue() {
		return _value;
	}
	__declspec(property(get = getValue, put = setValue))string value;

	void undo() {

	/*	if (_myStackUndo.size() == 0) {
			return;
		}
		string lastitem = _myStackUndo.top();
		_myStackRedo.push(lastitem);
		_myStackUndo.pop();
		_value = _myStackUndo.top();*/
		if (!_myStackUndo.isEmpty()) {
			_myStackRedo.push(_value);
			_value = _myStackUndo.top();
			_myStackUndo.pop();
		}
	}

	void redo() {
		/*if (_myStackRedo.size() == 0) {
			return;
		}
		_value = _myStackRedo.top();
		string lastitem = _myStackRedo.top();
		_myStackUndo.push(lastitem);
		_myStackRedo.pop();*/

		if (!_myStackRedo.isEmpty()) {
			_myStackUndo.push(_value);
			_value = _myStackRedo.top();
			_myStackRedo.pop();

		}
	}


};

