#include<iostream>
using namespace std;
enum encolor{red=1,blue=2,yellow=3,green=4};
enum enweakday{sun=1,mon=2,tue=3,wed=4,thu=5,fri=6,sat=7};

void show_color_table(){
    cout<<"_____________________________________________________\n";
     cout<<"choice your number:\n";
     cout<<"1=red\n";
     cout<<"2=blue\n";
     cout<<"3=yellow\n";
     cout<<"4=green\n";
     cout<<"______________________________________________________\n";
     cout<<"your choices is :"<<endl;
}
encolor readcolor(){
      int number_color;
      cin>>number_color;
      encolor yourcolor=encolor(number_color);///casting 
}
string writecolor( encolor yourcolor){
    if(yourcolor==encolor::blue){
        return"blue\n";
     }
     else if(yourcolor==encolor::red){
        return"red\n";
     }
     else if(yourcolor==encolor::yellow){
        return"yellow\n";
     }
     else{
        return"greem\n";
     }
}

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




enweakday read_weake_day(){
   int number_day;
    cin>>number_day;
    enweakday your_day=enweakday(number_day);
    return your_day;
}




string writ_weak_day_with_switch(enweakday your_day){
 switch(your_day){
        case enweakday::fri:
        return "toda is friday\n";break;
        case enweakday::mon:
        return "today is monday\n";break;
        case enweakday::sat:
        return "today is saterday\n";break;
        case enweakday::sun:
        return "toda is  sunday\n";break;
        case enweakday::thu:
        return "today is thusday\n";break;
        case enweakday::wed:
        return "today is wedthsday\n";break;
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
      cout<<"please inter correct number:\n";
   }
}

int main(){
    
show_color_table();
cout<<writecolor(readcolor());

show_weak_table();
cout<<writ_weak_day_with_switch(read_weake_day());
    
     
}