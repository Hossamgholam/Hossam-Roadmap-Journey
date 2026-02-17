#include<iostream>
using namespace std;
int read(){
    int number;
    cout<<"please inter your number:";cin>>number;
    return number;
}
float divise_number(int your_number){
    return (float)your_number/2;
}
void print_divise_number(int your_number){
    cout<<"the haif of "<<your_number<<" is "<<divise_number(your_number)<<endl;
}
int main(){

    print_divise_number(read());
    
    return 0;
}