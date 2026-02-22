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

bool date1_equel_date2(stdate date1,stdate date2){
   
   return (date1.year==date2.year?(date1.monthe==date2.monthe?(date1.day==date2.day?true:false):false):false);
}
bool date1_lessthane_date2(stdate date1,stdate date2){
   
   return (date1.year<date2.year?true:(date1.year==date2.year?(date1.monthe<date2.monthe?true:(date1.monthe==date2.monthe?date1.day<date2.day:false)):false));
}
/*

bool Date1AfterDate2(stdate date1,stdate date2){
   
   return (date1.year>date2.year?true:(date1.year==date2.year?(date1.monthe>date2.monthe?true:(date1.monthe==date2.monthe?date1.day>date2.day:false)):false));
}
*/

bool Date1AfterDate2(stdate date1,stdate date2){
    return (!date1_lessthane_date2(date1,date2)&&!date1_equel_date2(date1,date2));
}
int main(){
    stdate date1=read_date();
    cout<<"\n\n\n";
    stdate date2=read_date();
    if(Date1AfterDate2(date1,date2)){
        cout<<"yes date 1 after date2\n";
    }
    else{
        cout<<"no date 1 is not after date2\n";
    }

}