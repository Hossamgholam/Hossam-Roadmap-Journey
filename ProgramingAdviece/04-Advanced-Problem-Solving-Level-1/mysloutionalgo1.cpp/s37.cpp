#include<iostream>
using namespace std;
/// read number

///sum function
float read_number(){
    int your_number;
    cout<<"please inter your number:";cin>>your_number;
    return your_number;
}
float sum_number_until(){
    int sum=0;float number=0;int counter=1;
    do{

        number=read_number();
        if(number==-99){
            break;
        }
        else{
            sum+=number;
            counter++;
        }
    } while(number!=-99);
      return sum;  

}


int main(){
     cout<<"the sum of number is"<<sum_number_until();
}