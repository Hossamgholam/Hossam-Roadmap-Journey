#include<iostream>
using namespace std;
void read_number(int &n1,int &n2){
    cout<<"please inter your frist number:";cin>>n1;
    cout<<"please inter your second number:";cin>>n2;
}
void swap(int &number3,int &number4){
   int temp=number3;
    number3=number4;
    number4=temp;
   
}
void print_number(int n1,int n2){
    cout<<"two number after swap :\n";
    cout<<n1<<endl;
    cout<<n2<<endl;
}
int main(){
    int number1,number2;
    read_number(number1,number2);
   
    print_number(number1,number2);


    swap(number1,number2);

    print_number(number1,number2);
}
