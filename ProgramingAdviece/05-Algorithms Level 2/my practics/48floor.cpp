#include<iostream>
#include<cmath>
using namespace std;
float read_number(string message){
    float your_number;
   
        cout<<message;
        cin>>your_number;
    
    return your_number;
}


int my_floor(float your_number){
    int intpart;
    intpart=(int)your_number;
   
   
        if(your_number>0){
            
            return intpart;
        }
        else{
           --intpart;
           return intpart;
        }
}  
int main(){
     float number=read_number("please inter number");
    cout<<"my function:"<<my_floor(number)<<endl;
    cout<<"cpp function:"<<floor(number)<<endl;
    
}