#include<iostream>
#include<string>
using namespace std;
string read_string(){
    string name;
    cout<<"please inter your_char: ";getline(cin,name);

    return name;
}

char invert_charcter(char your_char){
  
    return (isupper(your_char))?tolower(your_char):toupper(your_char);
    
}
string invert_all_letter(string your_char){
    for(int i=0;i<your_char.length();i++){

     your_char[i]=invert_charcter(your_char[i]);
    }
    return your_char;
}
int main(){
    string a=read_string();

    cout<<"the char after invert\n";
    cout<<invert_all_letter(a);
}