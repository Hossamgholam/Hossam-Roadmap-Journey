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
bool leap_year(int your_year){
   return  (your_year%400==0||(your_year%4==0&&(your_year%100!=0)))?true:false;
}

short number_day_monthe(int your_year,int your_monthe){
    if(your_monthe<1||your_monthe>12){
        return 0;
    }
    short arrydaymonthe[12]={31,28,31,30,31,30,31,31,30,31,30,31};
    short number_day=(your_monthe==2)?(leap_year(your_year)?29:28):arrydaymonthe[your_monthe-1];
    return number_day;
}

short number_day_biging_date(short your_year,short your_monthe,short your_day){
    short total_day=0;
    for(short i=1;i<=your_monthe-1;i++){
        total_day+=number_day_monthe(your_year,i);
    }
    total_day+=your_day;
    return total_day;
}
bool date1_lessthane_date2(stdate date1,stdate date2){
    /*
    if(date1.year==date2.year){
        short number_of_day1=number_day_biging_date(date1.year,date1.monthe,date1.day);
        short number_of_day2=number_day_biging_date(date2.year,date2.monthe,date2.day);
        if(number_of_day1<number_of_day2){
            return true;
        }
        else{
            return false;
        }
    }
    else if(date1.year<date2.year){
        return true;
    }
    else{
        return false;
    }
    */
   return (date1.year<date2.year?true:(date1.year==date2.year?(date1.monthe<date2.monthe?true:(date1.monthe==date2.monthe?date1.day<date2.day:false)):false));
}
int main(){
    stdate date1=read_date();
    cout<<"\n\n\n";
    stdate date2=read_date();
    if(date1_lessthane_date2(date1,date2)){
        cout<<"yes date 1 is less than date2\n";
    }
    else{
        cout<<"no date 1 is not less than date2\n";
    }

}