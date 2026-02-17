#include<iostream>
using namespace std;
/*
add
check exist
*/
void add_number(int you_number,int your_arry[],int &your_size){
    your_arry[your_size]=you_number;
    your_size++;
}
int postion(int your_arry[100],int your_search,int your_size){
    int found=-1;
    for(int i=0;i<your_size;i++){
        if(your_arry[i]==your_search){
            found=i;
            return found;
        }
    }
    return found;
}
bool is_not_found(int your_arry[100],int your_search,int your_size){
    return postion(your_arry,your_search,your_size)==-1;
}
void check(int your_arry[100],int your_new_arry[100],int your_size,int &your_new_size ){
   
    for(int i=0;i<your_size;i++){
        
            if(is_not_found(your_new_arry,your_arry[i],your_new_size)){
                add_number(your_arry[i],your_new_arry,your_new_size);
            }
        
    }
}

void print_arry(int your_arry[100],int your_size){
    for(int i=0;i<your_size;i++){
        cout<<your_arry[i]<<" ";
    }
    cout<<endl;
}

int main(){
    int arry_data[100]={10,10,10,50,50,70,70,70,70,90}, new_arry[100],
    size=10,new_size=0;
    cout<<"your element is :";
    print_arry(arry_data,size);
    check(arry_data,new_arry,size,new_size);
    cout<<"your element after:";
    print_arry(new_arry,new_size);

}