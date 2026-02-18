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

vector<string> replace_worde_match(string your_string,string worde1,string worde2,string delimeter){
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

string lower_letter(string name){
    bool frist_leter=true;
    for(int i=0;i<name.length();i++){
        
            name[i]=tolower(name[i]);
    }
    return name;
}

vector<string> replace_worde_dont_match(string your_string,string worde1,string worde2,string delimeter){
    int pos=0;
    string word="";
    vector<string> storge;
    worde1=lower_letter(worde1);
    while((pos=your_string.find(delimeter))!=std::string::npos){
        word=your_string.substr(0,pos);
        word=lower_letter(word);
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

string replace(string your_string,string worde1,string worde2,string delimeter,bool match=true){
   string your_statment="";
    if(match==true){
      your_statment=join_string(replace_worde_match(your_string,worde1,worde2,delimeter),delimeter);
    }
    else{
        your_statment=join_string(replace_worde_dont_match(your_string,worde1,worde2,delimeter),delimeter);
    }
    return your_statment;
}

int main(){
    
string statment=read_string();
string worde1=read_word("please inter word your want to replace:");
string worde2=read_word("please inter word your want to put:");

cout<<"the statment withe match:"<<replace(statment,worde1,worde2," ");
cout<<"\n\n";
cout<<"the stamtment without matcht:"<<replace(statment,worde1,worde2," ",false);



}
