#include<iostream>
#include<string>
using namespace std;
/*
read char
check is vower
*/
char read_char(){
    char name;
    cout<<"please inter your_char: ";cin>>name;

    return name;
}

bool is_vower(char your_letter){
    your_letter=tolower(your_letter);

    return (your_letter=='a'||your_letter=='e'||your_letter=='i'||your_letter=='o'||your_letter=='u')?true:false;
}
int main(){
    char your_char=read_char() ;

    if(is_vower(your_char)){
        cout<<"the char is vower:\n";
    }
    else{
        cout<<"the char not vower:\n";
    }
    
}