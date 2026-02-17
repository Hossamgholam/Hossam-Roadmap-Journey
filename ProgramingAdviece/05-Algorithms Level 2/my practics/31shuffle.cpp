#include<iostream>
#include<cstdlib>
#include<ctime>
using namespace std;
/*
arry ,length,new arry

full arry read lenght
random_plasec
print arry

*/
void full_arry(int your_arry[],int &your_size){
    cout<<"please inter your size of arry:";cin>>your_size;
    for(int i=0;i<your_size;i++){
        your_arry[i]=i+1;
    }
}
int randome_index(int your_from,int your_to){
    int random=rand()%(your_from-your_to+1)+your_from;
    return random;
}
void swap(int &number3,int &number4){
   int temp=number3;
    number3=number4;
    number4=temp;
   
}
void shuffle(int your_arry[],int your_size){
   
    for(int i=0;i<your_size;i++){
      
       swap(your_arry[randome_index(0,your_size-1)],your_arry[randome_index(0,your_size-1)]);
      
    }
}
void print_arry(int your_arry[],int your_size){
    for(int i=0;i<your_size;i++){
        cout<<your_arry[i]<<" ";
    }
    cout<<endl;
}
int main(){
    srand(time(0));
    int size,arry_data[100];

    full_arry(arry_data,size);
    cout<<"arry element befor shuffle\n";
    print_arry(arry_data,size);

    shuffle(arry_data,size);

    cout<<"arry after\n";
    print_arry(arry_data,size);
}