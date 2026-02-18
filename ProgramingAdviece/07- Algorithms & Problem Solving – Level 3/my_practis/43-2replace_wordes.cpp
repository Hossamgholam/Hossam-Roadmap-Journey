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

vector<string> split_words(string your_string,string your_delim){
    string delim=your_delim;
    short pos=0;
    string word;
    vector<string>storg;
    while((pos=your_string.find(delim))!=std::string::npos){
        word=your_string.substr(0,pos);
        if(word!=""){
            storg.push_back(word);
        }
        your_string.erase(0,pos+delim.length());
    }
    if(your_string!=""){
        storg.push_back(your_string);
    }
    return storg;
}

string lower_letter(string name){
    bool frist_leter=true;
    for(int i=0;i<name.length();i++){
        
            name[i]=tolower(name[i]);
    }
    return name;
}
string join_string(vector<string>your_test,string delimter){
    string your_name="";
    vector<string>::iterator item;
    for(item=your_test.begin();item<your_test.end();item++){
        your_name=your_name+*item+delimter;
    }
    return your_name.substr(0,your_name.length()-delimter.length());
}

string replace_worde_split(string your_statment,string sreplace,string storeplace,bool match=true){
    vector<string>storge=split_words(your_statment," ");
    for(string& i:storge){
        if(match){
            if(i==sreplace){
                i=storeplace;
            }
        }
        else{
            if(lower_letter(i)==lower_letter(sreplace)){
                i=storeplace;
            }
        }
    }
    return join_string(storge," ");
}




int main(){
    
string statment=read_string();
string worde1=read_word("please inter word your want to replace:");
string worde2=read_word("please inter word your want to put:");

cout<<"the statment withe match:"<<replace_worde_split(statment,worde1,worde2)<<endl;
cout<<"the statment witout match:"<<replace_worde_split(statment,worde1,worde2,false)<<endl;





}
