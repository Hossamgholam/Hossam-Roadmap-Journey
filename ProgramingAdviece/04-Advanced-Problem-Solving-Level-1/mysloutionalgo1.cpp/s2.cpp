#include<iostream>
using namespace std;
string read_name( ){
    string name;
    cout<<"please inter your name:";cin>>name;
    return name;
}
void print_name(string yourname){
    cout<<"your name is:"<< yourname<<endl;
}
int main(){
    print_name(read_name());
}