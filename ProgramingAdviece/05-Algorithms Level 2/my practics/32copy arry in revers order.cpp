#include<iostream>
#include<cstdlib>
#include<ctime>
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

void copy_arry(int your_arry[100],int your_new_arry[100],int your_size){
    for(int i=0,y=your_size-1;i<your_size&&y>=0;i++,y--){
        your_new_arry[i]=your_arry[y];
    }
}

int main(){
    srand(time(0));
    int random_arry[100],new_arry[100]={},size;

    full_arry(random_arry,size);

    cout<<"the element of arry 1 is:";print_arry(random_arry,size);

    copy_arry(random_arry,new_arry,size);

    cout<<"the element of arry 2 is :";print_arry(new_arry,size);


}