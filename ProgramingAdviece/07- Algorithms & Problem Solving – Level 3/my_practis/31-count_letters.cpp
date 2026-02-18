#include<iostream>
#include<string>
using namespace std;
/*
read_string

read_char

count_char

*/


string read_string(){
    string name;
    cout<<"please inter your_char: ";getline(cin,name);

    return name;
}

char read_char(){
    char name;
    cout<<"please inter your_char: ";cin>>name;

    return name;
}


int count_char(string your_string,char your_char){
    int counter=0;
    for(int i=0;i<your_string.length();i++){
        if(your_string[i]==your_char){
            counter++;
        }
    }
    return counter;
}

char invert_charcter(char your_char){
  
    return (isupper(your_char))?tolower(your_char):toupper(your_char);
    
}
int count_letter(string your_string,char your_char,bool matchcase=true){
    int counter=0;
    
    for(int i=0;i<your_string.length();i++){
        if(matchcase){
             if(your_string[i]==your_char){
                 counter++;
             }
        }
        else{
            if(tolower(your_string[i])==tolower(your_char)){
                counter++;
            }
        }
    }
    return counter;
}


int main(){
    string name=read_string();
    char char_search=read_char();

    cout<<"letter "<<char_search<<" count:"<<count_letter(name,char_search)<<endl;

    

    cout<<"letter "<<char_search<<" or "<<invert_charcter(char_search)<<" count::"<<count_letter(name,char_search,false);

}
