#include<iostream>
#include<string>
using namespace std;
/*
read string 
string wored
*/

string read_string(){
    string name;
    cout<<"please inter your_char: ";getline(cin,name);

    return name;
}
void print_word(string your_string){
    for(int i=0;i<your_string.length();i++){
        if(your_string[i]==' '){
            cout<<endl;
        }
        else{

        cout<<your_string[i];
        }
    }
}

void print_words(string your_string){
    string delim=" ";
    short pos=0;
    string worde;
    cout<<"the words is \n";
    while((pos=your_string.find(delim))!=std::string::npos){
        worde=your_string.substr(0,pos);
        if(worde!=""){
            cout<<worde<<endl;
        }

        your_string.erase(0,pos+delim.length());
    }
    if(your_string!=""){
        cout<<your_string;
    }
}


int main(){
    string name=read_string();
    print_word(name);cout<<endl<<endl;
    print_words(name);
}