#include<iostream>
#include<cmath>
using namespace std;
void read_number(float &n1,float &n2){
    cout<<"please inter length of triangle:";cin>>n1;
    cout<<"please inter width of triangle:";cin>>n2;
}

float triangle_area(float n1,float n2){
    const float pi=3.143;
    float result=(pi*(pow(n2,2)/4)*((2*n1)-n2)/((2*n1)+n2));
    return result;
}

void print_area(float triangle_area){
    cout<<"the area of rectangle:"<<triangle_area<<endl;
}
int main(){
    float length,width;
    read_number(length,width);
    print_area(triangle_area(length,width));
}

