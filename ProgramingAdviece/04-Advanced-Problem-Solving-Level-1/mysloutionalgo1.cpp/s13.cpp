#include<iostream>
using namespace std;
void read_number(int &n1,int &n2,int &n3){
    cout<<"please inter frist number:";cin>>n1;
    cout<<"please inter second number:";cin>>n2;
    cout<<"please inter thered number:";cin>>n3;
}

int check_max(int n1,int n2,int n3){
    if(n1>n2){
        if(n1>n3){
            return n1;
        }
        else{
            return n3;
            }
    }
    else{
        if(n2>n3){
            return n2;
        }
        else{
            return n3;
        }
    }
}
void print_max(int max){
    cout<<"the max number is :"<<max<<endl;
}
int main(){
    int number1,number2,number3;
    read_number(number1,number2,number3);
    print_max(check_max(number1,number2,number3));
}