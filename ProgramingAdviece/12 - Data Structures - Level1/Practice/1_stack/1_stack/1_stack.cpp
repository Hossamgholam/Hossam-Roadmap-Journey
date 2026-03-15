

#include <iostream>
#include<stack>
#include<queue>
#include<vector>
using namespace std;

int main()
{
#pragma region  swap empty puch pop in stack
	/*stack<int> stIntNumber;
	stIntNumber.push(1);
	stIntNumber.push(2);
	stIntNumber.push(3);
	stIntNumber.push(4);

	stack<int>stSwapTo;

	stSwapTo.push(388);
	stSwapTo.push(66654);
	stSwapTo.push(83474);*/



	/*cout << "this is size os stintnumber:" << stIntNumber.size() << endl;
	cout << "this is size:" << stSwapTo.size() << endl;


	stIntNumber.swap(stSwapTo);
	cout << "\n\n\nthis is stintnumber\n";
	cout << "this is size:" << stIntNumber.size() << endl;
	while (!stIntNumber.empty()) {
		cout << stIntNumber.top() << endl;
		stIntNumber.pop();

	}

	cout << "\n\nthis is swap\n";
	cout << "this is size:" << stSwapTo.size() << endl;
	while (!stSwapTo.empty()) {
		cout << stSwapTo.top() << endl;
		stSwapTo.pop();

	}*/
#pragma endregion
	

	queue<string>quString;
	quString.push("hossam");
	quString.push("alsid");
	quString.push("salim");
	quString.push("alsid");
	quString.push("gholam");

	cout << "ths size is       :" << quString.size() << endl;
	cout << "the front emlement:" << quString.front() << endl;;
	cout << "the back end      :" << quString.back() << endl;

	while (!quString.empty()) {
		cout << quString.front()<<" ";
		quString.pop();
	}

	quString.push("hossam");
	quString.push("alsid");
	quString.push("salim");
	quString.push("alsid");
	quString.push("gholam");
	cout << endl;

	int size = quString.size();

	for (int i = 0; i < size; i++) {
		cout << quString.front() << "=";
		quString.pop();
	}

	

	
	

	

	
}

