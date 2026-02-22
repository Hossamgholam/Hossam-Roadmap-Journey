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


void swap(stdate& your_data1,stdate& your_data2){
    stdate tempdate;

    tempdate.day=your_data1.day;
    tempdate.monthe=your_data1.monthe;
    tempdate.year=your_data1.year;

    your_data1.day=your_data2.day;
    your_data1.monthe=your_data2.monthe;
    your_data1.year=your_data2.year;

    your_data2.day=tempdate.day;
    your_data2.monthe=tempdate.monthe;
    your_data2.year=tempdate.year;
}
short diffrence_days(stdate your_date1,stdate your_date2,bool include_end_day=false){

   short difference;
   short swapflagevalue=1;
   if(!date1_lessthane_date2(your_date1,your_date2)){
    swap(your_date1,your_date2);
    swapflagevalue=-1;
   }
    while(date1_lessthane_date2(your_date1,your_date2)){
    difference++;
    add_day_to_date(your_date1);
   }
   
   return include_end_day?++difference*swapflagevalue:difference*swapflagevalue;


  

}


int main(){
    stdate your_date=read_date();
    stdate corrent_date=read_date();

    cout<<"your age by day :"<<diffrence_days(your_date,corrent_date)<<endl;
    cout<<"your age by day include end date:"<<diffrence_days(your_date,corrent_date,true);
}

