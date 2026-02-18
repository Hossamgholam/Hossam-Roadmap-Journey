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
bool IsDateWithinPeriod(period period1,stdate date){

    return !(ComaparDate(date,period1.start)==Encompar::before||ComaparDate(date,period1.end)==after);
    /*
    if(ComaparDate(date,period1.start)==Encompar::before&&ComaparDate(date,period1.end)==after){
        return true;
    }
    return false;
    */
}
int main(){
   period period1;stdate date;
   cout<<"enter period 1\n";
   period1=ReadPeriod();

   cout<<"enter date to check\n";
   date=read_date();

   if(IsDateWithinPeriod(period1,date)){
    cout<<"yes Date is within period\n";
   }
   else{
    cout<<"no date is not within period";
   }

}