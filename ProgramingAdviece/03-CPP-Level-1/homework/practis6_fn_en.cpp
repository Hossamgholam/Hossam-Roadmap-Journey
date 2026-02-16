#include<iostream>
using namespace std;
/*
enum enweak{}
viod  showweakeday();
enweak readday()
string writday

*/

enum enweakday{sun=1,mon=2,tue=3,wed=4,thu=5,fri=6,sat=7};

void show_weak_day(){
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

enweakday readday(){

    int number_day;
    cin>>number_day;
    
    return enweakday(number_day);
}

string writday(enweakday yourday){
    switch(yourday){
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
        default :return "please inter correct number\n";
    };
}

int main(){
     show_weak_day();
    cout<< writday(readday());
     
}