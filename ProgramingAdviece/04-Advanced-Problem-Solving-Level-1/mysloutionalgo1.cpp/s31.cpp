#include<iostream>
#include<cmath>
using namespace std;
int read_number(){
    int your_number;
    cout<<"please inter your number:";cin>>your_number;
    return your_number;
}
void power_2_3_4(int your_number){
    cout<<your_number<<"^2="<<your_number*your_number<<endl;
    cout<<your_number<<"^3="<<your_number*your_number*your_number<<endl;
    cout<<your_number<<"^4="<<your_number*your_number*your_number*your_number<<endl;
}
int main(){
    power_2_3_4(read_number());
}