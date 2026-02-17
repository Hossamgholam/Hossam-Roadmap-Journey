#include <iostream>
#include<cmath>
#include<iostream>
using namespace std;
// read number
//calculat paid back
enum en_prime{prime=1,not_prim=2};
int read_number(string messages){
    int your_number;
    cout<<messages;cin>>your_number;
    return your_number;
}
en_prime check_prime(int your_number){
    int m=round(your_number/2);
    for(int i=2;i<=m;i++){
        if(your_number%i==0){
            return en_prime::not_prim;
        }
    }
    return en_prime::prime;
}

void print_type(int your_number){
    switch(check_prime(your_number)){
        case en_prime::not_prim:cout<<"the number not prime\n";break;
        case en_prime::prime:cout<<"the number is prime\n";break;
    }
}

int main(){
    int number=read_number("please inter the number:");
     print_type(number);
     
}