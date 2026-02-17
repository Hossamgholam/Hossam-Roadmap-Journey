#include<iostream>
using namespace std;
int read_number(string message){
    int your_number;
    cout<<message;
    cin>>your_number;
    return your_number;
}
void print_reverse(int your_number){
    
    while(your_number>0){
        int remaind=0;
        remaind=your_number%10;
        your_number/=10;
        cout<<remaind<<endl;
    }
}
int main(){
    print_reverse(read_number("please inter your number:"));
}