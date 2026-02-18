#include<iostream>
#include<string>
using namespace std;
string read_string(){
    string name;
    cout<<"please inter your_string: ";getline(cin,name);

    return name;
}

string frist_letter(string name){
    for(int i=0;i<name.length();i++){
        if(i==0){
           name[i]=tolower(name[i]);
        }
        if (name[i]==' '){
            name[i+1]=tolower(name[i+1]);
        }
        
        
    }
    return name;
}

string frist_char(string name){
    bool frist_leter=true;
    for(int i=0;i<name.length();i++){
        if(name[i]!=' '&& frist_leter){
            name[i]=tolower(name[i]);
        }
        
        frist_leter=(name[i]==' ')?true:false;
    }
    return name;
}

int main(){
    string s=read_string();
    cout<<"the fris charater from string:\n";
  
    
    s=frist_letter(s);
    cout<<s;
}