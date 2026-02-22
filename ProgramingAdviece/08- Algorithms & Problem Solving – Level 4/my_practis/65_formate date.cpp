#include<iostream>
#include<string>
#include<vector>
using namespace std;
struct StDate{
    int year;
    int monthe;
    int day;
};

string ReadStringDate(){
    string Date;
   
    cout<<"please inter date dd//mm//yyyy:";getline(cin>>ws,Date);
    
    return Date;
}

vector<string> Split(string YourDate,string delemiter){
    string word="";
    short pos=0;
    vector<string>storge;
    while((pos=YourDate.find(delemiter))!=std::string::npos){
        word=YourDate.substr(0,pos);
        if(word!=""){
            storge.push_back(word);
        }
            YourDate.erase(0,pos+delemiter.length());
       
    }
    if(YourDate!=""){
        storge.push_back(YourDate);
    }
    return storge;
}
StDate StringToDate(string YourDate){
    StDate Date;
    vector<string>storge;
    storge=Split(YourDate,"/");
    Date.day=stoi(storge.at(0));
    Date.monthe=stoi(storge.at(1));
    Date.year=stoi(storge.at(2));
    return Date;
}
string replace_worde(string your_string,string want_replace ,string to ){
   short pos=your_string.find(want_replace);
    while((pos=your_string.find(want_replace))!=std::string::npos){
        your_string.replace(pos,want_replace.length(),to); 
    }
    return your_string;
}
string FormatDate(StDate Date,string formate){
   string FormatDateString="";
   FormatDateString=replace_worde(formate,"dd",to_string(Date.day));
   FormatDateString=replace_worde(FormatDateString,"mm",to_string(Date.monthe));
   FormatDateString=replace_worde(FormatDateString,"yyyy",to_string(Date.year));
   return FormatDateString;
}
/*

string FormatDate(StDate Date,string formate){
   if (formate == "dd/mm/yyyy") {
    return to_string(Date.day) + "/" + to_string(Date.monthe) + "/" + to_string(Date.year);
} else if (formate == "yyyy/dd/mm") {
    return to_string(Date.year) + "/" + to_string(Date.day) + "/" + to_string(Date.monthe);
} else if (formate == "mm/dd/yyyy") {
    return to_string(Date.monthe) + "/" + to_string(Date.day) + "/" + to_string(Date.year);
} else if (formate == "mm-dd-yyyy") {
    return to_string(Date.monthe) + "-" + to_string(Date.day) + "-" + to_string(Date.year);
} else if (formate == "dd-mm-yyyy") {
    return to_string(Date.day) + "-" + to_string(Date.monthe) + "-" + to_string(Date.year);
}
    return "day:" + to_string(Date.day) + ", monthe:" + to_string(Date.monthe) + ", year:" + to_string(Date.year);

}
*/   
int main(){
    string Date=ReadStringDate();
    StDate structDate=StringToDate(Date);

   

   cout<<FormatDate(structDate,"dd/mm/yyyy")<<endl;
   cout<<FormatDate(structDate,"yyyy/dd/mm")<<endl;
   cout<<FormatDate(structDate,"mm/dd/yyyy")<<endl;
   cout<<FormatDate(structDate,"mm-dd-yyyy")<<endl;
   cout<<FormatDate(structDate,"dd-mm-yyyy")<<endl;
   cout<<FormatDate(structDate,"Day:dd,monthe:mm,year:yy")<<endl;


}