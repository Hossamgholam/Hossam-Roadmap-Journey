#include<iostream>
#include<cmath>

using namespace std;

void read_number(float &n1,float &n2){
    cout<<"please inter length of rectangle:";cin>>n1;
    cout<<"please inter width of rectangle:";cin>>n2;
}

float rectangle_area(float n1,float n2){
    float result= n1*sqrt(pow(n2,2)-pow(n1,2));
    return result;
}

void print_area(float rectangle_area){
    cout<<"the area of rectangle:"<<rectangle_area<<endl;
}
int main(){
    float length,width;
    read_number(length,width);
    print_area(rectangle_area(length,width));
}

//cout<<a*sqrt(pow(a,2)-pow(b,2));