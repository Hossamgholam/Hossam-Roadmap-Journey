#include<iostream>
using namespace std;
/*
arry size
read number
read arry
print arry
*/

int read_number(string message){
    int number;
    cout<<message;cin>>number;
    return number;
}
void add_number(int you_number,int your_arry[],int &your_size){
    your_arry[your_size]=you_number;
    your_size++;
}

void read_arry(int your_array[],int &your_size){
    bool repeat;
    do{
        add_number(read_number("please inter number?"),your_array,your_size);
        cout<<"do you want to addmore number:[0]no :[1]yes:";cin>>repeat;
    }while(repeat==1);

}
void print(int your_array[],int your_size){
    
    for(int i=0;i<your_size;i++){
        cout<<your_array[i]<<" ";
    }
}
 

int main(){
    int arry_data[100],size=0;

    read_arry(arry_data,size);

    cout<<"the length :"<<size<<endl;
    cout<<"the element is ";print(arry_data,size);
}