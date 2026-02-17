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
int min_number_arry(int your_arry[100],int your_size){
    int min_number=your_arry[0];
    for(int i=1;i<your_size;i++){
        if(your_arry[i]<=min_number){
            min_number=your_arry[i];
        }
    }
    return min_number;
}

int main(){
    srand(time(0));
    int random_arry[100],size;

    full_arry(random_arry,size);
    
    cout<<"the element of arry is:";print_arry(random_arry,size);

    cout<<"the max number in arry is :"<<min_number_arry(random_arry,size);

}