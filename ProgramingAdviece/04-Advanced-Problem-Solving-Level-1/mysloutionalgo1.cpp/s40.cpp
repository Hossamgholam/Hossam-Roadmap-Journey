#include <iostream>
using namespace std;
// read number
//calculat paid back
float read_number(string messages){
    float your_number;
    cout<<messages;cin>>your_number;
    return your_number;
}
float totalbill_after(float your_billvalue){
    float totalbill=your_billvalue*1.1;
    totalbill*=1.16;
    return totalbill;

}
int main(){
     float total_bill=read_number("please inter the total_bill:");
     
     cout<<"the total billlll after add servierer:"<<totalbill_after(total_bill);
}