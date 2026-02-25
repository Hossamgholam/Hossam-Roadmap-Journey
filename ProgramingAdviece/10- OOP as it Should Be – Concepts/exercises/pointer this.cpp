
#include <iostream>
using namespace std;
class employee {
public:
    string name;
    int age;
    float salary;
    employee(string name, int age, float salary) {
        this->name = name;
        this->age = age;
        this->salary = salary;
    }

    static void func2(employee currentObject) {
        //she static function she donot know any thing about oject
        //so you need to call it from another function
        currentObject.print();
    }
    
    //use this fuction because she know object and call non-static function
    void fnc1() {

        func2(*this);
    }


    void print() {
        cout << name << "   " << age << "  " << salary;
    }
};
int main()
{
    cout << "Hello World!\n";
}

