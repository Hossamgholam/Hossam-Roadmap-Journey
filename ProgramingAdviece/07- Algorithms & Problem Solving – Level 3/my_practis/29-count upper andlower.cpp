#include<iostream>
#include<string>
using namespace std;
/*
read_string

conunt_length;

coutn captial
count small

*/

enum enwhat_count{upper=1,lower=2,all=3};

int count(string your_string,enwhat_count what_count=enwhat_count::all){
    if(what_count==enwhat_count::all){
        return your_string.length();
    }
    else{
            int counter=0;
        for(int i=0;i<your_string.length();i++){
            if(what_count==enwhat_count::lower&&islower(your_string[i])){
                counter++;
            }
            if(what_count==enwhat_count::upper&&isupper(your_string[i])){
                counter++;
            }
            
        }
        return counter;
    }
}
string read_string(){
    string name;
    cout<<"please inter your_char: ";getline(cin,name);

    return name;
}

int length(string your_string){
    return your_string.length();
}

int count_upper(string your_string){
    int counter=0;
    for(int i=0;i<your_string.length();i++){
        if(isupper(your_string[i])){
            counter++;
        }
    }
    return counter;
}
int count_lower(string your_string){
    int counter=0;
    for(int i=0;i<your_string.length();i++){
        if(islower(your_string[i])){
            counter++;
        }
    }
    return counter;
}

int main(){
    string name=read_string();

    cout<<"string lenght:"<<length(name)<<endl;

    cout<<"capital letter count:"<<count_upper(name)<<endl;

    cout<<"capital letter count:"<<count_lower(name)<<endl;


    cout<<"\nstring length:"<<count(name)<<endl;
    cout<<"capitall letter count:"<<count(name,enwhat_count::upper)<<endl;
    cout<<"capitall letter count:"<<count(name,enwhat_count::lower)<<endl;

}
