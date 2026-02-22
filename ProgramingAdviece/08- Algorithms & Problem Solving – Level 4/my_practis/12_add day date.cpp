#include<iostream>
#include<iomanip>
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

stdate add_day_todate(short your_number,stdate your_date){
    
    
    short number_day_inmonthe=0;
    short number_of_day=your_number+number_day_biging_date(your_date.year,your_date.monthe,your_date.day);
    your_date.monthe=1;
    while(true){
    number_day_inmonthe=number_day_monthe(your_date.year,your_date.monthe);
       if(number_of_day>number_day_inmonthe){
        number_of_day-=number_day_inmonthe;
        your_date.monthe++;
        if(your_date.monthe>12){
            your_date.year++;
            your_date.monthe=1;
        }
       }
       else{
        your_date.day=number_of_day;
        break;
       }

    }
   
    return your_date;
}
int main(){
    stdate date=read_date();
    short number_of_day=read_number("pleaser inter number of day your want to add:");
    date=add_day_todate(number_of_day,date);
    cout<<"date after adding ["<<number_of_day<<"]day is:";
    cout<<date.day<<"/"<<date.monthe<<"/"<<date.year;


}