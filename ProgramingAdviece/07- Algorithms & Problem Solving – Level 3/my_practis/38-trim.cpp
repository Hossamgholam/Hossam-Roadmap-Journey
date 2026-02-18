#include<iostream>
#include<string>
#include<vector>
using namespace std;
/*
read string
tirme left
tirm right
tirme 
*/
string read_string(){
    string name;
    cout<<"please inter your_char: ";getline(cin,name);

    return name;
}

string trim_left(string your_string){
    
    for(int i=0;i<your_string.length();i++){
        if(your_string[i]!=' '){
            return your_string.substr(i,your_string.length()-1);
        }
    }
    return "";
}
string trim_right(string your_string){
   
    for(int i=your_string.length()-1;i>=0;i--){
        if(your_string[i]!=' '){
           return your_string.substr(0,i+1);
        }
    }
    return "";
}
string trim( string your_string){
   return trim_left(trim_right(your_string));
}

int main(){
 string name=read_string();
 cout<<trim_left(name)<<endl;
 
 cout<<trim_right(name)<<endl;

cout<<trim(name)<<endl;
 

}