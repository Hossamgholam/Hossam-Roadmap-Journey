#include<iostream>
using namespace std;
enum Encompar{before=-1,equal=0,after=1};
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
/*

|        |
            |      |


            |        |
|        |

*/
bool OverlapPeriods(period period1,period period2){
  if(ComaparDate(period1.end,period2.start)==Encompar::before||ComaparDate(period1.start,period2.end)==Encompar::after){
    return false;
  }
  else{
    return true;
  }
}
int main(){
    period period1,period2;

    cout<<"Enter period 1\n";
    period1=ReadPeriod();

    cout<<"Enter period 2\n";
    period2=ReadPeriod();

    if(OverlapPeriods(period1,period2)){
        cout<<"yes ,period is overlap\n";
    }
    else{
        cout<<"no ,it is not overlap\n";
    }

}