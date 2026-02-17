#include<iostream>
using namespace std;
int read_number(string message){
    int your_number;
    cout<<message;
    cin>>your_number;
    return your_number;
}
int print_sum_digit(int your_number){
    int sum=0;
    while(your_number>0){
        int remaind=0;
        remaind=your_number%10;
        your_number/=10;
        sum+=remaind;
    }
    return sum;
}
int main(){
       cout<<"the sum of digits is :"<<print_sum_digit(read_number("please inter your number two start:"));
}