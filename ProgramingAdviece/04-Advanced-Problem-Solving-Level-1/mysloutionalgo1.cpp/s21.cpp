#include<iostream>
using namespace std;
float read_number(){
    float n1;
    cout<<"please inter length of circule:";cin>>n1;
    return n1;
    
}

float circule_area(float n1){
  const float pi=3.14;
    float result= (n1*n1)/(4*pi);
    return result;
}

void print_area(float circule_area){
    cout<<"the area of rcircule:"<<circule_area<<endl;
}
int main(){
    float reduis;
    
    print_area(circule_area(read_number()));
}

