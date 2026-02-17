#include<iostream>
#include<cmath>
using namespace std;
float read_number(string message){
    float your_number;
   
        cout<<message;
        cin>>your_number;
    
    return your_number;
}
float my_sqrt(float your_number){
    return pow(your_number,.5);
}
int main(){
    float number=read_number("please inter your number:");
    cout<<"my sqrt result :"<<my_sqrt(number)<<endl;
    cout<<"cpp sqrt:"<<sqrt(number);

}