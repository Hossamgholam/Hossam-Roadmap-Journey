#include<iostream>
#include<string>
using namespace std;
string read_string(){
    string name;
    cout<<"please inter your_string: ";getline(cin,name);

    return name;
}



string upper_letter(string name){
    bool frist_leter=true;
    for(int i=0;i<name.length();i++){
        
            name[i]=toupper(name[i]);
    }
    return name;
}

string lower_letter(string name){
    bool frist_leter=true;
    for(int i=0;i<name.length();i++){
        
            name[i]=tolower(name[i]);
    }
    return name;
}

int main(){
    string s=read_string();
    
  
    cout<<"string after upper:\n";
    s=upper_letter(s);
    cout<<s<<endl;

    cout<<"string after lower:\n";
    s=lower_letter(s);
    cout<<s;
}