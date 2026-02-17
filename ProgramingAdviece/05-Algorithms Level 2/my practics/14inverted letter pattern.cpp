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
    int start=(your_number-1)+65;
    for(int i=start;i>=65;i--){
        for(int y=65;y<=i;y++){
            cout<<char(i);
        }
        cout<<"\n";
    }
}
int main(){
    inverted(read_number("please inter your:"));
}