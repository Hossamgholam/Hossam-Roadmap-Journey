#include<iostream>
#include<ctime>
using namespace std;
struct stdate{
    short day=11;
    short monthe=5;
    short year=2024;
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

stdate SystemDay(){
    stdate current_day;
    time_t t=time(0);
    tm* gmtm=localtime(&t);
    current_day.year=gmtm->tm_year+1900;
    current_day.monthe=gmtm->tm_mon+1;
    current_day.day=gmtm->tm_mday;
    return current_day;
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
short DayOfWeakOrder(short year,short monthe,short day){
    short a=(14-monthe)/12;
    short y=year-a;
    short m=monthe+(12*a)-2;
    return(day+y+(y/4)-(y/100)+(y/400)+((31*m)/12))%7;
   

}

string formate_date(stdate your_date,string delemiter="/"){
    return to_string(your_date.day)+delemiter+to_string(your_date.monthe) +delemiter+to_string(your_date.year);
}
string formate_day(stdate YourDay){
    
    string DayName=day_name(DayOfWeakOrder(YourDay));
    string DateInFormate=formate_date(YourDay);
    return "today is " +DayName+" , "+DateInFormate;
}
bool IsEndOfWeak(stdate YourDate){
    short DayOrder=DayOfWeakOrder(YourDate);
    if(DayOrder==6){
        return true;
    }
    return false;

    //return DayOrder==6
}

bool IsWeakEnd(stdate YourDate){
    short DayOrder=DayOfWeakOrder(YourDate);
    if(DayOrder==5||DayOrder==6){
        return true;
    }
    return false;

    //return Dayorder==5||Dayorder==6
}

bool IsBusinessDay(stdate YourDate){
    short DayOrder=DayOfWeakOrder(YourDate);
    if(DayOrder!=5&&DayOrder!=6){
        return true;
    }
    return false;

    //return !IsWeakEnd();
}

short DaysUntilTheEndOfWeak(stdate YourDate){
    short DayOrder=DayOfWeakOrder(YourDate);
    return 6-DayOrder;

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



bool date1_lessthane_date2(stdate date1,stdate date2){
   return (date1.year<date2.year)?true:((date1.year==date2.year)?(date1.monthe<date2.monthe?true:(date1.monthe==date2.monthe?date1.day<date2.day:false)):false);
}


short diffrence_days(stdate your_date1,stdate your_date2,bool include_end_day=false){
   

   short difference=0;
   while(date1_lessthane_date2(your_date1,your_date2)){
    difference++;
    add_day_to_date(your_date1);
   }
   
   return include_end_day?++difference:difference;

}
short DaysUntilTheEndOfMonthe(stdate YourDate){
    stdate date2;
    date2.day=MontheDays(YourDate.year,YourDate.monthe);
    date2.monthe=YourDate.monthe;
    date2.year=YourDate.year;

    return diffrence_days(YourDate,date2,true);
}

short DaysUntilTheEndOfYear(stdate YourDate){
 stdate date2;
 date2.day=31;
 date2.monthe=12;
 date2.year=YourDate.year;
short dif= diffrence_days(YourDate,date2,true);
return dif;
}


int main(){
    stdate current_day=read_date();
    cout<<formate_day(current_day)<<"\n\n";

    cout<<"is it end of weak?\n";
    if(IsEndOfWeak(current_day)){
        cout<<"yeas end of weak\n\n";
    }
    else{
        cout<<"no not end of weak\n\n";
    }


    cout<<"is it weakend?\n";
    if(IsWeakEnd(current_day)){
        cout<<"yes it is aweek en\n\n";
    }
    else{
        cout<<"no not a weak end\n\n";
    }
    

    cout<<"it is bussiness day?\n";
    if(IsBusinessDay(current_day)){
        cout<<"yes it is bussiness day\n\n";
    }
    else{
        cout<<"no it not bussiness day\n\n";
    }

    cout<<"day untill end of week :  "<<DaysUntilTheEndOfWeak(current_day)<<endl;
    cout<<"day untill end of monthe :  "<<DaysUntilTheEndOfMonthe(current_day)<<endl;
    cout<<"day untill end of year :  "<<DaysUntilTheEndOfYear(current_day)<<endl;
    
}