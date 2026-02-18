#include<iostream>
#include<string>
using namespace std;
string read_string(){
    string name;
    cout<<"please inter your_char: ";getline(cin,name);

    return name;
}

int count_words(string your_string){
    string delim=" ";
    short pos=0;
    string word;
    short counter=0;
    while((pos=your_string.find(delim))!=std::string::npos){
        word=your_string.substr(0,pos);
        if(word!=""){
            counter++;
        }
        your_string.erase(0,pos+delim.length());
    }
    if(your_string!=""){
        counter++;
    }
    return counter;
}
int main(){
 string name=read_string();
    cout<<"the number of words is:"<<count_words(name);
}