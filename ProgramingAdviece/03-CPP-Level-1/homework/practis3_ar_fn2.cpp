#include<iostream>
using namespace std;
/*
arry
function read
function calculat average
function print
*/

void read_grade(short yourarry[3]){
     cout<<"inter your grade:";cin>>yourarry[0];
     cout<<"inter your grade:";cin>>yourarry[1];
     cout<<"inter your grade:";cin>>yourarry[2];
     cout<<"**********************************\n";
}
float average_grade(short yourarry[3]){
     
     float average=(yourarry[0]+yourarry[1]+yourarry[2])/3;
     return average;
}
void print_average_grade(float youraverage){
    cout<<"your average is:"<<youraverage;
}
int main(){
    short arry_of_grade[3];
    read_grade(arry_of_grade);
    float average=average_grade(arry_of_grade);
    print_average_grade(average);
}