#include<iostream>
#include<cmath>
using namespace std;
enum en_prime{prime=1,not_prim=2};
int read_number(string messages){
    int your_range;
    cout<<messages;cin>>your_range;
    return your_range;
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
void print_prime_number(int your_range){
    cout<<"the prime number from 1 to "<<your_range<<endl;
    for(int i=1;i<=your_range;i++){
        if(check_prime(i)==prime){
            cout<<i<<endl;
        }
    }
}
int main(){
       print_prime_number(read_number("please inter number:"));
}