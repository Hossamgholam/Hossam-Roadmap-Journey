#include<iostream>
using namespace std;
int read_number(string message){
    int your_number;
    cout<<message;
    cin>>your_number;
    return your_number;
}




int revers_number_(int your_numbrer){
    int remind=0,number_revers=0;
    while(your_numbrer>0){
        remind=your_numbrer%10;
        your_numbrer/=10;
        number_revers=number_revers*10+remind;

    }
    return number_revers;
}

int main(){
  
    cout<<"the revers number in another way:"<<revers_number_(read_number("please itner number agin:"));
}