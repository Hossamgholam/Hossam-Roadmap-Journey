#include<iostream>
using namespace std;
struct stdate{
    short year;
    short monthe;
    short day;
};
short ReadNumber(string massage){
    short number;
    cout<<massage;cin>>number;
    return number;
}
stdate ReadDate(){
    stdate YourDate;
    YourDate.day=ReadNumber("pleaser inter your day      :");
    YourDate.monthe=ReadNumber("pleaser inter your monthe:");
    YourDate.year=ReadNumber("pleaser inter your year    :");
    return YourDate;
}


string day_name(short day_number){
    string arraday[7]={"Sun","Mon","Tue","Wed","Thu","Fri","Sat"};
    return arraday[day_number];
}
short DayOfWeakOrder(stdate YourDate){
    short a=(14-YourDate.monthe)/12;
    short y=YourDate.year-a;
    short m=YourDate.monthe+(12*a)-2;
    return(YourDate.day+y+(y/4)-(y/100)+(y/400)+((31*m)/12))%7;
}
string formate_date(stdate your_date,string delemiter="/"){
    return to_string(your_date.day)+delemiter+to_string(your_date.monthe) +delemiter+to_string(your_date.year);
}
string VactionForm(stdate YourDate){
    return day_name(DayOfWeakOrder(YourDate))+" , "+formate_date(YourDate);
}

bool IsBusinessDay(stdate YourDate){
    short DayOrder=DayOfWeakOrder(YourDate);
    if(DayOrder!=5&&DayOrder!=6){
        return true;
    }
    return false;

    //return !IsWeakEnd();
}
bool leap_year(int your_year){
   return  (your_year%400==0||(your_year%4==0&&(your_year%100!=0)))?true:false;
}
short MontheDays(short your_year,short your_monthe){
    if(your_monthe<1||your_monthe>12){
        return 0;
    }
    short arrydaymonthe[12]={31,28,31,30,31,30,31,31,30,31,30,31};
    short number_day=(your_monthe==2)?(leap_year(your_year)?29:28):arrydaymonthe[your_monthe-1];
    return number_day;
}
bool is_last_day_in_monthe(stdate your_date){
return (MontheDays(your_date.year,your_date.monthe)==your_date.day);
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
    
   return (date1.year=date2.year?(date1.monthe==date2.monthe?(date1.day==date2.day?true:false):false):false);
}
short ActualVactionDays(stdate YourDate1,stdate YourDate2){
    short AcutalDays=0;
    while(!date1_equel_date2(YourDate1,YourDate2)){
        if(IsBusinessDay(YourDate1)){
            AcutalDays++;
        }
        add_day_to_date(YourDate1);
    }
    return AcutalDays;
}
int main(){
    stdate date1,date2;
    cout<<"vaction starts:\n";
    date1=ReadDate();
    cout<<"vaction ends:\n";
    date2=ReadDate();

    cout<<"vaction from: "<<VactionForm(date1)<<endl;
    cout<<"vaction from: "<<VactionForm(date2)<<endl;

    cout<<"actucal vaction days:"<<ActualVactionDays(date1,date2);

}