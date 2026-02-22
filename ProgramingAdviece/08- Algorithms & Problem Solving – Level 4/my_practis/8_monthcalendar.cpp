#include<iostream>
#include<iomanip>
using namespace std;
short read_number(string massage){
  short number;
  cout<<massage;cin>>number;
  return number;
}

bool leap_year(int your_year){
   return  (your_year%400==0||(your_year%4==0&&!(your_year%100==0)))?true:false;
}

short number_day_monthe(int your_year,int your_monthe){
    if(your_monthe<1||your_monthe>12){
        return 0;
    }
    short arrydaymonthe[12]={31,28,31,30,31,30,31,31,30,31,30,31};
    return your_monthe==2?(leap_year(your_year)?29:28):arrydaymonthe[your_monthe-1];
}
short calculat_day_order(short year,short monthe,short day=1){
    short a=(14-monthe)/12;
    short y=year-a;
    short m=monthe+(12*a)-2;
    short d=(day+y+(y/4)-(y/100)+(y/400)+((31*m)/12))%7;
    return d;

}
string monthe_name(short monthe_number){
    string arraday[12]={"January", "February", "March", "April", "May", "June", "July", "August"," September", "October", "November", "December"};
    return arraday[monthe_number-1];
}
void print_calender(short your_monthe,short your_year){
    short number_day=number_day_monthe(your_year,your_monthe);
    short start_day=calculat_day_order(your_year,your_monthe);
    printf("_________________________%s______________________\n",monthe_name(your_monthe).c_str());

    printf("  sun  mon  tue  wed  thu  fri  sat\n");
    int i;
    for(i=0;i<start_day;i++)
        printf("     ");
    
    for(short y=1;y<=number_day;y++){
        printf("%5d",y);
        
            if(++i==7){
                i=0;
                cout<<endl;
            }
       
    }
}

int main(){
short year=read_number("pleasse inter a year?");
short monthe=read_number("pleasse inter a monthe?");

print_calender(monthe,year);
}