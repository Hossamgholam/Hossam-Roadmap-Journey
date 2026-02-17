#include<iostream>
#include<cstdlib>
#include<ctime>
#include<cmath>
using namespace std;

enum en_prime{odd=1,even=2};
int randomvariable(int your_from,int your_to){
    int random=rand()%(your_to-your_from+1)+your_from;
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

void add_number(int you_number,int your_arry[],int &your_size){
    your_arry[your_size]=you_number;
    your_size++;
}

void copy_arry(int your_arry[100],int your_new_arry[100],int your_size,int &your_new_size){
    for(int i=0;i<your_size;i++){
       if(check_prime(your_arry[i])==en_prime::odd){
        add_number(your_arry[i],your_new_arry,your_new_size);
       }
    }
}


int main(){
    srand(time(0));
    int random_arry[100],new_arry[100]={},size,new_size=0;

    full_arry(random_arry,size);

    cout<<"the element of arry 1 is:";print_arry(random_arry,size);

    copy_arry(random_arry,new_arry,size,new_size);

    cout<<"the element of arry 2 is :";print_arry(new_arry,new_size);

   

}