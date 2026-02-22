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
bool is_last_day_in_monthe(stdate your_date){
return (number_day_monthe(your_date.year,your_date.monthe)==your_date.day);
}
bool is_last_monthe_in_year(short your_monthe){
    return (your_monthe==12);
}

/*function to add 1 day to date */
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

/*function to add 10day to date*/
void add_xday_to_date(short number_day,stdate& your_date){
    for(int i=0;i<number_day;i++){
        add_day_to_date(your_date);
    }
}


/*function to add 7 day to date*/
void add_one_week_to_date(stdate& your_date){
    for(int i=0;i<7;i++){
        add_day_to_date(your_date);
    }
}

/*function to add 10weak to date*/
void add_xweak_to_date(short number_weak,stdate& your_date){
    for(int i=0;i<number_weak;i++){
        add_one_week_to_date(your_date);
    }
}

/*function to add one monthe*/
void add_monthe_to_date(stdate& your_date){
    if(your_date.monthe==12){
        your_date.year++;
        your_date.monthe=1;
    }
    else{
        your_date.monthe++;
    }
        short day_next_monthe=number_day_monthe(your_date.year,your_date.monthe);
        if(your_date.day>day_next_monthe){
            your_date.day=day_next_monthe;
        }
}

/*function to add xmonthe*/
void add_xmonthe(short number_monthe,stdate& your_date){
    for(short i=0;i<number_monthe;i++){
        add_monthe_to_date(your_date);
    }
}

/*function to add one*/
void add_one_year(stdate& your_date){
    short day_monthe=number_day_monthe(your_date.year,your_date.monthe);
    your_date.year++;
    if(your_date.monthe==2&&your_date.day==day_monthe){/*check if it monthe 2 and is last day in month neithe 28 or29 in year befor increse*/
        your_date.day=number_day_monthe(your_date.year,your_date.monthe);/*it correct day if year aftar incres is leap year it reterun 29 not lepp year return 28*/
        /* befor incress  if it leap year 28
           after incress if it leap year it reread it 28 also

           befor incress if it leap year 28 
           after incress if it not leap year it read it 29 
           */
    }
}

/*function to add xyear*/
void AddxYear(short YourNumber,stdate& YourDate){
    for(int i=0;i<YourNumber;i++){
        add_one_year(YourDate);
    }
}
void AddXYearFaster(short YourNumber,stdate& your_date){
    short day_monthe=number_day_monthe(your_date.year,your_date.monthe);
    your_date.year+=YourNumber;
    if(your_date.monthe==2&&your_date.day==day_monthe){/*check if it monthe 2 and is last day in month neithe 28 or29 in year befor increse*/
        your_date.day=number_day_monthe(your_date.year,your_date.monthe);/*it correct day if year aftar incres is leap year it reterun 29 not lepp year return 28*/
        
    }
}
void AddXYearFaster2(short YourNumber,stdate& YourDate){
    YourDate.year+=YourNumber;
}

/*function to add 1 decade*/

void AddOneDecade(stdate& YourDate){
    YourDate.year+=10;
}

/*fuction to add x decade*/
void AddXDecade(short YourNumber ,stdate& YourDate){
    for(int i=0;i<YourNumber*10;i++){
        add_one_year(YourDate);
    }
}

void AddXDecadeFaster(short YourNumber,stdate& YourDate){
    YourDate.year+=(YourNumber*10);
}

/*function to add century */

void AddCentury(stdate& YourDate){
    YourDate.year+=100;
}
void Addmillennium(stdate& YourDate){
    YourDate.year+=1000;
}
int main(){
    stdate my_date=read_date();

    /*
    
    */
    add_day_to_date(my_date);cout<<"\n";
    cout<<"01_adding one day is:  "<<formate_date(my_date);

    add_xday_to_date(10,my_date);cout<<"\n";
    cout<<"02 adding 10 day is:   "<<formate_date(my_date);


    add_one_week_to_date(my_date);cout<<"\n";
    cout<<"03 adding 7day is:     "<<formate_date(my_date);


    add_xweak_to_date(10,my_date);cout<<"\n";
    cout<<"04 adding 10week is:   "<<formate_date(my_date);

    add_monthe_to_date(my_date);cout<<"\n";
    cout<<"05 adding monthe is:  "<<formate_date(my_date);

    add_xmonthe(5,my_date);cout<<"\n";
    cout<<"06 adding 5 monthe is:  "<<formate_date(my_date);

   add_one_year(my_date);cout<<"\n";
   cout<<"07 adding one year is :  "<<formate_date(my_date);

   AddxYear(10,my_date);cout<<"\n";
   cout<<"08 adding 10 year is:  "<<formate_date(my_date);

   //AddXYearFaster(10,my_date);cout<<"\n";
   //cout<<"09 adding 10 year faster is:  "<<formate_date(my_date);

   AddXYearFaster2(10,my_date);cout<<"\n";
   cout<<"10 adding 10 year is:  "<<formate_date(my_date);

   AddOneDecade(my_date);cout<<"\n";
   cout<<"11 adding one decade is :   "<<formate_date(my_date);

   AddXDecade(10,my_date);cout<<"\n";
   cout<<"12 adding 10 decade is:   "<<formate_date(my_date);

   AddXDecadeFaster(10,my_date);cout<<"\n";
   cout<<"13 adding 10 decade faster is:   "<<formate_date(my_date);

   AddCentury(my_date);cout<<"\n";
   cout<<"14 adding century is:   "<<formate_date(my_date);

   Addmillennium(my_date);cout<<"\n";
   cout<<"14 adding century is:   "<<formate_date(my_date);
}