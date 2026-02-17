#include<iostream>
#include<cstdlib>
#include<ctime>
#include<cmath>
using namespace std;
/*
randomvariable
full arry 
print arry 
max number
*/
enum en_prime{prime=1,not_prim=2};
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
    int m=round(your_number/2);
    for(int i=2;i<=m;i++){
        if(your_number%i==0){
            return en_prime::not_prim;
        }
    }
    return en_prime::prime;
}
//use it to copy only prime number in new
void copy_arry(int your_arry[100],int your_new_arry[100],int your_size,int& your_new_size){
    int counter=0;

    for(int i=0;i<your_size;i++){
        if(check_prime(your_arry[i])==en_prime::prime){
            your_new_arry[counter]=your_arry[i];
            counter++;
        }
    }
    your_new_size=counter;
}

int main(){
    srand(time(0));
    int random_arry[100],new_arry[100]={},size,new_size=0;

    full_arry(random_arry,size);

    cout<<"the element of arry 1 is:";print_arry(random_arry,size);

    copy_arry(random_arry,new_arry,size,new_size);

    cout<<"the element of arry 2 is :";print_arry(new_arry,new_size);

   

}