#include<iostream>
using namespace std;
enum enweakday{sun=1,mon=2,tue=3,wed=4,thu=5,fri=6,sat=7};
void show_weak_table(){
    cout<<"***************************************\n";
    cout<<"             weake day                 \n";
    cout<<"***************************************\n";
    cout<<"1:for sunday\n";
    cout<<"2:for monday\n";
    cout<<"3:for tuesday\n";
    cout<<"4:for wndnesday\n";
    cout<<"5:for thursday\n";
    cout<<"6:for friday\n";
    cout<<"7:for saturday\n";
    cout<<"****************************************\n";
    cout<<"please inter number of day";
}
//it read number of day untill give number between 1 and 7
int read_number_range(string messages,int your_from,int your_to){
   int number_day=0;
   do{
    cout<<messages;cin>>number_day;
   }while(number_day<your_from||number_day>your_to);
   
    
    return number_day;
}


enweakday read_day(){
    return (enweakday) read_number_range("please inter number of day:",1,7);
}


string writ_weak_day_with_switch(enweakday your_day){
 switch(your_day){
        case enweakday::fri:
        return "toda is friday\n";
        case enweakday::mon:
        return "today is monday\n";
        case enweakday::sat:
        return "today is saterday\n";
        case enweakday::sun:
        return "toda is  sunday\n";
        case enweakday::thu:
        return "today is thusday\n";
        case enweakday::wed:
        return "today is wedthsday\n";
        case enweakday::tue:
        return "today is tuesday:\n";
        default :return "please inter correct number\n";
    };
}

string writ_weak_day_with_if(enweakday your_day){
   if(your_day==enweakday::fri){
      return "toda is friday\n";
   }
   else if(your_day==enweakday::mon){
      return "today is monday\n";
   }
   else if(your_day==enweakday::sat){
      return "today is saterday\n";
   }
   else if(your_day==enweakday::sun){
      return "today is sunday\n";
   }
   else if(your_day==enweakday::thu){
      return "today is thusday\n";
   }
   else if(your_day==enweakday::tue){
      return "today is wedthsday\n";
   }
   else if(your_day==enweakday::wed){
      return "today is tuesday\n";
   }
   else{
      return "please inter correct number:\n";
   }
}
int main(){

show_weak_table();
cout<<writ_weak_day_with_switch(read_day());
}