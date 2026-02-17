#include<iostream>
using namespace std;
enum en_monthes{January =1,February=2,March =3,April =4,May =5,June =6,July=7 ,August =8,September =9,October=10 ,November=11,deciamber=12  };

int read_number_range(string messages,int your_from,int your_to){
   int number_day=0;
   //it read numbmer of monthe untill give it number between 1 and12
   do{
    cout<<messages;cin>>number_day;
   }while(number_day<your_from||number_day>your_to);
   
    
    return number_day;
}

en_monthes read_monthe(){
    //do explicate casting to enum
    return en_monthes(read_number_range("please inter your number of monthes:",1,12));
}

//write monthe
string write_monthe_day_with_switch(en_monthes your_months){
 switch(your_months){
        case en_monthes::January:
        return "monthe is january\n";
        case en_monthes::February:
        return "monthey is february\n";
        case en_monthes::March:
        return "monthey is march\n";
        case en_monthes::April:
        return "monthe is  april\n";
        case en_monthes::May:
        return "monthey is May\n";
        case en_monthes::June:
        return "monthey is June\n";
        case en_monthes::July:
        return "monthey is July:\n";
        case en_monthes::August:
        return "monthey is August:\n";
        case en_monthes::September:
        return "monthey is September:\n";
        case en_monthes::October:
        return "monthey is October:\n";
        case en_monthes::November:
        return "monthey is November:\n";
        case en_monthes::deciamber:
        return "monthey is deciamber:\n";
        default :return "please inter correct number\n";
    };

}
int main(){
    cout<<write_monthe_day_with_switch(read_monthe());
}