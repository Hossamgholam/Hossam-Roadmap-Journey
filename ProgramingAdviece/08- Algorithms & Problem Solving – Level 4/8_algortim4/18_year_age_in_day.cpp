#include<iostream>
#include<ctime>
using namespace std;
struct stdate{
    short day=11;
    short monthe=5;
    short year=2024;
};

const stdate concerrent_day;

   
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

stdate system_date(){
    stdate date;
    time_t t=time(NULL);
    tm* now;
    now=localtime(&t);

    date.year=now->tm_year+1900;
    date.monthe=now->tm_mon+1;
    date.day=now->tm_mday;
    return date;
}

short diffrence_days(stdate your_date1,stdate your_date2,bool include_end_day=false){
   

   short difference;
   while(date1_lessthane_date2(your_date1,your_date2)){
    difference++;
    add_day_to_date(your_date1);
   }
   
   return include_end_day?++difference:difference;

}


int main(){
    stdate your_date=read_date();
    stdate corrent_date=system_date();

    cout<<"your age by day :"<<diffrence_days(your_date,corrent_date,true);
}

