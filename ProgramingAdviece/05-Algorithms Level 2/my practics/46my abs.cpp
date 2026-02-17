#include<iostream>
#include<cmath>
using namespace std;
int read_number(string message){
    int your_number;
   
        cout<<message;cin>>your_number;
    
    return your_number;
}
int my_abs(int your_number){
    if(your_number>=0){
        return your_number;
    }
    else{
        return your_number*-1;
    }
}
int main(){
    int number=read_number("please inter number");
    cout<<"my function:"<<my_abs(number)<<endl;
    cout<<"cpp function:"<<abs(number)<<endl;
    cout<<(int)(12.7*10)%10;
  
}