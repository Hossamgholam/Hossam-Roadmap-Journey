#include<iostream>
using namespace std;
int read_number(string message){
    int your_number;
    cout<<message;
    cin>>your_number;
    return your_number;
}
int revers_number(int your_number){
    int reminde=0;
    int new_number=0;
    while(your_number>0){
        reminde=your_number%10;
        your_number/=10;
        new_number=new_number*10+reminde;
    }
    return new_number;
}
void print_order(int your_number){
    int reminde=0;
    your_number=revers_number(your_number);
    while(your_number>0){
        reminde=your_number%10;
        your_number/=10;
        cout<<reminde<<endl;
    }
}
int main(){
    int number=read_number("please inter your number:");
    print_order(number);
}