#include<iostream>
#include<iomanip>
using namespace std;
short read_number(string massage){
  short number;
  cout<<massage;cin>>number;
  return number;
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
/*

void monthe_calender(short your_year,short your_monthe,short your_day,short& your_counter){
    short number_day=number_day_monthe(your_year,your_monthe);
    for(int i=1;i<=number_day;i++){
        if(i!=your_day){
            your_counter++;
        }
        else{
            your_counter++;
            break;
        }
    }
    
    
}

short year_calendar(short your_year,short your_monthe,short your_day){
    short counter=0;
    for(int i=1;i<12;i++){
        if(i!=your_monthe){
            counter+=number_day_monthe(your_year,i);
        }
        else{
            monthe_calender(your_year,i,your_day,counter);
            break;
        }
    }
    return counter;

}
*/
short number_day_biging_year(short your_year,short your_monthe,short your_day){
    short total_day=0;
    for(short i=1;i<=your_monthe-1;i++){
        total_day+=number_day_monthe(your_year,i);
    }
    total_day+=your_day;
    return total_day;
}
int main(){
short day=read_number("please inter a day?");
short monthe=read_number("please inter monthe?");
short year=read_number("pleasse inter a year?");
cout<<"number of day from beggingn year is:"<<number_day_biging_year(year,monthe,day);


}