#include<iostream>
using namespace std;
struct sttime{
    short day=365;
    int hour=day*24;
    int minutes=hour*60;
    int second=minutes*60;
    
};
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
int main(){
    char answer='y';
    do{
    int year=read_number();
    sttime t;
    if(leap_year(year)){
       t.day=366;
       cout<<"number of day in year["<<year<<"] is "<<t.day<<endl;
       cout<<"number of day in hour["<<year<<"] is "<<t.hour<<endl;
       cout<<"number of day in minutes["<<year<<"] is "<<t.minutes<<endl;
       cout<<"number of day in second["<<year<<"] is "<<t.second<<endl;

    }
    else{
       cout<<"number of day in year["<<year<<"] is "<<t.day<<endl;
       cout<<"number of day in hour["<<year<<"] is "<<t.hour<<endl;
       cout<<"number of day in minutes["<<year<<"] is "<<t.minutes<<endl;
       cout<<"number of day in second["<<year<<"] is "<<t.second<<endl;
    }
    cout<<"do you repeat :";cin>>answer;

    }while(answer=='y');
}