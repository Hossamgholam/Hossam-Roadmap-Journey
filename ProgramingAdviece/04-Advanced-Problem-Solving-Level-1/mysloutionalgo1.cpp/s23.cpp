#include<iostream>
using namespace std;
#include<cmath>
void read_number(float& a,float& b,float& c){
    cout<<"please inter number 1:";cin>>a;
    cout<<"please inter number 2:";cin>>b;
    cout<<"please inter number 3:";cin>>c;
}

float caculat_t(float a ,float b,float c){
    const float pi=3.141592;
    float p=(a+b+c)/2;
    float t= ((a*b*c)/(4*sqrt(p*(p-a)*(p-b)*(p-c))));
    return pi*pow(t,2);
}
void print_t(float t){
    cout<<"the area of ciriclur:"<<t<<endl;
}


int main(){
    float a,b,c;

    read_number(a,b,c);
    print_t(caculat_t(a,b,c));
    
    
    

}
