#include<iostream>
#include<fstream>
#include<vector>
using namespace std;
/*


*/
const string client_fill="myfill.txt";
struct client{
    string account_number;
    string pincode;
    string name;
    string phone;
    float accountbalance;
    bool marke_delet=false;
    
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

bool search_account(string your_account,vector<client> your_vclient,client& your_client){

    
    for(client i:your_vclient){
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
bool make_marke_client(vector<client>& your_vclient,string your_account){
    for(client& i:your_vclient){
        if(i.account_number==your_account){
            i.marke_delet=true;
            return true;
        }
    }
    return false;
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
client read_client(string your_account){
   client my_client;
    my_client.account_number=your_account;
    cout<<"please inter your pincode:";getline(cin>>ws,my_client.pincode);
    
    cout<<"please inter your name:";getline(cin,my_client.name);
    cout<<"pleaser inter your phone:";getline(cin,my_client.phone);
    cout<<"please inter accountbalance:";cin>>my_client.accountbalance;
    return my_client;
}
void load_data_to_fill(vector<client> your_vclient,string your_fill){
    fstream fill;
    string line="";
    fill.open(your_fill,ios::out);
    if(fill.is_open()){
        for(client i:your_vclient){
            if(i.marke_delet==false){
              
               line= conver_record_line(i);
               fill<<line<<endl;
            }
           
        }
        fill.close();
    }
    
}

void update_client(string your_account,vector<client>& your_vclient){
    client my_client;
    char answer='y';
    if(search_account(your_account,your_vclient,my_client)){
        print_client_info(my_client);
        cout<<"do you want to update client:";cin>>answer;
        if(answer=='y'||answer=='Y'){
            for(client& i:your_vclient){
                if(i.account_number==your_account){
                    i=read_client(your_account);
                    break;
                }
            }
            load_data_to_fill(your_vclient,client_fill);
            
            cout<<"client update succusfull\n";
           
        }
    }
    else{
         cout<<"client with account number("<<your_account<<")not found\n";
         
    }
}
int main(){
    string account_number=read_account();
    vector<client> vclient=load_data_from_fill(client_fill);
    update_client(account_number,vclient);

    

}