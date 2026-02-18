#include<iostream>
#include<fstream>
#include<vector>
using namespace std;
/*
struct client
read_account number
convert fille to vector client
serch by account number
print result

*/
struct client{
    string account_number;
    string pincode;
    string name;
    string phone;
    float accountbalance;
};

string read_account(){
    string my_account_number;
    cout<<"please inter account number of client:";cin>>my_account_number;
    return my_account_number;
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
vector<client> load_data_from_fill(string your_fill){
    fstream my_fill;
    string line;
    vector<client> my_vclient;
    client my_client;
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
bool search_account(string your_account,client& your_client){
    vector<client> vclient=load_data_from_fill("myfill.txt");
    for(client i:vclient){
        if(i.account_number==your_account){
            your_client=i;
            return true;
        }
    }
    return false;
    
}
void print_client_info(client your_client){
    cout<<"the client is exist and information is\n";
        cout<<" your account_number:"<<your_client.account_number<<endl;
        cout<<" your pincode       :"<<your_client.pincode<<endl;

        cout<<" your name          :"<<your_client.name<<endl;
        cout<<" your phone         :"<<your_client.phone<<endl;
        cout<<" accountbalance     :"<<your_client.accountbalance<<endl;
}
int main(){
    string account_number=read_account();
    client client_we;
    if(search_account(account_number,client_we)){
        print_client_info(client_we);
    }
    else{
        cout<<"client with account number("<<account_number<<")not found\n";
    }
    
    

}