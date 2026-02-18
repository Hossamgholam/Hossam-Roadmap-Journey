#include<iostream>
#include<string>
using namespace std;
char read_string(){
    char name;
    cout<<"please inter your_char: ";cin>>name;

    return name;
}


char invert_charcter(char your_char){
  
    return (isupper(your_char))?tolower(your_char):toupper(your_char);
    
}
int main(){
    char a=read_string();

    cout<<"the char after invert\n";
    cout<<invert_charcter(a);
}