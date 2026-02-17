#include<iostream>
using namespace std;
#include<cmath>
void read_number(int &your_number,int &your_power){
    
    cout<<"please inter your number:";cin>>your_number;
    cout<<"please inter your power number:";cin>>your_power;

    
}
int calculat_power(int your_number,int your_power){
    if(your_power==0){
        return 1;
    }
    else{
      int   sum=your_number;
      for(int i=2;i<=your_power;i++){
        sum*=your_number;
      }
      return sum;
    }
}
void print_number_power(int your_result){
    cout<<"the result is: "<<your_result<<endl;
}
int main(){
    int number,power;
    read_number(number,power);
    print_number_power(calculat_power(number,power));
}