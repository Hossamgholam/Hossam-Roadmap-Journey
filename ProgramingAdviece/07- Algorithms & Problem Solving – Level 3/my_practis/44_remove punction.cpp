#include<iostream>
#include<cctype>
using namespace std;
string read_string(){
    string worde;
    cout<<"pleseas inter your word:";getline(cin,worde);
    return worde;
}
void remove_punction(string your_string){
    for(int i=0;i<your_string.length();i++){
        if(ispunct(your_string[i])){
            continue;
        }
        else{
            cout<<your_string[i];
        }
    }
    
}
string remove_punctionn(string your_string){
    string s="";
    for(int i=0;i<your_string.length();i++){
        if(!ispunct(your_string[i])){
            s=s+your_string[i];
        }
    }
    return s;
    
}
int main(){
    string statment=read_string();
    remove_punction(statment);
    cout<<endl;

    cout<<remove_punctionn(statment);
}