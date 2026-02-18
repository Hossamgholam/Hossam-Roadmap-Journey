#include<iostream>
#include<vector>
#include<string>
using namespace std;
/*
read string 
read two words
replace worde
print string after
*/
string read_string(){
    string worde;
    cout<<"pleseas inter your word:";getline(cin,worde);
    return worde;
}

string read_word(string massege){
    string word;
    cout<<massege;cin>>word;
    return word;
}

vector<string> replace_worde(string your_string,string worde1,string worde2,string delimeter){
    int pos=0;
    string word="";
    vector<string> storge;
    while((pos=your_string.find(delimeter))!=std::string::npos){
        word=your_string.substr(0,pos);
        if(word!=""){
            if(word==worde1){
                word=worde2;
            }
            storge.push_back(word);
        }
        your_string.erase(0,pos+delimeter.length());
    }
    if(your_string!=""){
        if(your_string==worde1){
            your_string=worde2;
        }
        storge.push_back(your_string);
    }
    return storge;

}

string join_string(vector<string>your_test,string delimter){
    string your_name="";
    vector<string>::iterator item;
    for(item=your_test.begin();item<your_test.end();item++){
        your_name=your_name+*item+delimter;
    }
    return your_name.substr(0,your_name.length()-delimter.length());
}
string replace_worde(string your_string,string want_replace ,string to ){
   short pos=your_string.find(want_replace);
    while((pos=your_string.find(want_replace))!=std::string::npos){
        your_string.replace(pos,want_replace.length(),to); 
    }
    return your_string;
}
int main(){
    
string statment=read_string();
string worde1=read_word("please inter word your want to replace:");
string worde2=read_word("please inter word your want to put:");
vector<string> storge=replace_worde(statment,worde1,worde2," ");
cout<<"the statement after rpelace worde:"<<join_string(storge," ")<<endl;

cout<<"\nwith abohadhude functon:"<<replace_worde(statment,worde2,worde1);
    
}
