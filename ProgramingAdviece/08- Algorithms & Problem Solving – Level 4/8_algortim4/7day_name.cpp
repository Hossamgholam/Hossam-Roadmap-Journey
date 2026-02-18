#include<iostream>
using namespace std;
/*
read number(messange);
print date in format(year,monthe,day);
int calculat day order(y,m,d);
print dar name(d)
*/
short read_number(string massege){
    short number;
    do{
    cout<<massege<<":";cin>>number;
    }while(number<0);
    return number;
}
string formate_date(short year,short monthe,short day,string delemiter="/"){
    return to_string(day)+delemiter+to_string(monthe) +delemiter+to_string(year);
}
short calculat_day_order(short year,short monthe,short day){
    short a=(14-monthe)/12;
    short y=year-a;
    short m=monthe+(12*a)-2;
    return(day+y+(y/4)-(y/100)+(y/400)+((31*m)/12))%7;
   

}
string day_name(short day_number){
    string arraday[7]={"Sun","Mon","Tue","Wed","Thu","Fri","Sat"};
    return arraday[day_number];
}
int main(){

    short year=read_number("please inter your year:");
    short monthe=read_number("please inter your monthe");
    short day=read_number("please inter  your day");
    short day_number=calculat_day_order(year,monthe,day);

    cout<<"date     :"<<formate_date(year,monthe,day)<<endl;
    cout<<"day order:"<<day_number+1<<endl;
    cout<<"day name :"<<day_name(day_number);


}