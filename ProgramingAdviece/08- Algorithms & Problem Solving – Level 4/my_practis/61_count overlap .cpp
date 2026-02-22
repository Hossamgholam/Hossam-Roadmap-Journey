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
enum Encompar{before=-1,equal=0,after=1};

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

bool date1_equel_date2(stdate date1,stdate date2){
   
   return (date1.year==date2.year?(date1.monthe==date2.monthe?(date1.day==date2.day?true:false):false):false);
}
bool date1_lessthane_date2(stdate date1,stdate date2){
   
   return (date1.year<date2.year?true:(date1.year==date2.year?(date1.monthe<date2.monthe?true:(date1.monthe==date2.monthe?date1.day<date2.day:false)):false));
}
bool Date1AfterDate2(stdate date1,stdate date2){
    return (!date1_lessthane_date2(date1,date2)&&!date1_equel_date2(date1,date2));
}
Encompar ComaparDate(stdate date1,stdate date2){
    if(date1_equel_date2(date1,date2)){
        return Encompar::equal;
    }
    else if(date1_lessthane_date2(date1,date2)){
        return Encompar::before;
    }
    return Encompar::after;
}

short diffrence_days(stdate your_date1,stdate your_date2,bool include_end_day=false){

   short difference;
   while(date1_lessthane_date2(your_date1,your_date2)){
    difference++;
    add_day_to_date(your_date1);
   }
   
   return include_end_day?++difference:difference;

}
bool OverlapPeriods(period period1,period period2){
  if(ComaparDate(period1.end,period2.start)==Encompar::before||ComaparDate(period1.start,period2.end)==Encompar::after){
    return false;
  }
  else{
    return true;
  }
}
short PeriodLenghtINDay(period period1,bool includelastday=false){
    return diffrence_days(period1.start,period1.end,includelastday);
}
bool IsDateWithinPeriod(period period1,stdate date){

    return !(ComaparDate(date,period1.start)==Encompar::before||ComaparDate(date,period1.end)==after);
   
}

short CountOverlap(period period1,period period2){
    short counter=0;
    short lengthperiod1=PeriodLenghtINDay(period1,true);
    short lengthperiod2=PeriodLenghtINDay(period2,true);

    if(!OverlapPeriods(period1,period2)){
        return 0;
    }
    if(lengthperiod1<lengthperiod2){
       while(date1_lessthane_date2(period1.start,period1.end)){
           if(IsDateWithinPeriod(period2,period1.start)){
               counter++;
           }
           add_day_to_date(period1.start);
       }

    }
    else{
        while(date1_lessthane_date2(period2.start,period2.end)){
            if(IsDateWithinPeriod(period1,period2.start)){
                counter++;
            }
            add_day_to_date(period2.start);
        }
    }
    return counter;
}
int main(){
    period period1,period2;

    cout<<"Enter period 1\n";
    period1=ReadPeriod();

    cout<<"Enter period 2\n";
    period2=ReadPeriod();

    cout<<"overlap day count is:"<<CountOverlap(period1,period2);
  

}