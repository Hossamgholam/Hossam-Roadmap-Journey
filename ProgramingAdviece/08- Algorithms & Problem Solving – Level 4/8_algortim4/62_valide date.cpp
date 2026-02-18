#include<iostream>
using namespace std;
struct stdate{
    short day;
    short monthe;
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
bool ValidDays(stdate YourDate){
    short NumberDaysMonthe=number_day_monthe(YourDate.year,YourDate.monthe);
    return NumberDaysMonthe==YourDate.day?true:false;
}
bool ValidMonthe(stdate YourDate){
    return (YourDate.monthe<1||YourDate.monthe>12?false:true);
}
bool ValideDate(stdate YourDate){
    return (ValidDays(YourDate)&&ValidMonthe(YourDate)&&YourDate.year>0)?true:false;
}
bool validedate(stdate YourDate){
    if(YourDate.day<1||YourDate.day>31){
        return false;
    }
    if(YourDate.monthe<1||YourDate.monthe>12){
        return false;
    }
    if(YourDate.monthe==2){
        if(leap_year(YourDate.year)){
            if(YourDate.day>29){
                return false;
            }
        }
        else{
            if(YourDate.day>28){
                return false;
            }
        }
    }
    short NumberDaysMonthe=number_day_monthe(YourDate.year,YourDate.monthe);
    if(YourDate.day>NumberDaysMonthe){
        return false;
    }
    return true;
}

int main(){
    char answer='y';
    do{

    stdate date=read_date();
    if(validedate(date)){
        cout<<"Yes, Date is a valide date:\n";
    }
    else{
        cout<<"No ,Date id not a valide date:\n";
    }
    cout<<"do you want to reapeat:";cin>>answer;
    }while(answer=='y');
}