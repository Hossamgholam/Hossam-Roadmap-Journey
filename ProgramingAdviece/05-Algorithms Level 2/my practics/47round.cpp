#include<iostream>
#include<cmath>
using namespace std;
float read_number(string message){
    float your_number;
   
        cout<<message;
        cin>>your_number;
    
    return your_number;
}
float getfractionpart(float your_number){
    return your_number-int(your_number);
}
int my_round(float your_number){
    int intpart;
    intpart=(int)your_number;
    float fractionpart=getfractionpart(your_number);
    if(abs(fractionpart)>=0.5){
        if(your_number>0){
            ++intpart;
            return intpart;
        }
        else{
           --intpart;
           return intpart;
        }
    }
    else{
        return intpart;
    }
}
int main(){
     float number=read_number("please inter number");
    cout<<"my function:"<<my_round(number)<<endl;
    cout<<"cpp function:"<<round(number)<<endl;
    
}