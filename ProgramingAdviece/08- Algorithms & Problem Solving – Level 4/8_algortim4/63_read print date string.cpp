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
string DateTostring(StDate YourDate){
    return to_string(YourDate.day)+"/"+to_string(YourDate.monthe)+"/"+to_string(YourDate.year);
}
int main(){
    string Date=ReadStringDate();
    StDate structDate=StringToDate(Date);

    cout<<"\n\ndate:  "<<structDate.day<<endl;
    cout<<"monthe:"<<structDate.monthe<<endl;
    cout<<"year:  "<<structDate.year<<endl<<endl;

    cout<<"your entered:"<<DateTostring(structDate);


}