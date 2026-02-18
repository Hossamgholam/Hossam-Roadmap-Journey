#include<iostream>
#include<fstream>
#include<vector>
#include<string>
#include<iomanip>
using namespace std;

/*
retreve data from fill as line
split function and storge in vector
storge vector in struct

*/
const string client_fill="myfill.txt";
struct client{
    string account_number;
    string pincode;
    string name;
    string phone;
    float accountbalance;
};
vector<string> splitstring(string your_record,string delemiter="#//#"){
    short pos=0;
    string worde="";
    vector<string>storge;
    while((pos=your_record.find(delemiter))!=std::string::npos){
        worde=your_record.substr(0,pos);
        if(worde!=""){
            storge.push_back(worde);
        }
        your_record.erase(0,pos+delemiter.length());
    }
    if(your_record!=""){
        storge.push_back(your_record);
    }
    return storge;
}
client convert_line_recorde(string your_record,string delemiter="#//#"){
    client my_client;
    vector<string>your_storge;
    your_storge=splitstring(your_record,delemiter);
    my_client.account_number=your_storge[0];
    my_client.pincode=your_storge[1];
    my_client.name=your_storge[2];
    my_client.phone=your_storge[3];
    my_client.accountbalance=stod(your_storge[4]);
    return my_client;
}
vector<client> retreve_data(string your_fill){
    string line;
    fstream my_fill;
    client my_client;
    vector<client> my_vclient;
    my_fill.open(your_fill,ios::in);
    if(my_fill.is_open()){
        while(getline(my_fill,line)){
            my_client=convert_line_recorde(line);
            my_vclient.push_back(my_client);
        }
        my_fill.close();
    }
    return my_vclient;
}
void print_client_data(client your_client){
    cout<<"|"<<setw(15)<<your_client.account_number<<"|"<<setw(10)<<your_client.pincode<<"|"<<setw(40)<<your_client.name<<"|"<<setw(12)<<your_client.phone<<"|"<<setw(12)<<your_client.accountbalance<<"|"<<endl;
}
void print_fill_data(vector<client> your_vclient){
    cout<<"                               client list ("<<your_vclient.size()<<") client(s)."<<endl;
    cout<<"_________________________________________________________________________________________________________________________________\n";
    cout<<"|"<<setw(15)<<"accout number"<<"|"<<setw(10)<<"pin code"<<"|"<<setw(40)<<"client name"<<"|"<<setw(12)<<"phone"<<"|"<<setw(12)<<"balance"<<"|"<<endl;
    cout<<"__________________________________________________________________________________________________________________________________\n";
    for(client i:your_vclient){
        print_client_data(i);
        cout<<endl;
    }
}
int main(){
    vector<client> my_client=retreve_data(client_fill);
    print_fill_data(my_client);
}