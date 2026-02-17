#include<iostream>
using namespace std;
void print_name(){
    cout<<"my name is hossam\n";
}
void print_name(string your_name){
    cout<<"your name is :"<<your_name<<endl;
}
int main(){
    print_name();
    print_name("hossam");
}