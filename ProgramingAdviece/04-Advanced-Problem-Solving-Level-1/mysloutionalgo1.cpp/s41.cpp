#include<iostream>
using namespace std;
float read_number(string messages){
    float your_number;
    cout<<messages;cin>>your_number;
    return your_number;
}

float hour_day(float your_number){
    return your_number/24;
}
float hour_weak(float your_number){
    return your_number/24/7;
}
//float day_weak(float your_number){
 //   void;
//}
int main(){
      float number_ofhoure=read_number("please inter number of houre:");
      float number_day=hour_day(number_ofhoure);
      float number_weak=hour_weak(number_ofhoure);

      cout<<"the number of houre is:"<<number_ofhoure<<endl;
      cout<<"the number of day is:"<<number_day<<endl;
      cout<<"the number of weak is:"<<number_weak<<endl;
}