#include<iostream>
#include<string>
#include<vector>
using namespace std;
/*
read string
storge in vectere
print vecter
*/
string read_string(){
    string name;
    cout<<"please inter your_char: ";getline(cin,name);

    return name;
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
void print_vector(vector<string> &your_storge){
    cout<<"tokens :"<<your_storge.size()<<endl;
    for(string &item:your_storge){
        cout<<item<<endl;
    }
}
int main(){
 string name=read_string();
 vector<string>v;
 v=split_words(name," ");
 print_vector(v);

}