#include<iostream>
#include<ctime>
using namespace std;
enum en_prime{odd=1,even=2};
int randomvariable(int your_from,int your_to){
    int random=rand()%(your_from-your_to+1)+your_from;
    return random;
}

void full_arry(int your_arry[100],int& your_size){
    cout<<"please inter your size of arry:";cin>>your_size;
    for(int i=0;i<your_size;i++){
        your_arry[i]=randomvariable(1,100);
    }
}
void print_arry(int your_arry[100],int your_size){
    for(int i=0;i<your_size;i++){
        cout<<your_arry[i]<<" ";
    }
    cout<<endl;
}
en_prime check_prime(int your_number){
   
   if(your_number%2==0){
    return en_prime::even;
   }
   else{
    return en_prime::odd;
   }
    
        
}
int count_odd(int your_array[100],int your_size){
    int count=0;
    for(int i=0;i<your_size;i++){
        if(check_prime(your_array[i])==en_prime::even){
            count++;
        }
    }
    return count;
}
int main(){
    srand(time(0));
    int array_data[100],size=0;
    full_arry(array_data,size);
    cout<<"the array element is :";print_arry(array_data,size);
    cout<<"the number of even :";
    cout<<count_odd(array_data,size);
}