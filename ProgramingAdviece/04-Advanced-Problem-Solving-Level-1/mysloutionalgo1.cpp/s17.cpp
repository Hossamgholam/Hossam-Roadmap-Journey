#include<iostream>
using namespace std;
void read_number(float &n1,float &n2){
    cout<<"please inter length of triangle:";cin>>n1;
    cout<<"please inter width of triangle:";cin>>n2;
}

float triangle_area(float n1,float n2){
    float result= .5*n1*n2;
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

/*int main(){
    float triangle_hieght,triangle_based;
    cout<<"please inter triangle hieght:";cin>>triangle_hieght;
    cout<<"please inter triangle based:";cin>>triangle_based;
    cout<<"the area of triangle is :"<<.5*triangle_based*triangle_hieght;
}*/