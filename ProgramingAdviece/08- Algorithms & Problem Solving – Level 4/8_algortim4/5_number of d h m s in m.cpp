/*
number of year 
number of monthe
leap year

*/
#include<iostream>
using namespace std;

int read_number(string massege){
    int number;
    do{
    cout<<massege<<":";cin>>number;
    }while(number<0);
    return number;
}
bool leap_year(int your_year){
   return  (your_year%400==0||(your_year%4==0&&!(your_year%100==0)))?true:false;
}
int number_day_monthe(int your_year,int your_monthe){
    if(your_monthe<1||your_monthe>12){
        return 0;
    }   
    if(your_monthe==2) {
        return leap_year(your_year)?29:28;
    }
    short array31day[7]={1,3,5,7,8,10,12};
    for(short i=0;i<7;i++){
        if(array31day[i]==your_monthe){
            return 31;
        }
    }
    return 30;
}
int number_hour_monthe(int your_year,int your_monthe){
    return number_day_monthe(your_year,your_monthe)*24;
}
int number_minutes_monthe(int your_year,int your_monthe){
    return number_hour_monthe(your_year,your_monthe)*60;
}
int number_second_monthe(int your_year,int your_monthe){
    return number_minutes_monthe(your_year,your_monthe)*60;
}
int main(){
    char answer='y';
    do{
    int year=read_number("please inter your year");
    short monthe=read_number("please inter your monthe");
    cout<<"number of day in year["<<year<<"] is "<<number_day_monthe(year,monthe)<<endl;
    cout<<"number of day in hour["<<year<<"] is "<<number_hour_monthe(year,monthe)<<endl;
    cout<<"number of day in minutes["<<year<<"] is "<<number_minutes_monthe(year,monthe)<<endl;
    cout<<"number of day in second["<<year<<"] is "<<number_second_monthe(year,monthe)<<endl;
   
    cout<<"do you repeat :";cin>>answer;

    }while(answer=='y');
}