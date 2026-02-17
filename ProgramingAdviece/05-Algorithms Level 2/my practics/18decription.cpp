#include<iostream>
#include<string>
using namespace std;
string read_name(string massage){
    string your_name;
    cout<<massage;getline(cin,your_name);
    return your_name;

}
string encription(string your_name,int your_encriptionkey){
    for(int i=1;i<=your_name.length();i++){
        your_name[i]=char((int)your_name[i]+your_encriptionkey);
    }
    return your_name;
}
string decription(string your_name,int your_encriptionkey){
    for(int i=1;i<=your_name.length();i++){
        your_name[i]=char((int)your_name[i]-your_encriptionkey);
    }
    return your_name;
}
int main(){
    const int encriptionkey=2;

    string name=read_name("please inter your name:");
    string encription_name=encription(name,encriptionkey);
    string decription_name=decription(encription_name,encriptionkey);
    cout<<"your name is :"<<name<<"\n";
    cout<<"your name aftar encription:"<<encription_name<<"\n";
    cout<<"your name after decription:"<<decription_name<<"\n";


}