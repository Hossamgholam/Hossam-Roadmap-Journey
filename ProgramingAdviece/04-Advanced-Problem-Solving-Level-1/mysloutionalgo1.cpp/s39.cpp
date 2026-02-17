#include <iostream>
using namespace std;
// read number
//calculat paid back
float read_number(string messages){
    float your_number;
    cout<<messages;cin>>your_number;
    return your_number;
}
float calculat_paid_back(float your_total_bill,float your_cash_paid){
    float your_paid_back=your_cash_paid-your_total_bill;
    return your_paid_back;

}
int main(){
     float total_bill=read_number("please inter the total_bill:");
     float cash_paid=read_number("please inter the cash_paid:");
     cout<<"the remainder tp paid back:"<<calculat_paid_back(total_bill,cash_paid);
}