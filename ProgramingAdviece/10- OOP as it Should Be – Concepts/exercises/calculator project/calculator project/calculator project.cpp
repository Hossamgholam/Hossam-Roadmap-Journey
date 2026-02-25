

#include <iostream>
using namespace std;

class ClsCalculator {
   
private:
    float UserNumber = 0;
    float result = 0;
    float PreNumber = 0;
    string Opertion = "clear";
    
    float checkDiv(int n) {
        if (n == 0) {
            return 1;
        }
        return n;
    }

public:
    void Add(float Number) {
        PreNumber = result;
        result += Number;
        UserNumber = Number;
        Opertion = "add";
    }

    void Subtract(float Number) {
        PreNumber = result;
        result -= Number;
        UserNumber = Number;
        Opertion = "subtract";
    }
    void multiplay(float Number) {
        result *= Number;
        UserNumber = Number;
        Opertion = "multiplay";

    }
    void divide(float Number) {
        Number = checkDiv(Number);
        PreNumber = result;
        result /= Number;
        UserNumber = Number;
        Opertion = "divide";

    }
    void clear() {
        PreNumber = 0;
        result = 0;
        UserNumber = 0;
        Opertion = "clear";

    }
    void PrintResult() {
        cout << "result after operation " <<Opertion
            <<" "<<UserNumber << " is=" << result << endl;

    }
    void CancelLastOper() {
        result = PreNumber;
        UserNumber = 0;
        Opertion = "CanserlastOpertion";
    }
};
int main()
{
    ClsCalculator c1;
    c1.clear();
    c1.PrintResult();

    c1.Add(10);
    c1.PrintResult();

    c1.Add(30);
    c1.PrintResult();

    c1.Subtract(10);
    c1.PrintResult();

    c1.multiplay(2);
    c1.PrintResult();

    c1.divide(3);
    c1.PrintResult();

    c1.CancelLastOper();
    c1.PrintResult();

    c1.clear();
    c1.PrintResult();



}

