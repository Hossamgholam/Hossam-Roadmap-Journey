#include<iostream>
using namespace std;
struct client{
    string account_number;
    string pincode;
    string name;
    string phone;
    float accountbalance;
};

void read_info(client& your_client){
    cout<<"please inter your account_number";cin>>your_client.account_number;
    cout<<"please inter your pincode:";cin>>your_client.pincode;
    cin.ignore(1,'\n');
    cout<<"please inter your name:";getline(cin,your_client.name);
    cout<<"pleaser inter your phone:";cin>>your_client.phone;
    cout<<"please inter accountbalance:";cin>>your_client.accountbalance;
}

string conver_record_line(client your_client,string delemiter="#//#"){
    string line="";
    line=line+your_client.account_number+delemiter;
    line=line+your_client.pincode+delemiter;
    line=line+your_client.name+delemiter;
    line=line+your_client.phone+delemiter;
    line=line+to_string(your_client.accountbalance);
    return line;
}
int main(){
    client client1;
    read_info(client1);
    cout<<"client record for saving is:"<<endl;
    cout<<conver_record_line(client1);
}