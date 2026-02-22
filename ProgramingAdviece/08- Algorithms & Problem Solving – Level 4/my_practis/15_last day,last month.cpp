#include<iostream>
using namespace std;
struct stdate{
    short day;
    short monthe=0;
    short year;
};


short read_number(string massage){
  short number;
  cout<<massage;cin>>number;
  return number;
}
stdate read_date(){
    stdate my_date;
    my_date.day=read_number("please inter your date:");
    my_date.monthe=read_number("please inter your monthe:");
    my_date.year=read_number("please inter your year:");
    return my_date;
}
bool leap_year(short your_year){
   return  (your_year%400==0||(your_year%4==0&&(your_year%100!=0)))?true:false;
}

short number_day_monthe(short your_year,short your_monthe){
    if(your_monthe<1||your_monthe>12){
        return 0;
    }
    short arrydaymonthe[12]={31,28,31,30,31,30,31,31,30,31,30,31};
    short number_day=(your_monthe==2)?(leap_year(your_year)?29:28):arrydaymonthe[your_monthe-1];
    return number_day;
}
bool is_last_day_in_monthe(stdate your_date){
return (number_day_monthe(your_date.year,your_date.monthe)==your_date.day);
}
bool is_last_monthe_in_year(short your_monthe){
    return (your_monthe==12);
}
int main(){
    stdate date1=read_date();
    
    if(is_last_day_in_monthe(date1.day,date1.monthe,date1.year)){
        cout<<"yes day is last date in monthe\n";
    }
    else{
        cout<<"no day is not last day in monthe\n";
    }
    if(is_last_monthe_in_year(date1.monthe)){
        cout<<"yes monthe is last monthe in year\n";
    }
    else{
        cout<<"no monthe is not last monthe in year\n";
    }

}