#include<iostream>
using namespace std;
void read_number(int &n1,int &n2){
    cout<<"please inter frist number:";cin>>n1;
    cout<<"please inter second number:";cin>>n2;
}

int check_max(int n1,int n2){
    if(n1>n2){
        return n1;
    }
    else{
        return n2;
    }
}
void print_max(int max){
    cout<<"the max number is :"<<max<<endl;
}

int main(){
    int number1,number2;
    read_number(number1,number2);
    print_max(check_max(number1,number2));
}