#include<iostream>
using namespace std;
class Cls{
    public:
    int var;
    static int counter;

    Cls(int variable){
        var=variable;
        counter++;
    }
    void print(){
        cout<<"\nvariable:"<<var;
        cout<<"\ncounter is:"<<counter;
    }
    static void fuction1(){
        cout<<"iam static function\n";    
    }
};
int Cls::counter=0;
int main(){
   Cls p1(10),p2(20),p3(30);
   p1.print();cout<<endl;
   p2.print();cout<<endl;
   p3.print();cout<<endl;

   p1.counter=4;
   p1.print();cout<<endl;
   p2.print();cout<<endl;
   p3.print();cout<<endl;

   Cls::fuction1();

}