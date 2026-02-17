#include<iostream>
#include<cstdlib>
#include<ctime>
using namespace std;
/*
randomvariable
full arry 
print arry 
sum two arry
*/
int read_number(string message){
    int number;
    do{

    cout<<message;
    cin>>number;
    }while(number<0);
    return number;
}
int randomvariable(int your_from,int your_to){
    int random=rand()%(your_from-your_to+1)+your_from;
    return random;
}

void full_arry(int your_arry[100],int your_size){
    
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

void fn_sum_arry(int your_arry[100],int your_arry2[100],int your_sum_arry[100],int your_size){
    for(int i=0;i<your_size;i++){
       your_sum_arry[i]=your_arry[i]+your_arry2[i];
    }
}

int main(){
    srand(time(0));
    int random_arry[100], random2_arry[100],sum_arry[100],
    size=read_number("please inter your size:");

    full_arry(random_arry,size);
    full_arry(random2_arry,size);

    cout<<"the element of arry 1 is:";print_arry(random_arry,size);
    cout<<"the element of arry 1 is:";print_arry(random2_arry,size);

    fn_sum_arry(random_arry,random2_arry,sum_arry,size);
   //it print only primy number
    cout<<"the element of sum arryis:";print_arry(sum_arry,size);


}