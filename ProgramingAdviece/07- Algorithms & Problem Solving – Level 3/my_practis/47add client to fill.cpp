#include<iostream>
#include<fstream>
using namespace std;
struct client{
    string account_number;
    string pincode;
    string name;
    string phone;
    float accountbalance;
};

client read_info(){
    client your_client;
    cout<<"please inter your account_number:";getline(cin>>ws,your_client.account_number);
    cout<<"please inter your pincode:";getline(cin,your_client.pincode);
    
    cout<<"please inter your name:";getline(cin,your_client.name);
    cout<<"pleaser inter your phone:";getline(cin,your_client.phone);
    cout<<"please inter accountbalance:";cin>>your_client.accountbalance;
    return your_client;
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
/*

void lineto_fill(string your_line){
    fstream my_fill;
    my_fill.open("myfill.txt",ios::app);
    if(my_fill.is_open()){
        my_fill<<your_line<<endl;
        my_fill.close();
    }
}
*/
void addClient(string line){
    fstream myFile;
    myFile.open("myfill.txt",ios::app);
    if(myFile.is_open()){
        myFile<<line<<endl;
        myFile.close();
    }
}


void start(){
    char repeat='y';
    do{
        client my_client=read_info();
        string line=conver_record_line(my_client);
        addClient(line);
        cout<<"operation is sucsussful :do you want to add new client:";cin>>repeat;
    }while(repeat=='y');
}
int main(){
    start();
}