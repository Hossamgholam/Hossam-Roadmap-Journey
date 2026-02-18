#include<iostream>
#include<string>
using namespace std;
string read_string(){
    string name;
    cout<<"please inter your_string: ";getline(cin,name);

    return name;
}

void frist_letter(string name){
    for(int i=0;i<name.length();i++){
        if(i==0){
            cout<<name[i]<<endl;
        }
        if(name[i]==' '){
            cout<<name[i+1]<<endl;
        }
    }
}

void frist_char(string name){
    bool frist_leter=true;
    for(int i=0;i<name.length();i++){
        if(name[i]!=' '&& frist_leter){
            cout<<name[i]<<endl;
        }
        frist_leter=(name[i]==' ')?true:false;
    }
}

int main(){
    cout<<"the fris charater from string:\n";
    frist_letter(read_string());
    frist_char(read_string());
}