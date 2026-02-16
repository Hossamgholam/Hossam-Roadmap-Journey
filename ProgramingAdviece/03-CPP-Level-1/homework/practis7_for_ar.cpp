#include<iostream>
using namespace std;

/*
function read (number of arry, inter number)
function calculat sum()
function calculat average()
function print number of arry, 

*/

void read_data(int your_arry_data[100],int &your_length){
     cout<<"please inter number of arry:";cin>>your_length;
     for(int i=0;i<your_length;i++){
        cout<<"please inter number "<<i+1<<":";cin>>your_arry_data[i];
     }  
}


void print_data(int your_arry_data[100],int your_length){
    for(int i=0;i<your_length;i++){
        cout<<"number["<<i+1<<"]:"<<your_arry_data[i]<<"\n";
    }
}



int clculat_sum(int your_arry_data[100],int your_length){
    int sum=0;
    for (int i=0;i<your_length;i++){
        sum+=your_arry_data[i];
    }
    return sum;
}


float clculat_average(int your_arry_data[100],int your_length){
    float average;
    average=clculat_sum(your_arry_data,your_length)/your_length;
    
    return average;
}


struct person{
   string frist_name;
   string last_name;
   short age;
   string phone;
};
void read_info(person &yourstruct){

    cout<<"******************************************************\n";
   cout<<"please inter your frist name:";cin>>yourstruct.frist_name;
   cout<<"please inter your last  name:";cin>>yourstruct.last_name;
   cout<<"please inter your  age:";cin>>yourstruct.age;
   cout<<"please inter your phone:";cin>>yourstruct.phone;
    cout<<"******************************************************\n";
}
void writ_info(person yourstruct){
    cout<<"************************************************\n";
    cout<<"your frist name is:"<<yourstruct.frist_name<<"\n";
    cout<<"your last name is:"<<yourstruct.last_name<<"\n";
    cout<<"your age  is:"<<yourstruct.age<<"\n";
    cout<<"your phone is:"<<yourstruct.phone<<"\n";
    cout<<"************************************************\n";
}
void readperson_info(person yourcompany[100],int  &your_length){
    cout<<"please inter number of person of compay:";cin>>your_length;
    cout<<"************************************************************\n";

    for(int i=0;i<your_length;i++){
          cout<<"please inter information of person "<<i+1<<"\n ";read_info(yourcompany[i]);
    }
}
void writperson_info(person yourcompany[100],int your_length){
    cout<<"________________________information of person___________________________________\n";
    for(int i=0;i<your_length;i++){
        writ_info(yourcompany[i]);
    }
}

int main(){
/*
int arry_data[100],length=0;
   read_data(arry_data,length);
   print_data(arry_data,length);
   cout<<"*****************************************************\n";
   cout<<"the sum of number is"<<clculat_sum(arry_data,length)<<endl;
   cout<<"this is average of number:"<<clculat_average(arry_data,length);
*/

person arry_person[100];int length=0;
readperson_info(arry_person,length);
writperson_info(arry_person,length);

}