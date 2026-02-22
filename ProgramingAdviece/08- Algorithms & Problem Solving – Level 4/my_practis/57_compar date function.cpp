#include<iostream>
using namespace std;


struct stdate{
    short day;
    short monthe=0;
    short year;
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
int main(){
    stdate date1=read_date();
    cout<<"\n\n\n";
    stdate date2=read_date();
    cout<<"compare result="<<ComaparDate(date1,date2);

}