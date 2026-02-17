#include<iostream>
using namespace std;
int read_number(string message){
    int your_number;
    do{
        cout<<message;cin>>your_number;
    }while(your_number<0);
    return your_number;
}
void inverted(int your_number){
    for(int i=1;i<=your_number;i++){
        for(int y=1;y<=i;y++){
            cout<<i;
        }
        cout<<"\n";
    }
}
int main(){
    inverted(read_number("please inter your number:"));
}