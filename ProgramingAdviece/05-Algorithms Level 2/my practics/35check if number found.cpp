#include<iostream>
#include<cstdlib>
#include<ctime>
using namespace std;
int read_number(string message){
    int number;
    do{

    cout<<message;
    cin>>number;
    }while(number<0);
    return number;
}
int randomvarible(int your_from,int your_to){
    int random=rand()%(your_to-your_from+1)+your_from;
    return random;
}
void full_arry(int your_arry[100],int &your_size){
    cout<<"please inter your size:";cin>>your_size;

    for(int i=0;i<your_size;i++){
        your_arry[i]=randomvarible(1,100);
    }
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
bool is_found(int your_arry[100],int your_search,int your_size){
    return postion(your_arry,your_search,your_size)!=-1;
}
void print_arry(int your_arry[100],int your_size){
    for(int i=0;i<your_size;i++){
        cout<<your_arry[i]<<" ";
    }
    cout<<"\n";
}

int main(){
    srand(time(0));
    int array_data[100],size;

    full_arry(array_data,size);
    cout<<"array 1element\n";
    print_arry(array_data,size);

    int searche_number=read_number("please inter your number:");
    bool found=is_found(array_data,searche_number,size);
    if(found==0){
        cout<<"the number you are looking for is:"<<searche_number<<"\n no it is not found:-(\n";
    }
    else{
        cout<<"the number your are lookin for is:"<<searche_number<<"\n yes it is found";
    }
}