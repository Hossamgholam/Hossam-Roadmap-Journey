#include<iostream>
using namespace std;
int read_number(){
    int number;
    do{
    cout<<"please inter your number:";cin>>number;
    }while(number<0);
    return number;
}
bool leap_year(int your_year){
    if(your_year%400==0){
        return true;
    }
    else if(your_year%100==0){
        return false;
    }
    else if(your_year%4==0){
            return true;
    }
    else{

    return false;
    }
}
int main(){
    int year=read_number();
    if(leap_year(year)){
        cout<<"yes "<<year<<" is a leap year\n";
    }
    else{
        cout<<"no "<<year <<"is not leap year\n";
    }
}