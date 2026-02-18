#include<iostream>
#include<string>
using namespace std;
/*
read_string


print_vowe
*/


string read_string(){
    string name;
    cout<<"please inter your_char: ";getline(cin,name);

    return name;
}

bool is_vower(char your_letter){
    your_letter=tolower(your_letter);

    return (your_letter=='a'||your_letter=='e'||your_letter=='i'||your_letter=='o'||your_letter=='u')?true:false;
}


void print_vower(string your_string){
    
    for(int i=0;i<your_string.length();i++){
        if(is_vower(your_string[i])){
            cout<<your_string[i]<<"     ";
        }
    }
    
}





int main(){
    string name=read_string();
    cout<<"number of vowerls is :";print_vower(name);

    


}
