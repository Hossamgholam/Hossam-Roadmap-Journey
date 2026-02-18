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
   return  (your_year%400==0||(your_year%4==0&&!(your_year%100==0)))?true:false;
}
int number_day_year(int your_year){
    return leap_year(your_year)?366:365;
}
int number_hour_year(int your_year){
    return number_day_year(your_year)*24;
}
int number_minutes_year(int your_year){
    return number_hour_year(your_year)*60;
}
int number_second_year(int your_year){
    return number_minutes_year(your_year)*60;
}
int main(){
    char answer='y';
    do{
    int year=read_number();
    cout<<"number of day in year["<<year<<"] is "<<number_day_year(year)<<endl;
    cout<<"number of day in hour["<<year<<"] is "<<number_hour_year(year)<<endl;
    cout<<"number of day in minutes["<<year<<"] is "<<number_minutes_year(year)<<endl;
    cout<<"number of day in second["<<year<<"] is "<<number_second_year(year)<<endl;
   
    cout<<"do you repeat :";cin>>answer;

    }while(answer=='y');
}