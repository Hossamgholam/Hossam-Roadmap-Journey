#include <iostream>
using namespace std;


template<typename t>
t sum(t number1, t number2) {
	return number1 + number2;
}

template<class c>

class calculater {
private:
	c number1, number2;
public:
	calculater(c number1, c nubmer2) {
		this->number1 = number1;
		this->number2 = nubmer2;
	}
	
	c add() {
		return number1 + number2;
	}
	c subtract() {
		return number1 - number2;
	}
};

int main()
{
	cout << sum<int>('d', '1') << endl;
	cout << sum<short>(23, 232) << endl;;
	cout << sum<int>(100000, 1)<<endl;
	cout << sum<long>(2300000, 0)<<endl;

	calculater<int> c(1,4);
	cout<<c.add();

	
}

