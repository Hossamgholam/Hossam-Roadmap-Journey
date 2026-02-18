#include<iostream>
#include<vector>
#include<string>
using namespace std;
struct client{
    string account_number;
    string pincode;
    string name;
    string phone;
    float accountbalance;
};

string read_info(){
    string line;
    cout<<"line recorde is:";getline(cin,line);
    return line;
}

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
client convert_line_recorde(vector<string> your_storge){
    client my_client;
    my_client.account_number=your_storge[0];
    my_client.pincode=your_storge[1];
    my_client.name=your_storge[2];
    my_client.phone=your_storge[3];
    my_client.accountbalance=stod(your_storge[4]);
    return my_client;
}
void print_record(client your_client){
    cout<<" your account_number:"<<your_client.account_number<<endl;
    cout<<" your pincode       :"<<your_client.pincode<<endl;

    cout<<" your name          :"<<your_client.name<<endl;
    cout<<" your phone         :"<<your_client.phone<<endl;
    cout<<" accountbalance     :"<<your_client.accountbalance<<endl;
}
int main(){
   cout<<"client record is:\n";
   string client1=read_info();
   print_record(convert_line_recorde(splitstring(client1)));

   cout<<"\nclient record is:\n";
   print_record(convert_line_recorde(splitstring("a12#//#23#//#hossam#//#023092#//#23322")));
}