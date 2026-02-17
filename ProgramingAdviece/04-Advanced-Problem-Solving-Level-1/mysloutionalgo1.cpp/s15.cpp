#include<iostream>
using namespace std;
void read_number(float &n1,float &n2){
    cout<<"please inter length of rectangle:";cin>>n1;
    cout<<"please inter width of rectangle:";cin>>n2;
}

float rectangle_area(float n1,float n2){
    return n1*n2;
}

void print_area(float n1,float n2){
    cout<<"the area of rectangle:"<<rectangle_area(n1,n2)<<endl;
}
int main(){
    float length,width;
    read_number(length,width);
    print_area(length,width);
}