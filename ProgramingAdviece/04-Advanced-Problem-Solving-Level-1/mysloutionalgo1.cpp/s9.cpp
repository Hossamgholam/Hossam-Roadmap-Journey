#include<iostream>
using namespace std;
void read_numbers(int &number1,int &number2,int &number3){
    
    cout<<"please inter your frist number:";cin>>number1;
    cout<<"please inter your second number:";cin>>number2;
    cout<<"please inter your thered number:";cin>>number3;
    
}
int calculat_sum(int n1,int n2,int n3){
    return n1+n2+n3;
}
void print_sum(int your_total){
    cout<<"the sum of treee number is "<<your_total;
}
int main(){
    int number1,number2,number3;
    read_numbers(number1,number2,number3);
    print_sum(calculat_sum(number1,number2,number3));
}