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
int sum_number_arry(int your_arry[100],int your_size){
    int sum_number=0;
    for(int i=0;i<your_size;i++){
       sum_number+=your_arry[i];
    }
    return sum_number;
}

int main(){
    srand(time(0));
    int random_arry[100],size;

    full_arry(random_arry,size);
    
    cout<<"the element of arry is:";print_arry(random_arry,size);

    cout<<"the sum number in arry is :"<<sum_number_arry(random_arry,size);

}