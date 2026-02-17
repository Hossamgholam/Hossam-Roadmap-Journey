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
float calculat_average(int n1,int n2,int n3){
    return (float) calculat_sum(n1,n2,n3)/3;
}
void print_average(float your_average){
    cout<<"the aver of treee number is "<<your_average;
}
int main(){
    int number1,number2,number3;
    read_numbers(number1,number2,number3);
     print_average(calculat_average(number1,number2,number3));
}
