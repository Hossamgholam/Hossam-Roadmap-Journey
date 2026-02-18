#include<iostream>
using namespace std;
struct stdate{
    short day;
    short monthe=0;
    short year;
};

struct period{
    stdate start;
    stdate end;
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
period ReadPeriod(){
    period period1;
    cout<<"enter start Date\n";
    period1.start=read_date();
    cout<<"enter end date\n";
    period1.end=read_date();cout<<"\n\n";
    return period1;
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
void add_day_to_date(stdate &your_date){
    if(is_last_day_in_monthe(your_date)){
        if(is_last_monthe_in_year(your_date.monthe)){
            your_date.year++;
            your_date.monthe=your_date.day=1;
        }
        else{
            your_date.day=1;
            your_date.monthe++;
        }
    }
    else{
        your_date.day++;
    }
}



bool date1_lessthane_date2(stdate date1,stdate date2){
   return (date1.year<date2.year)?true:((date1.year==date2.year)?(date1.monthe<date2.monthe?true:(date1.monthe==date2.monthe?date1.day<date2.day:false)):false);
}


short diffrence_days(stdate your_date1,stdate your_date2,bool include_end_day=false){

   short difference;
   while(date1_lessthane_date2(your_date1,your_date2)){
    difference++;
    add_day_to_date(your_date1);
   }
   
   return include_end_day?++difference:difference;

}
short PeriodLenghtINDay(period period1,bool includelastday=false){
    return diffrence_days(period1.start,period1.end,includelastday);
}
int main(){
    period period1;
    cout<<"Enter period 1:\n";
    period1=ReadPeriod();
    cout<<"period lenght is :"<<PeriodLenghtINDay(period1)<<endl;
    cout<<"period lenght include last day id:"<<PeriodLenghtINDay(period1,true);
}