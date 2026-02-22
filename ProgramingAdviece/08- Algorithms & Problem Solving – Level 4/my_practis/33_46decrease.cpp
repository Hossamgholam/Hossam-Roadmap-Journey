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
string formate_date(stdate your_date,string delemiter="/"){
    return to_string(your_date.day)+delemiter+to_string(your_date.monthe) +delemiter+to_string(your_date.year);
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
bool is_frist_day_in_monthe(stdate your_date){
return (your_date.day==1);
}
bool is_frist_monthe_in_year(short your_monthe){
    return (your_monthe==1);
}

/*function to Decrease 1 day to date */
void DecreaseOneDay(stdate &your_date){
    if(is_frist_day_in_monthe(your_date)){
        if(is_frist_monthe_in_year(your_date.monthe)){
            your_date.year--;
            your_date.monthe=12;
            your_date.day=31;
        }
        else{
            your_date.monthe--;
            your_date.day=number_day_monthe(your_date.year,your_date.monthe);
        }
    }
    else{
        your_date.day--;
    }
}

void DecreaseXDay(short YourNumber,stdate& your_date){
    for(int i=0;i<YourNumber;i++){
        DecreaseOneDay(your_date);
    }
}

/*function to Decrease oneweake to date*/
void DecreaseOneWeake(stdate& your_date){
    for(int i=0;i<7;i++){
      DecreaseOneDay(your_date);
    }
}

void DecreaseXWeake(short number_weak,stdate& your_date){
    for(int i=0;i<number_weak;i++){
        DecreaseOneWeake(your_date);
    }
}

/*function to Decrease one monthe*/
void DecreaseOneMonthe(stdate& your_date){
    if(your_date.monthe==1){
        your_date.year--;
        your_date.monthe=12;
    }
    else{
        your_date.monthe--;
    }
        short day_previous_monthe=number_day_monthe(your_date.year,your_date.monthe);
        if(your_date.day>day_previous_monthe){
            your_date.day=day_previous_monthe;
        }
}

/*function to Decrease xmonthe*/
void DecreaseXMonthe(short number_monthe,stdate& your_date){
    for(short i=0;i<number_monthe;i++){
        DecreaseOneMonthe(your_date);
    }
}

/*function to Decrease one year*/
void DecreaseYear(stdate& YourDate){
    YourDate.year--;
}
void DecreaseOneYear(stdate& your_date){
    short day_monthe=number_day_monthe(your_date.year,your_date.monthe);
    your_date.year--;
    if(your_date.monthe==2&&your_date.day==day_monthe){/*check if it monthe 2 and is last day in month neithe 28 or29 in year befor increse*/
        your_date.day=number_day_monthe(your_date.year,your_date.monthe);/*it correct day if year aftar incres is leap year it reterun 29 not lepp year return 28*/
        /* befor incress  if it leap year 28
           after incress if it leap year it reread it 28 also

           befor incress if it leap year 28 
           after incress if it not leap year it read it 29 
           */
    }
}

/*function to Decrease xyear*/
void DecreasexYear(short YourNumber,stdate& YourDate){
    for(int i=0;i<YourNumber;i++){
        DecreaseYear(YourDate);
    }
}
void DecreaseXYearFaster(short YourNumber,stdate& your_date){
    short day_monthe=number_day_monthe(your_date.year,your_date.monthe);
    your_date.year-=YourNumber;
    if(your_date.monthe==2&&your_date.day==day_monthe){/*check if it monthe 2 and is last day in month neithe 28 or29 in year befor increse*/
        your_date.day=number_day_monthe(your_date.year,your_date.monthe);/*it correct day if year aftar incres is leap year it reterun 29 not lepp year return 28*/
        
    }
}
void DecreaseXYearFaster2(short YourNumber,stdate& YourDate){
    YourDate.year-=YourNumber;
}

/*function to Decrease 1 decade*/

void DecreaseOneDecade(stdate& YourDate){
    YourDate.year-=10;
}

/*fuction to Decrease x decade*/
void DecreaseXDecade(short YourNumber ,stdate& YourDate){
    for(int i=0;i<YourNumber*10;i++){
        DecreaseYear(YourDate);
    }
}

void DecreaseXDecadeFaster(short YourNumber,stdate& YourDate){
    YourDate.year-=(YourNumber*10);
}

/*function to Decrease century */

void DecreaseCentury(stdate& YourDate){
    YourDate.year-=100;
}
void Decreasemillennium(stdate& YourDate){
    YourDate.year-=1000;
}

int main(){
    stdate my_date=read_date();

    /*


    
    */
    DecreaseOneDay(my_date);cout<<"\n";
    cout<<"01_Decreaseing one day is:  "<<formate_date(my_date);

    DecreaseXDay(10,my_date);cout<<"\n";
    cout<<"02 Decreaseing 10 day is:   "<<formate_date(my_date);

    DecreaseOneWeake(my_date);cout<<"\n";
    cout<<"03 Decreaseing 7day is:     "<<formate_date(my_date);


    DecreaseXWeake(10,my_date);cout<<"\n";
    cout<<"04 Decreaseing 10week is:   "<<formate_date(my_date);

    DecreaseOneMonthe(my_date);cout<<"\n";
    cout<<"05 Decreaseing monthe is:  "<<formate_date(my_date);

    DecreaseXMonthe(5,my_date);cout<<"\n";
    cout<<"06 Decreaseing 5 monthe is:  "<<formate_date(my_date);

   DecreaseYear(my_date);cout<<"\n";
   cout<<"07 Decreaseing one year is :  "<<formate_date(my_date);

   DecreasexYear(10,my_date);cout<<"\n";
   cout<<"08 Decreaseing 10 year is:  "<<formate_date(my_date);

   //DecreaseXYearFaster(10,my_date);cout<<"\n";
   //cout<<"09 Decreaseing 10 year faster is:  "<<formate_date(my_date);

   DecreaseXYearFaster2(10,my_date);cout<<"\n";
   cout<<"10 Decreaseing 10 year is:  "<<formate_date(my_date);

   DecreaseOneDecade(my_date);cout<<"\n";
   cout<<"11 Decreaseing one decade is :   "<<formate_date(my_date);

   DecreaseXDecade(10,my_date);cout<<"\n";
   cout<<"12 Decreaseing 10 decade is:   "<<formate_date(my_date);

   DecreaseXDecadeFaster(10,my_date);cout<<"\n";
   cout<<"13 Decreaseing 10 decade faster is:   "<<formate_date(my_date);

   DecreaseCentury(my_date);cout<<"\n";
   cout<<"14 Decreaseing century is:   "<<formate_date(my_date);

   Decreasemillennium(my_date);cout<<"\n";
   cout<<"14 Decreaseing century is:   "<<formate_date(my_date);
}
