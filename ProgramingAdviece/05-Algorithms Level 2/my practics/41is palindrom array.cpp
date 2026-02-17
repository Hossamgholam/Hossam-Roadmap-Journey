#include<iostream>
using namespace std;
/*
fill hard
is palind
*/
void fill_array(int your_array[100],int &your_size){
     your_size=6;
    your_array[0]=10;
    your_array[1]=20;
    your_array[2]=30;
    your_array[3]=30;
    your_array[4]=2;
    your_array[5]=10;
}

bool is_palindrom(int your_array[100],int your_size){
    bool palind=true;
    for (int i=0;i<your_size/2;i++){
        if(your_array[i]!=your_array[your_size-i-1]){
            palind=false;
            return palind;
        }
    }
    return palind;
}
void print_arry(int your_arry[100],int your_size){
    for(int i=0;i<your_size;i++){
        cout<<your_arry[i]<<" ";
    }
    cout<<endl;
}

int main(){
   int array_data[100],size;
   fill_array(array_data,size);
   cout<<"the array element is:";print_arry(array_data,size);

   if(is_palindrom(array_data,size)){
    cout<<"the array is palindrom\n";
   }
   else{
    cout<<"no the array is not palindrom\n";
   }
}